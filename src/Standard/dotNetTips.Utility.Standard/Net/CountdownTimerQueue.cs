// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-21-2020
// ***********************************************************************
// <copyright file="CountdownTimerQueue.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard.Net
{
    using System;
    using System.Runtime.InteropServices;
    using dotNetTips.Utility.Standard.Extensions;
    using static dotNetTips.Utility.Standard.Net.CountdownTimer;

    /// <summary>
    /// Represents a queue of timers of fixed duration. Implements the <see cref="dotNetTips.Utility.Standard.Net.CountdownTimerQueue" /> Implements the <see cref="dotNetTips.Utility.Standard.Net.TimerQueue" />.
    /// </summary>
    public class CountdownTimerQueue : TimerQueue, IDisposable
    {
        /// <summary>
        /// The CountdownTimerNode...
        /// </summary>
        private readonly CountdownTimerNode _countdownTimerNode;

        /// <summary>
        /// Determines if Dispose() has been called....
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// The handle...
        /// </summary>
        private IntPtr _thisHandle;

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimerQueue"/> class.
        /// </summary>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        public CountdownTimerQueue(int durationMilliseconds) : base(durationMilliseconds)
        {
            // Create the doubly-linked list with a sentinel head and tail so that this member never needs updating.
            this._countdownTimerNode = new CountdownTimerNode();
            this._countdownTimerNode.Next = this._countdownTimerNode;
            this._countdownTimerNode.Prev = this._countdownTimerNode;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    this.DisposeFields();
                }

                _disposed = true;
            }
        }

        /// <summary>
        /// Creates new timers. This method is thread-safe.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <returns><see cref="CancellationTimer" />Timer.</returns>
        public override CancellationTimer CreateTimer(Callback callback, object context)
        {
            var timer = new CountdownTimerNode(callback, context, Duration, this._countdownTimerNode);

            // Add this on the tail.  (Actually, one before the tail - _timers is the sentinel tail.)
            var needProd = false;

            lock (this._countdownTimerNode)
            {
                // If this is the first timer in the list, we need to create a queue handle and prod the timer thread.
                if (this._countdownTimerNode.Next == this._countdownTimerNode)
                {
                    if (_thisHandle == IntPtr.Zero)
                    {
                        _thisHandle = (IntPtr)GCHandle.Alloc(this);
                    }

                    needProd = true;
                }

                timer.Next = this._countdownTimerNode;
                timer.Prev = this._countdownTimerNode.Prev;
                this._countdownTimerNode.Prev.Next = timer;
                this._countdownTimerNode.Prev = timer;
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
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Called by the timer thread to fire the expired timers.  Returns true if there are future timers in the
        /// queue, and if so, also sets nextExpiration.
        /// </summary>
        /// <param name="nextExpiration">The next expiration.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Fire(out int nextExpiration)
        {
            while (true)
            {
                // Check if we got to the end.  If so, free the handle.
                var timer = _countdownTimerNode.Next;
                if (timer == this._countdownTimerNode)
                {
                    lock (this._countdownTimerNode)
                    {
                        timer = this._countdownTimerNode.Next;
                        if (timer == _countdownTimerNode)
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
