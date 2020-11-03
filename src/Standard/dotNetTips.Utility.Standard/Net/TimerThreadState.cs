// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-24-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-24-2020
// ***********************************************************************
// <copyright file="TimerThreadState.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// The possible states of the timer thread.
    /// </summary>
    internal enum TimerThreadState
    {
        /// <summary>
        /// Timer is idle
        /// </summary>
        Idle,

        /// <summary>
        /// Timer is running
        /// </summary>
        Running,

        /// <summary>
        /// Timer has stopped
        /// </summary>
        Stopped
    }
}
