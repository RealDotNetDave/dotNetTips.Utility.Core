// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2017
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    public static class StringExtensions
    {
        #region Public Methods

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string s) => s ?? string.Empty;

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string s, string defaultValue) => s ?? (defaultValue ?? string.Empty);

        /// <summary>
        /// Defaults if null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue) => string.IsNullOrEmpty(value) ? value : defaultValue;

        /// <summary>
        /// Formats the size of the file.
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">fileSize - File size is invalid.</exception>
        public static string FormatFileSize(this long fileSize)
        {
            if (fileSize == 0 && (fileSize >= long.MinValue && fileSize <= long.MaxValue))
            {
                throw new ArgumentNullException(nameof(fileSize), "File size is invalid.");
            }

            long size = 0;

            while (fileSize > 1024 && size < 4)
            {
                fileSize = Convert.ToInt64(fileSize / 1024);
                size += 1;
            }

            return fileSize + ControlChars.Space + (new string[] { Properties.Resources.Bytes, Properties.Resources.KB, Properties.Resources.MB, Properties.Resources.GB })[Convert.ToInt32(size)];
        }

        /// <summary>
        /// Indents the specified length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="length">The length.</param>
        /// <param name="indentationCharacter">The indentation character.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">length - Length must be greater than 0.</exception>
        public static string Indent(this string str, int length, char indentationCharacter = ControlChars.Space)
        {
            if (length==0)
            {
                throw new ArgumentNullException(nameof(length), "Length must be greater than 0.");
            }

            var sb = new StringBuilder();

            //An indentation length smaller then 0 changes this function from an indent function to an append function.
            //For that the final string has to start of with the initial str.
            if (length < 0) sb.Append(str);

            int i;
            //Append the indentation string
            for (i = 1; i <= Math.Abs(length); i++)
            {
                sb.Append(indentationCharacter);
            }

            //If the indentation length was greater then 0 the string gets added now.
            if (length > 0) sb.Append(str);

            return sb.ToString();
        }

        #endregion Public Methods
    }
}