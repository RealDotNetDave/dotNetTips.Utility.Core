// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-09-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="Clock.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.Devices
{
    /// <summary>
    /// Class Clock.
    /// </summary>
    public static class Clock
    {
        /// <summary>
        /// Gets the days in the current month (local time).
        /// </summary>
        /// <value>The days in month.</value>
        public static int DaysInCurrentMonth => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

        /// <summary>
        /// Gets the days in current UTC month.
        /// </summary>
        /// <value>The days in current UTC month.</value>
        public static int DaysInCurrentUtcMonth => DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);

        /// <summary>
        /// Gets the local time.
        /// </summary>
        /// <value>The local time.</value>

        public static DateTime LocalTime => DateTime.Now.ToLocalTime();

        /// <summary>
        /// Gets the tick count.
        /// </summary>
        /// <value>The tick count.</value>
        public static int TickCount => Environment.TickCount;

        /// <summary>
        /// Gets the UTC time.
        /// </summary>
        /// <value>The UTC time.</value>
        public static DateTime UtcTime => DateTime.UtcNow;
    }
}
