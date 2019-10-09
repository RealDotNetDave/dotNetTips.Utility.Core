// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="DateTimeExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using dotNetTips.Utility.Standard.Extensions.Properties;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Extensions for DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets the last.
        /// </summary>
        /// <param name="input">The date/ time.</param>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>DateTime.</returns>
        /// <exception cref="ArgumentNullException">input - Input is invalid.</exception>
        public static DateTime GetLast(this DateTime input, DayOfWeek dayOfWeek)
        {
            var daysToSubtract = input.DayOfWeek > dayOfWeek
                ? input.DayOfWeek - dayOfWeek
                : (7 - (int)dayOfWeek) + (int)input.DayOfWeek;
            return input.AddDays(daysToSubtract * -1);
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
            var daysToAdd = 0;

            daysToAdd = input.DayOfWeek < dayOfWeek
                ? dayOfWeek - input.DayOfWeek
                : (7 - (int)input.DayOfWeek) + (int)dayOfWeek;

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
        public static bool Intersects(this DateTime startDate, DateTime endDate, DateTime intersectingStartDate, DateTime intersectingEndDate) => intersectingEndDate >= startDate &&
            intersectingStartDate <= endDate;

        /// <summary>
        /// Given a date, it returns the next (specified) day of week
        /// </summary>
        /// <param name="date">Date to process</param>
        /// <param name="timezoneFromUtc">Hours of the timezone from UTC</param>
        /// <returns>Future date</returns>
        public static DateTime LocalTimeFromUtc(this DateTime date, int timezoneFromUtc) => date.ToUniversalTime().AddHours(timezoneFromUtc);

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
                {
                    return date;
                }

                date = date.AddDays(1);
            }
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
            {
                formattedDate = nameof(DateTime.Today);
            }
            else
            {
                formattedDate = input.Date == DateTime.Today.AddDays(-1)
                    ? Resources.Yesterday
                    : input.Date > DateTime.Today.AddDays(-6)
                        ? input.ToString("dddd", CultureInfo.CurrentCulture)
                        : input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern, CultureInfo.CurrentCulture);
            }

            formattedDate += $" @ {(input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture))}";

            return formattedDate;
        }

        /// <summary>
        /// Determines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning date.</param>
        /// <param name="endTime">The end date.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning date]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this DateTime value, DateTime beginningTime, DateTime endTime)
        {
            return value >= beginningTime & value <= endTime;
        }

        /// <summary>
        /// Determines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this TimeSpan value, TimeSpan beginningTime, TimeSpan endTime)
        {
            return value >= beginningTime & value <= endTime;
        }

        /// <summary>
        /// DDetermines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this DateTimeOffset value, DateTimeOffset beginningTime, DateTimeOffset endTime)
        {
            return value >= beginningTime & value <= endTime;
        }
    }
}