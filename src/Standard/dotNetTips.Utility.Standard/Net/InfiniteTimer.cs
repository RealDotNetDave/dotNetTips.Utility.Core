// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="InfiniteTimer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Threading;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// A dummy infinite timer.
    /// Implements the <see cref="CancelationTimer" />
    /// </summary>
    /// <seealso cref="CancelationTimer" />
    public class InfiniteTimer : CancelationTimer
    {

        private int _cancelled;

        /// <summary>
        /// Initializes a new instance of the <see cref="InfiniteTimer"/> class.
        /// </summary>
        public InfiniteTimer() : base(Timeout.Infinite) { }

        /// <summary>
        /// Shows whether or not the timer has expired.
        /// </summary>
        /// <value><c>true</c> if this instance has expired; otherwise, <c>false</c>.</value>
        public override bool HasExpired => false;

        /// <summary>
        /// Cancels the timer.  Returns true the first time, false after that.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public override bool Cancel() => Interlocked.Exchange(ref _cancelled, 1) == 0;

    }
}
