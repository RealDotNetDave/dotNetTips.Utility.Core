// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="TimerQueue.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using static dotNetTips.Utility.Standard.Net.CountdownTimer;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Represents a queue of timers, which all have the same duration.
    /// </summary>
    public abstract class TimerQueue
    {
        private readonly int _durationMilliseconds;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerQueue"/> class.
        /// </summary>
        /// <param name="durationMilliseconds">The duration milliseconds.</param>
        public TimerQueue(int durationMilliseconds) { this._durationMilliseconds = durationMilliseconds; }

        /// <summary>
        /// The duration in milliseconds of timers in this queue.
        /// </summary>
        /// <value>The duration.</value>
        public int Duration => this._durationMilliseconds;

        /// <summary>
        /// Creates and returns a handle to a new timer with attached context.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <returns>CountdownTimerTimer.</returns>
        public abstract CancellationTimer CreateTimer(Callback callback, object context);
    }
}
