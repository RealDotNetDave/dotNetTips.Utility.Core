// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2017
// ***********************************************************************
// <copyright file="IntegerExtensions.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class IntegerExtensions.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Noes the duplicates.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>System.Int32().</returns>
        /// <remarks>Code by: Kevin S Gallagher</remarks>
        public static IEnumerable<int> RemoveDuplicates(this int[] values)
        {
            return values.Distinct().AsEnumerable();
        }

        /// <summary>
        /// Determines if the Integer is of the specified interval. E.g. if the interval is 100 and
        /// the integer is 400, it would return true. This function uses the Mod operator, for the
        /// above example: (300 Mod 100 = 0)
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="interval">The interval.</param>
        /// <returns><c>true</c> if the specified number is interval; otherwise, <c>false</c>.</returns>
        /// <remarks>Code by: Blake Pell</remarks>
        public static bool IsInterval(this int num, int interval)
        {
            return num % interval == 0 ? true : false;
        }

        /// <summary>
        /// Indicate whether the number falls in the specified range.
        /// </summary>
        /// <param name="theNumber">Number to process</param>
        /// <param name="lower">Lower bound</param>
        /// <param name="upper">Upper bound</param>
        /// <returns>True/False</returns>
        public static Boolean Between(this Int32 theNumber, Int32 lower, Int32 upper)
        {
            return theNumber >= lower && theNumber <= upper;
        }

        /// <summary>
        /// Indicate whether the number is even.
        /// </summary>
        /// <param name="theNumber">Number to process</param>
        /// <returns>True/False</returns>
        public static Boolean IsEven(this Int32 theNumber)
        {
            return (theNumber % 2) == 0;
        }

        /// <summary>
        /// Returns the nearest power of 2 that is bigger than the number.
        /// </summary>
        /// <param name="theNumber">Number to process</param>
        /// <returns>Integer</returns>
        public static Int32 RoundToPowerOf2(this Int32 theNumber)
        {
            var exponent = 1;
            while (true)
            {
                var powerOf2 = (UInt32)Math.Pow(2, exponent++);
                if (powerOf2 >= theNumber)
                    return (Int32)powerOf2;
            }
        }

        /// <summary>
        /// Parse the number to a string or a default string if outside given range.
        /// </summary>
        /// <param name="theNumber">Number to process</param>
        /// <param name="upto">Lower bound</param>
        /// <param name="beyond">Upper bound</param>
        /// <param name="defaultText">Default text</param>
        /// <returns>String</returns>
        public static String ToStringOrEmpty(this Int32 theNumber, Int32 upto = 0, Int32 beyond = 9000, String defaultText = "")
        {
            return theNumber <= upto || theNumber > beyond
                ? defaultText
                : theNumber.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Decrement a number ensuring it never passes a given lower-bound.
        /// </summary>
        /// <param name="number">Number to process</param>
        /// <param name="lowerBound">Lower bound</param>
        /// <param name="step">Step of the decrement</param>
        /// <returns>Integer</returns>
        public static Int32 Decrement(this Int32 number, Int32 lowerBound = 0, Int32 step = 1)
        {
            var n = number - step;
            return n < lowerBound ? lowerBound : n;
        }

        /// <summary>
        /// Increment a number ensuring it never passes a given upper-bound.
        /// </summary>
        /// <param name="number">Number to process</param>
        /// <param name="upperBound">Upper bound</param>
        /// <param name="step">Step of the increment</param>
        /// <returns>Integer</returns>
        public static Int32 Increment(this Int32 number, Int32 upperBound = 100, Int32 step = 1)
        {
            var n = number + 1;
            return n > upperBound ? upperBound : n;
        }

        /// <summary>
        /// Translate the number in words (English)
        /// </summary>
        /// <param name="number">Number to translate</param>
        /// <returns>String</returns>
        public static String ToWords(this Int32 number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + ToWords(Math.Abs(number));

            var words = string.Empty;

            if ((number / 1000000) > 0)
            {
                words += ToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += ToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != string.Empty)
                    words += "and ";

                var units = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tens = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + units[number % 10];
                }
            }

            return words;
        }
    }
}