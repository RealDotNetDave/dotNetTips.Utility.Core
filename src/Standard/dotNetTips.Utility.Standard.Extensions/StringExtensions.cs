// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-29-2020
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Computes the sha256 hash.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        public static string ComputeSha256Hash(this string data)
        {
            // Create a SHA256   
            using (var sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                var builder = new StringBuilder();

                for (var byteCount = 0; byteCount < bytes.Length; byteCount++)
                {
                    var byteItem = bytes[byteCount];
                    builder.Append(byteItem.ToString("x2", CultureInfo.InvariantCulture));
                }

                return builder.ToString();
            }
        }

        /// <summary>
        /// Concatenates the specified first message with passed in string[].
        /// </summary>
        /// <param name="firstMessage">The first message.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="addLineFeed">The add line feed. If set to true, delimiter will not be used.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">firstMessage</exception>
        public static string Concat(this string firstMessage, string delimiter, bool addLineFeed, params string[] args)
        {
            if (string.IsNullOrEmpty(firstMessage))
            {
                throw new ArgumentException($"{nameof(firstMessage)} is null or empty.", nameof(firstMessage));
            }

            if (string.IsNullOrEmpty(delimiter))
            {
                delimiter = string.Empty;
            }

            var sb = new StringBuilder(firstMessage);

            if (args.HasItems())
            {
                for (var argCount = 0; argCount < args.Length; argCount++)
                {
                    var value = args[argCount];
                    if (addLineFeed)
                    {
                        sb.AppendLine(value);
                    }
                    else
                    {
                        sb.Append(string.Concat(value, delimiter));
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Determines whether the specified the string contains any.
        /// </summary>
        /// <param name="input">The string.</param>
        /// <param name="characters">The characters.</param>
        /// <returns><c>true</c> if the specified characters contains any; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentException">input</exception>
        /// <exception cref="ArgumentNullException">input</exception>
        /// <exception cref="System.ArgumentNullException">input</exception>
        public static bool ContainsAny(this string input, params string[] characters)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} is null or empty.", nameof(input));
            }

            return characters.FastAny(character =>
            {
                return input.Contains(character);
            });
        }

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="value">The s.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string value) => value ?? string.Empty;

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="value">The s.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNull(this string value, string defaultValue) => value ?? (defaultValue ?? string.Empty);

        /// <summary>
        /// Defaults if null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue) => string.IsNullOrEmpty(value) ? defaultValue : value;

        /// <summary>
        /// Determines whether the specified input has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
        public static bool HasValue(this string input)
        {
            return input == null ? false : input.Trim().Length > 0;
        }

        /// <summary>
        /// Indents the specified length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="length">The length.</param>
        /// <param name="indentationCharacter">The indentation character.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">length - Length must be greater than 0.</exception>
        public static string Indent(this string str, int length, char indentationCharacter)
        {
            if (length == 0)
            {
                throw new ArgumentNullException(nameof(length), Resources.LengthMustBeGreaterThan0);
            }

            var sb = new StringBuilder();

            if (length < 0)
            {
                sb.Append(str);
            }

            int i;
            for (i = 1; i <= Math.Abs(length); i++)
            {
                sb.Append(indentationCharacter);
            }

            if (length > 0)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Changes the trailing ellipsis in a string to a period.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">input</exception>
        public static string ReplaceEllipsisWithPeriod(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} is null or empty.", nameof(input));
            }

            input = input.ToTrimmedString();

            if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
            {
                input = input.Substring(0, input.Length - 2);
            }

            return input;
        }

        /// <summary>
        /// Splits the specified input using ',' and removes empty entries.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public static IEnumerable<string> Split(this string input)
        {
            return input.Trim().Split(new char[] { ',' }, options: StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// To the string trimmed.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">input</exception>
        public static string ToTrimmedString(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} is null or empty.", nameof(input));
            }

            return input.Trim();
        }

    }
}