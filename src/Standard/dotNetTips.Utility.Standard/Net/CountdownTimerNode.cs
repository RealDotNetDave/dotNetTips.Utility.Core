// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-19-2020
// ***********************************************************************
// <copyright file="CountdownTimerNode.cs" company="David McCarter - dotNetTips.com">
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
    /// Class CountdownTimerNode.
    /// Implements the <see cref="dotNetTips.Utility.Standard.Net.CancellationTimer" />.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Net.CancellationTimer" />
    internal class CountdownTimerNode : CancellationTimer
    {
        /// <summary>
        /// The queue lock.
        /// </summary>
        private readonly object _queueLock;

        /// <summary>
        /// The callback.
        /// </summary>
        private Callback _callback;

        /// <summary>
        /// The context.
        /// </summary>
        private object _context;

        /// <summary>
        /// The next.
        /// </summary>
        private CountdownTimerNode _next;

        /// <summary>
        /// The previous.
        /// </summary>
        private CountdownTimerNode _prev;

        /// <summary>
        /// The timer state.
        /// </summary>
        private TimerState _timerState;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimerNode" /> class. A sentinel node - both the head
        /// and tail are one, which prevent  the head and tail from ever having to be updated.
        /// </summary>
        public CountdownTimerNode() : base(0) { this._timerState = TimerState.Sentinel; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimerNode" /> class.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        /// <param name="queueLock">The queue lock.</param>
        public CountdownTimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) : base(durationMilliseconds)
        {
            if (callback != null)
            {
                this._callback = callback;
                this._context = context;
            }

            this._timerState = TimerState.Ready;
            this._queueLock = queueLock;
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
            /// Timer is canceled
            /// </summary>
            Canceled,

            /// <summary>
            /// Timer sentinel
            /// </summary>
            Sentinel,
        }

        /// <summary>
        /// Gets whether or not the timer has expired.
        /// </summary>
        /// <value><c>true</c> if this instance has expired; otherwise, <c>false</c>.</value>
        public override bool HasExpired => this._timerState == TimerState.Fired;

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>The next.</value>
        public CountdownTimerNode Next { get => this._next; set => this._next = value; }

        /// <summary>
        /// Gets or sets the previous.
        /// </summary>
        /// <value>The previous.</value>
        public CountdownTimerNode Prev { get => this._prev; set => this._prev = value; }

        /// <summary>
        /// Cancels the timer.  Returns true if it hasn't and won't fire; false if it has or will, or has already been
        /// canceled.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public override bool Cancel()
        {
            if (this._timerState == TimerState.Ready)
            {
                lock (this._queueLock)
                {
                    if (this._timerState == TimerState.Ready)
                    {
                        // Remove it from the list.  This keeps the list from getting too big when there are a lot of rapid creations
                        // and cancellations.  This is done before setting it to Canceled to try to prevent the Fire() loop from
                        // seeing it, or if it does, of having to take a lock to synchronize with the state of the list.
                        Next.Prev = this.Prev;
                        Prev.Next = this.Next;

                        // Just cleanup.  Doesn't need to be in the lock but is easier to have here.
                        this.Next = null;
                        this.Prev = null;
                        this._callback = null;
                        this._context = null;

                        this._timerState = TimerState.Canceled;

                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Fires the timer if it is still active and has expired.  Returns true if it can be deleted, or false if it is
        /// still timing.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Fire()
        {
            // if (_timerState == TimerState.Sentinel)
            // {
            //    if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, "TimerQueue tried to Fire a Sentinel.");
            // }

            if (this._timerState != TimerState.Ready)
            {
                return true;
            }

            // Must get the current tick count within this method so it is guaranteed not to be before
            // StartTime, which is set in the constructor.
            var nowMilliseconds = Environment.TickCount;
            if (IsTickBetween(this.StartTime, this.Expiration, nowMilliseconds))
            {
                // if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"TimerThreadTimer#{StartTime}::Fire() Not firing ({StartTime} <= {nowMilliseconds} < {Expiration})");
                return false;
            }

            var needCallback = false;
            lock (this._queueLock)
            {
                if (this._timerState == TimerState.Ready)
                {
                    // if (NetEventSource.Log.IsEnabled()) NetEventSource.Info(this, $"TimerThreadTimer#{StartTime}::Fire() Firing ({StartTime} <= {nowMilliseconds} >= " + Expiration + ")");
                    this._timerState = TimerState.Fired;

                    // Remove it from the list.
                    Next.Prev = this.Prev;
                    Prev.Next = this.Next;

                    this.Next = null;
                    this.Prev = null;
                    needCallback = this._callback != null;
                }
            }

            if (needCallback)
            {
                try
                {
                    Callback callback = this._callback;
                    var context = this._context;
                    this._callback = null;
                    this._context = null;
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
