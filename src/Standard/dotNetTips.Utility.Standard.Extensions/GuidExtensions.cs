// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class GuidExtensions.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Returns the Guid without dashes.
        /// </summary>
        /// <param name="value">The Guid value.</param>
        /// <returns>System.String.</returns>
        public static string ToDigits(this Guid value)
        {
            return value.ToString("N", CultureInfo.InvariantCulture);
        }
    }
}
