// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2017
// ***********************************************************************
// <copyright file="DateTimeExtensions.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Globalization;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Extensions for DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        #region Public Methods

        /// <summary>
        /// Gets the last.
        /// </summary>
        /// <param name="input">The date/ time.</param>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>DateTime.</returns>
        /// <exception cref="ArgumentNullException">input - Input is invalid.</exception>
        public static DateTime GetLast(this DateTime input, DayOfWeek dayOfWeek)
        {
            Encapsulation.TryValidateParam(dayOfWeek, nameof(dayOfWeek));

            var daysToSubtract = input.DayOfWeek > dayOfWeek ? input.DayOfWeek - dayOfWeek : (7 - (int)dayOfWeek) + (int)input.DayOfWeek;
            return input.AddDays(daysToSubtract * -1);
        }

        /// <summary>
        /// Given a date, it returns the next (specified) day of week 
        /// </summary>
        /// <param name="date">Date to process</param>
        /// <param name="day">Day of week to find on calendar</param>
        /// <returns>Future date</returns>
        public static DateTime NextDayOfWeek(this DateTime date, DayOfWeek day = DayOfWeek.Monday)
        {
            while (true)
            {
                if (date.DayOfWeek == day)
                    return date;
                date = date.AddDays(1);
            }
        }

        /// <summary>
        /// Given a date, it returns the next (specified) day of week
        /// </summary>
        /// <param name="date">Date to process</param>
        /// <param name="timezoneFromUtc">Hours of the timezone from UTC</param>
        /// <returns>Future date</returns>
        public static DateTime LocalTimeFromUtc(this DateTime date, Int32 timezoneFromUtc)
        {
            return date.ToUniversalTime().AddHours(timezoneFromUtc);
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <param name="input">The date/ time.</param>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>DateTime.</returns>
        /// <exception cref="ArgumentNullException">input - Input is invalid.</exception>
        public static DateTime GetNext(this DateTime input, DayOfWeek dayOfWeek)
        {
            Encapsulation.TryValidateParam(dayOfWeek, nameof(dayOfWeek));

            var daysToAdd = 0;

            daysToAdd = input.DayOfWeek < dayOfWeek ? dayOfWeek - input.DayOfWeek : (7 - (int)input.DayOfWeek) + (int)dayOfWeek;

            return input.AddDays(daysToAdd);
        }

        /// <summary>
        /// Intersects the specified start date.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="intersectingStartDate">The intersecting start date.</param>
        /// <param name="intersectingEndDate">The intersecting end date.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>Code by: Walter Quesada</remarks>
        public static bool Intersects(this DateTime startDate, DateTime endDate, DateTime intersectingStartDate, DateTime intersectingEndDate)
        {
            return intersectingEndDate >= startDate && intersectingStartDate <= endDate;
        }

        /// <summary>
        /// To the friendly date string.
        /// </summary>
        /// <param name="input">The date.</param>
        /// <returns>System.String.</returns>
        public static string ToFriendlyDateString(this DateTime input)
        {
            var formattedDate = string.Empty;

            if (input.Date == DateTime.Today)
                formattedDate = nameof(DateTime.Today);
            else
                formattedDate = input.Date == DateTime.Today.AddDays(-1) ? Properties.Resources.Yesterday : input.Date > DateTime.Today.AddDays(-6) ? input.ToString("dddd", CultureInfo.CurrentCulture).ToString() : input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern, CultureInfo.CurrentCulture);

            // append the time portion to the output
            formattedDate += " @ " + input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower();

            return formattedDate;
        }

        #endregion Public Methods
    }
}