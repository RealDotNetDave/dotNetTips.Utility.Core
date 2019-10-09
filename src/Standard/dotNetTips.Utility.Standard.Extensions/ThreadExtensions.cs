// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="ThreadExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ThreadExtensions.
    /// </summary>
    public static class ThreadExtensions
    {
        /// <summary>
        /// Waits for a certian amount of time. Does not use timer (no need to call Dispose).
        /// </summary>
        /// <param name="thread">The thread.</param>
        /// <param name="interval">The wait interval.</param>
        public static void WaitUntil(this Thread thread, TimeSpan interval)
        {
            WaitUntil(thread, interval);
        }

        /// <summary>
        /// Waits the until.
        /// </summary>
        /// <param name="thread">The thread.</param>
        /// <param name="interval">The wait interval.</param>
        /// <param name="waitInterations">The wait interations.</param>
        public static void WaitUntil(this Thread thread, TimeSpan interval, int waitInterations)
        {
            var stopAt = DateTime.Now.Add(interval);

            do
            {
                Thread.SpinWait(waitInterations);
            } while (thread.IsAlive && DateTime.Now < stopAt);
        }
    }
}