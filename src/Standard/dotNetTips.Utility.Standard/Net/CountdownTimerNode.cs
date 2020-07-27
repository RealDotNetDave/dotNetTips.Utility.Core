// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="TimerNode.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using dotNetTips.Utility.Standard.Extensions;
using static dotNetTips.Utility.Standard.Net.CountdownTimer;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Internal representation of an individual timer.
    /// Implements the <see cref="dotNetTips.Utility.Standard.Net.CancelationTimer" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Net.CancelationTimer" />
    internal class CountdownTimerNode : CancelationTimer
    {

        private readonly object _queueLock = null;
        private Callback _callback;
        private object _context;
        private CountdownTimerNode _next;
        private CountdownTimerNode _prev;
        private TimerState _timerState;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimerNode"/> class.
        /// A sentinel node - both the head and tail are one, which prevent 
        /// the head and tail from ever having to be updated.
        /// </summary>
        public CountdownTimerNode() : base(0)
        {
            _timerState = TimerState.Sentinel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimerNode"/> class.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        /// <param name="queueLock">The queue lock.</param>
        public CountdownTimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) : base(durationMilliseconds)
        {
            if (callback != null)
            {
                _callback = callback;
                _context = context;
            }

            _timerState = TimerState.Ready;
            _queueLock = queueLock;
        }

        /// <summary>
        /// Status of the timer.
        /// </summary>
        public enum TimerState
        {
            /// <summary>
            /// Timer is ready
            /// </summary>
            Ready,

            /// <summary>
            /// Timer has fired
            /// </summary>
            Fired,

            /// <summary>
            /// Timer is cancelled
            /// </summary>
            Cancelled,

            /// <summary>
            /// Timer sentinel
            /// </summary>
            Sentinel
        }

        /// <summary>
        /// Whether or not the timer has expired.
        /// </summary>
        /// <value><c>true</c> if this instance has expired; otherwise, <c>false</c>.</value>
        public override bool HasExpired => _timerState == TimerState.Fired;

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>The next.</value>
        public CountdownTimerNode Next
        {
            get => _next;
            set => _next = value;
        }

        /// <summary>
        /// Gets or sets the previous.
        /// </summary>
        /// <value>The previous.</value>
        public CountdownTimerNode Prev
        {
            get => _prev;
            set => _prev = value;
        }

        /// <summary>
        /// Cancels the timer.  Returns true if it hasn't and won't fire; false if it has or will, or has already been cancelled.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public override bool Cancel()
        {
            if (_timerState == TimerState.Ready)
            {
                lock (_queueLock)
                {
                    if (_timerState == TimerState.Ready)
                    {
                        // Remove it from the list.  This keeps the list from getting too big when there are a lot of rapid creations
                        // and cancellations.  This is done before setting it to Cancelled to try to prevent the Fire() loop from
                        // seeing it, or if it does, of having to take a lock to synchronize with the state of the list.
                        Next.Prev = Prev;
                        Prev.Next = Next;

                        // Just cleanup.  Doesn't need to be in the lock but is easier to have here.
                        Next = null;
                        Prev = null;
                        _callback = null;
                        _context = null;

                        _timerState = TimerState.Cancelled;

                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Fires the timer if it is still active and has expired.  Returns
        /// true if it can be deleted, or false if it is still timing.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Fire()
        {
            //if (_timerState == TimerState.Sentinel)
            //{
            //    if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, "TimerQueue tried to Fire a Sentinel.");
            //}

            if (_timerState != TimerState.Ready)
            {
                return true;
            }

            // Must get the current tick count within this method so it is guaranteed not to be before
            // StartTime, which is set in the constructor.
            var nowMilliseconds = Environment.TickCount;
            if (IsTickBetween(StartTime, Expiration, nowMilliseconds))
            {
                //if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"TimerThreadTimer#{StartTime}::Fire() Not firing ({StartTime} <= {nowMilliseconds} < {Expiration})");
                return false;
            }

            var needCallback = false;
            lock (_queueLock)
            {
                if (_timerState == TimerState.Ready)
                {
                    //if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"TimerThreadTimer#{StartTime}::Fire() Firing ({StartTime} <= {nowMilliseconds} >= " + Expiration + ")");
                    _timerState = TimerState.Fired;

                    // Remove it from the list.
                    Next.Prev = Prev;
                    Prev.Next = Next;

                    Next = null;
                    Prev = null;
                    needCallback = _callback != null;
                }
            }

            if (needCallback)
            {
                try
                {
                    Callback callback = _callback;
                    var context = _context;
                    _callback = null;
                    _context = null;
                    callback(this, nowMilliseconds, context);
                }
                catch (Exception exception)
                {
                    if (exception.IsFatal())
                    {
                        throw;
                    }
                }
            }

            return true;
        }

    }
}
