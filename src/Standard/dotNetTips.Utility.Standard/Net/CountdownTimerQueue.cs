// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="CountdownTimerQueue.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Runtime.InteropServices;
using static dotNetTips.Utility.Standard.Net.CountdownTimer;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Represents a queue of timers of fixed duration.
    /// Implements the <see cref="dotNetTips.Utility.Standard.Net.CountdownTimerQueue" />
    /// Implements the <see cref="dotNetTips.Utility.Standard.Net.TimerQueue" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Net.TimerQueue" />
    /// <seealso cref="dotNetTips.Utility.Standard.Net.CountdownTimerQueue" />
    public class CountdownTimerQueue : TimerQueue
    {

        // This sentinel TimerNode acts as both the head and the tail, allowing nodes to go in and out of the list without updating
        // any TimerQueue members.  _timers.Next is the true head, and .Prev the true tail.  This also serves as the list's lock.
        private readonly CountdownTimerNode _timers;

        // This is a GCHandle that holds onto the TimerQueue when active timers are in it.
        // The TimerThread only holds WeakReferences to it so that it can be collected when the user lets go of it.
        // But we don't want the user to HAVE to keep a reference to it when timers are active in it.
        // It gets created when the first timer gets added, and cleaned up when the TimerThread notices it's empty.
        // The TimerThread will always notice it's empty eventually, since the TimerThread will always wake up and
        // try to fire the timer, even if it was cancelled and removed prematurely.
        private IntPtr _thisHandle;

        /// <summary>
        /// Create a new TimerQueue.  TimerQueues must be created while s_NewQueues is locked in
        /// order to synchronize with Shutdown().
        /// </summary>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        public CountdownTimerQueue(int durationMilliseconds) : base(durationMilliseconds)
        {
            // Create the doubly-linked list with a sentinel head and tail so that this member never needs updating.
            _timers = new CountdownTimerNode();
            _timers.Next = _timers;
            _timers.Prev = _timers;
        }

        /// <summary>
        /// Creates new timers.  This method is thread-safe.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <returns>CountdownTimerTimer.</returns>
        public override CancelationTimer CreateTimer(Callback callback, object context)
        {
            var timer = new CountdownTimerNode(callback, context, Duration, _timers);

            // Add this on the tail.  (Actually, one before the tail - _timers is the sentinel tail.)
            var needProd = false;

            lock (_timers)
            {
                //if (!(_timers.Prev!.Next == _timers))
                //{
                //    NetEventSource.Fail(this, $"Tail corruption.");
                //}

                // If this is the first timer in the list, we need to create a queue handle and prod the timer thread.
                if (_timers.Next == _timers)
                {
                    if (_thisHandle == IntPtr.Zero)
                    {
                        _thisHandle = (IntPtr)GCHandle.Alloc(this);
                    }
                    needProd = true;
                }

                timer.Next = _timers;
                timer.Prev = _timers.Prev;
                _timers.Prev.Next = timer;
                _timers.Prev = timer;
            }

            // If, after we add the new tail, there is a chance that the tail is the next
            // node to be processed, we need to wake up the timer thread.
            if (needProd)
            {
                CountdownTimer.Prod();
            }

            return timer;
        }

        /// <summary>
        /// Called by the timer thread to fire the expired timers.  Returns true if there are future timers
        /// in the queue, and if so, also sets nextExpiration.
        /// </summary>
        /// <param name="nextExpiration">The next expiration.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Fire(out int nextExpiration)
        {
            while (true)
            {
                // Check if we got to the end.  If so, free the handle.
                CountdownTimerNode timer = _timers.Next;
                if (timer == _timers)
                {
                    lock (_timers)
                    {
                        timer = _timers.Next;
                        if (timer == _timers)
                        {
                            if (_thisHandle != IntPtr.Zero)
                            {
                                ((GCHandle)_thisHandle).Free();
                                _thisHandle = IntPtr.Zero;
                            }

                            nextExpiration = 0;
                            return false;
                        }
                    }
                }

                if (!timer.Fire())
                {
                    nextExpiration = timer.Expiration;
                    return true;
                }
            }
        }

    }
}
