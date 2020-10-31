// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2020
// ***********************************************************************
// <copyright file="DateTimeExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions.Properties;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Extensions for DateTime and DateTimeOffset
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
            return input.AddDays((input.DayOfWeek > dayOfWeek
                    ? input.DayOfWeek - dayOfWeek
                    : 7 - (int)dayOfWeek + (int)input.DayOfWeek) *
                -1);
        }

        /// <summary>
        /// Gets the last.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>DateTimeOffset.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 77.78, Status = Status.Available)]
        public static DateTimeOffset GetLastDayOfWeek(this DateTimeOffset input, DayOfWeek dayOfWeek)
        {
            return input.AddDays((input.DayOfWeek > dayOfWeek
                    ? input.DayOfWeek - dayOfWeek
                    : 7 - (int)dayOfWeek + (int)input.DayOfWeek) *
                -1);
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
        /// Gets the date for the given day of the week.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="dayOfWeek">The day of week.</param>
        /// <returns>DateTimeOffset.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 77.78, Status = Status.Available)]
        public static DateTimeOffset GetNextDayOfWeek(this DateTimeOffset input, DayOfWeek dayOfWeek)
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
        public static bool Intersects(this DateTime startDate,
                                      DateTime endDate,
                                      DateTime intersectingStartDate,
                                      DateTime intersectingEndDate) => intersectingEndDate >= startDate &&
            intersectingStartDate <= endDate;

        /// <summary>
        /// Intersects the specified end date.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="intersectingStartDate">The intersecting start date.</param>
        /// <param name="intersectingEndDate">The intersecting end date.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 83.33, Status = Status.Available)]
        public static bool Intersects(this DateTimeOffset startDate,
                                      DateTimeOffset endDate,
                                      DateTimeOffset intersectingStartDate,
                                      DateTimeOffset intersectingEndDate) => intersectingEndDate >= startDate &&
            intersectingStartDate <= endDate;

        /// <summary>
        /// Determines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning date.</param>
        /// <param name="endTime">The end date.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning date]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this DateTime value, DateTime beginningTime, DateTime endTime)
        { return value >= beginningTime & value <= endTime; }

        /// <summary>
        /// Determines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this TimeSpan value, TimeSpan beginningTime, TimeSpan endTime)
        { return value >= beginningTime & value <= endTime; }

        /// <summary>
        /// DDetermines whether value is in range of the specified beginning time and end time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        public static bool IsInRange(this DateTimeOffset value, DateTimeOffset beginningTime, DateTimeOffset endTime)
        { return value >= beginningTime & value <= endTime; }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
        /// invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static bool IsInRangeThrowsException(this DateTime value,
                                                    DateTime beginningTime,
                                                    DateTime endTime,
                                                    string paramName)
        {
            if(value.IsInRange(beginningTime, endTime) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
        /// invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static bool IsInRangeThrowsException(this TimeSpan value,
                                                    TimeSpan beginningTime,
                                                    TimeSpan endTime,
                                                    string paramName)
        {
            if(value.IsInRange(beginningTime, endTime) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
        /// invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="beginningTime">The beginning time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static bool IsInRangeThrowsException(this DateTimeOffset value,
                                                    DateTimeOffset beginningTime,
                                                    DateTimeOffset endTime,
                                                    string paramName)
        {
            if(value.IsInRange(beginningTime, endTime) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Given a date, it returns the next (specified) day of week
        /// </summary>
        /// <param name="date">Date to process</param>
        /// <param name="timezoneFromUtc">Hours of the timezone from UTC</param>
        /// <returns>Future date</returns>
        public static DateTime LocalTimeFromUtc(this DateTime date, int timezoneFromUtc) => date.ToUniversalTime()
            .AddHours(timezoneFromUtc);

        /// <summary>
        /// Determines the maximum of the two dates.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="compareTo">The date to compare.</param>
        /// <returns>DateTime.</returns>
        [Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 83.33, Status = Status.Available)]
        public static DateTime Max(this DateTime date, DateTime compareTo)
        { return date > compareTo ? date : compareTo; }

        /// <summary>
        /// Determines the maximum of the two dates.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="compareTo">The date to compare.</param>
        /// <returns>DateTimeOffset.</returns>
        [Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 83.33, Status = Status.Available)]
        public static DateTimeOffset Max(this DateTimeOffset date, DateTimeOffset compareTo)
        { return date > compareTo ? date : compareTo; }


        /// <summary>
        /// Given a date, it returns the next (specified) day of week
        /// </summary>
        /// <param name="date">Date to process</param>
        /// <param name="day">Day of week to find on calendar</param>
        /// <returns>Future date</returns>
        public static DateTime NextDayOfWeek(this DateTime date, DayOfWeek day = DayOfWeek.Monday)
        {
            while(true)
            {
                if(date.DayOfWeek == day)
                {
                    return date;
                }

                date = date.AddDays(1);
            }
        }

        /// <summary>
        /// Given a date, it returns the next (specified) day of week
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="day">The day.</param>
        /// <returns>DateTimeOffset.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static DateTimeOffset NextDayOfWeek(this DateTimeOffset date, DayOfWeek day = DayOfWeek.Monday)
        {
            while(true)
            {
                if(date.DayOfWeek == day)
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

            if(input.Date == DateTime.Today)
            {
                formattedDate = nameof(DateTime.Today);
            } else
            {
                formattedDate = input.Date == DateTime.Today.AddDays(-1)
                    ? Resources.Yesterday
                    : input.Date > DateTime.Today.AddDays(-6)
                        ? input.ToString("dddd", CultureInfo.CurrentCulture)
                        : input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
                                         CultureInfo.CurrentCulture);
            }

            formattedDate += $" @ {(input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture))}";

            return formattedDate;
        }

        /// <summary>
        /// Converts to friendly date string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 41.67, Status = Status.Available)]
        public static string ToFriendlyDateString(this DateTimeOffset input)
        {
            var formattedDate = string.Empty;

            if(input.Date == DateTime.Today)
            {
                formattedDate = nameof(DateTime.Today);
            } else
            {
                formattedDate = input.Date == DateTime.Today.AddDays(-1)
                    ? Resources.Yesterday
                    : input.Date > DateTime.Today.AddDays(-6)
                        ? input.ToString("dddd", CultureInfo.CurrentCulture)
                        : input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
                                         CultureInfo.CurrentCulture);
            }

            formattedDate += $" @ {(input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture))}";

            return formattedDate;
        }
    }
}
