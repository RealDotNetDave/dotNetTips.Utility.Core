// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-05-2020
// ***********************************************************************
// <copyright file="CancelationTimer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Represents a timer and provides a mechanism to cancel.
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public abstract class CancelationTimer : IDisposable
    {

        private readonly int _durationMilliseconds;
        private readonly int _startTimeMilliseconds;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelationTimer" /> class.
        /// </summary>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        public CancelationTimer(int durationMilliseconds)
        {
            this._durationMilliseconds = durationMilliseconds;
            this._startTimeMilliseconds = Environment.TickCount;
        }

        /// <summary>
        /// The time (relative to Environment.TickCount) when the timer will expire.
        /// </summary>
        /// <value>The expiration.</value>
        public int Expiration => unchecked(this._startTimeMilliseconds + this._durationMilliseconds);

        /// <summary>
        /// Whether or not the timer has expired.
        /// </summary>
        /// <value><c>true</c> if this instance has expired; otherwise, <c>false</c>.</value>
        public abstract bool HasExpired { get; }

        /// <summary>
        /// The time (relative to Environment.TickCount) when the timer started.
        /// </summary>
        /// <value>The start time.</value>
        public int StartTime => this._startTimeMilliseconds;

        /// <summary>
        /// Cancels the timer.  Returns true if the timer hasn't and won't fire; false if it has or will.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public abstract bool Cancel();

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.Cancel();
                }

                disposedValue = true;
            }
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
    }
}
