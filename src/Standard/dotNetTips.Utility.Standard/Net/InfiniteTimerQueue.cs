// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2020
// ***********************************************************************
// <copyright file="InfiniteTimerQueue.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Threading;
using static dotNetTips.Utility.Standard.Net.CountdownTimer;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// A special dummy implementation for a queue of timers of infinite duration. Implements the <see
    /// cref="dotNetTips.Utility.Standard.Net.CountdownTimerQueue"/>
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Net.CountdownTimerQueue"/>
    public class InfiniteTimerQueue : CountdownTimerQueue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfiniteTimerQueue"/> class.
        /// </summary>
        public InfiniteTimerQueue() : base(Timeout.Infinite)
        {
        }

        /// <summary>
        /// Always returns a dummy infinite timer.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <param name="context">The context.</param>
        /// <returns><see cref="CancellationTimer"/>Timer</returns>
        public override CancellationTimer CreateTimer(Callback callback, object context) => new InfiniteTimer();
    }
}
