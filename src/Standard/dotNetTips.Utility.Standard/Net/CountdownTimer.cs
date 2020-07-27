// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="CountdownTimer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Acts as countdown timer, used to measure elapsed time over a sync operation.
    /// </summary>
    public static class CountdownTimer
    {
        private const int CacheScanPerIterations = 32;
        private const int DefaultTimeout = 30 * 1000;
        private const int ThreadIdleTimeoutMilliseconds = DefaultTimeout;
        private const int TickCountResolution = 15;
        private static readonly LinkedList<WeakReference> _newQueues = new LinkedList<WeakReference>();
        private static readonly LinkedList<WeakReference> _queues = new LinkedList<WeakReference>();
        private static readonly Hashtable _queuesCache = new Hashtable();
        private static readonly WaitHandle[] _threadEvents = { _threadShutdownEvent, _threadReadyEvent };
        private static readonly AutoResetEvent _threadReadyEvent = new AutoResetEvent(false);
        private static readonly ManualResetEvent _threadShutdownEvent = new ManualResetEvent(false);
        private static int _cacheScanIteration;
        private static int _threadState = (int)TimerThreadState.Idle;  // Really a TimerThreadState, but need an int for Interlocked.

        /// <summary>
        /// Prototype for the callback that is called when a timer expires.
        /// </summary>
        /// <param name="timer">The timer.</param>
        /// <param name="timeNoticed">The time noticed.</param>
        /// <param name="context">The context.</param>
        public delegate void Callback(CancelationTimer timer, int timeNoticed, object context);

        /// <summary>
        /// Queue factory.  Always synchronized.
        /// </summary>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        /// <returns>CountdownTimerQueue.</returns>
        public static TimerQueue GetOrCreateQueue(int durationMilliseconds)
        {
            Encapsulation.TryValidateParam<ArgumentException>(durationMilliseconds.IsNegative() == false, nameof(durationMilliseconds));

            if (durationMilliseconds == Timeout.Infinite)
            {
                return new InfiniteTimerQueue();
            }

            TimerQueue queue;
            object key = durationMilliseconds; // Box once.
            var weakQueue = (WeakReference)_queuesCache[key];

            if (weakQueue == null || (queue = (TimerQueue)weakQueue.Target) == null)
            {
                lock (_newQueues)
                {
                    weakQueue = (WeakReference)_queuesCache[key];
                    if (weakQueue == null || (queue = (TimerQueue)weakQueue.Target) == null)
                    {
                        queue = new CountdownTimerQueue(durationMilliseconds);
                        weakQueue = new WeakReference(queue);
                        _newQueues.AddLast(weakQueue);
                        _queuesCache[key] = weakQueue;

                        // Take advantage of this lock to periodically scan the table for garbage.
                        if (++_cacheScanIteration % CacheScanPerIterations == 0)
                        {
                            var garbage = new List<object>();
                            // Manual use of IDictionaryEnumerator instead of foreach to avoid DictionaryEntry box allocations.
                            IDictionaryEnumerator e = _queuesCache.GetEnumerator();
                            while (e.MoveNext())
                            {
                                DictionaryEntry pair = e.Entry;
                                if (((WeakReference)pair.Value).Target is null)
                                {
                                    garbage.Add(pair.Key);
                                }
                            }
                            for (var i = 0; i < garbage.Count; i++)
                            {
                                _queuesCache.Remove(garbage[i]);
                            }
                        }
                    }
                }
            }

            return queue;
        }

        /// <summary>
        /// Helper for deciding whether a given TickCount is before or after a given expiration
        /// tick count assuming that it can't be before a given starting TickCount.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="comparand">The comparand.</param>
        /// <returns><c>true</c> if [is tick between] [the specified start]; otherwise, <c>false</c>.</returns>
        public static bool IsTickBetween(int start, int end, int comparand)
        {
            // Assumes that if start and end are equal, they are the same time.
            // Assumes that if the comparand and start are equal, no time has passed,
            // and that if the comparand and end are equal, end has occurred.
            return ((start <= comparand) == (end <= comparand)) != (start <= end);
        }

        /// <summary>
        /// Internal mechanism used when timers are added to wake up / create the thread.
        /// </summary>
        public static void Prod()
        {
            _threadReadyEvent.Set();

            var oldState = (TimerThreadState)Interlocked.CompareExchange(ref _threadState, (int)TimerThreadState.Running, (int)TimerThreadState.Idle);

            if (oldState == TimerThreadState.Idle)
            {
                new Thread(new ThreadStart(ThreadProc)).Start();
            }
        }

        /// <summary>
        /// <para>Thread for the timer.  Ignores all exceptions.  If no activity occurs for a while,
        /// the thread will shut down.</para>
        /// </summary>
        private static void ThreadProc()
        {
            // Set this thread as a background thread.  On AppDomain/Process shutdown, the thread will just be killed.
            Thread.CurrentThread.IsBackground = true;

            // Keep a permanent lock on s_Queues.  This lets for example Shutdown() know when this thread isn't running.
            lock (_queues)
            {
                // If shutdown was recently called, abort here.
                if (Interlocked.CompareExchange(ref _threadState, (int)TimerThreadState.Running, (int)TimerThreadState.Running) !=
                    (int)TimerThreadState.Running)
                {
                    return;
                }

                var running = true;
                while (running)
                {
                    try
                    {
                        _threadReadyEvent.Reset();

                        while (true)
                        {
                            // Copy all the new queues to the real queues.  Since only this thread modifies the real queues, it doesn't have to lock it.
                            if (_newQueues.Count > 0)
                            {
                                lock (_newQueues)
                                {
                                    for (LinkedListNode<WeakReference> node = _newQueues.First; node != null; node = _newQueues.First)
                                    {
                                        _newQueues.Remove(node);
                                        _queues.AddLast(node);
                                    }
                                }
                            }

                            var now = Environment.TickCount;
                            var nextTick = 0;
                            var haveNextTick = false;
                            for (LinkedListNode<WeakReference> node = _queues.First; node != null; /* node = node.Next must be done in the body */)
                            {
                                var queue = (CountdownTimerQueue)node.Value.Target;
                                if (queue == null)
                                {
                                    LinkedListNode<WeakReference> next = node.Next;
                                    _queues.Remove(node);
                                    node = next;
                                    continue;
                                }

                                // Fire() will always return values that should be interpreted as later than 'now' (that is, even if 'now' is
                                // returned, it is 0x100000000 milliseconds in the future).  There's also a chance that Fire() will return a value
                                // intended as > 0x100000000 milliseconds from 'now'.  Either case will just cause an extra scan through the timers.
                                int nextTickInstance;
                                if (queue.Fire(out nextTickInstance) && (!haveNextTick || IsTickBetween(now, nextTick, nextTickInstance)))
                                {
                                    nextTick = nextTickInstance;
                                    haveNextTick = true;
                                }

                                node = node.Next;
                            }

                            // Figure out how long to wait, taking into account how long the loop took.
                            // Add 15 ms to compensate for poor TickCount resolution (want to guarantee a firing).
                            var newNow = Environment.TickCount;
                            var waitDuration = haveNextTick ?
                                (int)(IsTickBetween(now, nextTick, newNow) ?
                                    Math.Min(unchecked((uint)(nextTick - newNow)), (uint)(int.MaxValue - TickCountResolution)) + TickCountResolution :
                                    0) :
                                ThreadIdleTimeoutMilliseconds;

                            //if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(null, $"Waiting for {waitDuration}ms");

                            var waitResult = WaitHandle.WaitAny(_threadEvents, waitDuration, false);

                            // 0 is s_ThreadShutdownEvent - die.
                            if (waitResult == 0)
                            {
                                //if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(null, "Awoke, cause: Shutdown");
                                running = false;
                                break;
                            }

                            //if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(null, $"Awoke, cause {(waitResult == WaitHandle.WaitTimeout ? "Timeout" : "Prod")}");

                            // If we timed out with nothing to do, shut down.
                            if (waitResult == WaitHandle.WaitTimeout && !haveNextTick)
                            {
                                Interlocked.CompareExchange(ref _threadState, (int)TimerThreadState.Idle, (int)TimerThreadState.Running);
                                // There could have been one more prod between the wait and the exchange.  Check, and abort if necessary.
                                if (_threadReadyEvent.WaitOne(0, false))
                                {
                                    if (Interlocked.CompareExchange(ref _threadState, (int)TimerThreadState.Running, (int)TimerThreadState.Idle) ==
                                        (int)TimerThreadState.Idle)
                                    {
                                        continue;
                                    }
                                }

                                running = false;
                                break;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        if (exception.IsFatal())
                        {
                            throw;
                        }
                    }
                }
            }
        }

    }
}
