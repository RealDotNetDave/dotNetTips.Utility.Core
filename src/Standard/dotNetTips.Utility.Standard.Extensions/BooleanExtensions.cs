// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2020
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class BooleanExtensions.
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Converts to lowercase.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns>System.String.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static string ToLowerCase(this bool value) => value ? "true" : "false";
    }
}