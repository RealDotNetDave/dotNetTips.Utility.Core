// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2020
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using dotNetTips.Utility.Standard.Extensions.Properties;

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
                return bytes.BytesToString();
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

        /// Defaults if null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }

        /// <summary>
        /// Equals the ignore case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>NEW</remarks>
        public static bool EqualsIgnoreCase(this string input, string valueToCompare)
        {
            return string.Equals(input, valueToCompare, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Equals the or both null or empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>NEW</remarks>
        public static bool EqualsOrBothNullOrEmpty(this string input, string valueToCompare)
        {
            return string.Equals(input ?? string.Empty, valueToCompare ?? string.Empty, StringComparison.Ordinal);
        }

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
        /// Determines whether the specified length has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="length">Checks for specific length of the string.</param>
        /// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Minimum length must be larger than 0.</exception>
        public static bool HasValue(this string input, int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum length must be larger than 0.");
            }

            return input == null ? false : input.Trim().Length == length;
        }

        /// <summary>
        /// Determines whether the specified value has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="value">Checks for a specific value.</param>
        /// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
        public static bool HasValue(this string input, string value)
        {
            return input == null ? false : input.Trim() == value.Trim();
        }

        /// <summary>
        /// Determines whether the specified expression has value based on a regular expression.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="options">The options.</param>
        /// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
        public static bool HasValue(this string input, string expression, RegexOptions options)
        {
            if (input.HasValue() && expression.HasValue())
            {
                return new Regex(expression, options).IsMatch(input);
            }

            return false;
        }

        /// <summary>
        /// Determines whether the strings is within the specified minimum and maximum length.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="minLength">The minimum length.</param>
        /// <param name="maxLength">The maximum length.</param>
        /// <returns><c>true</c> if the specified minimum length has value; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Minimum length must be larger than 0.</exception>
        public static bool HasValue(this string input, int minLength, int maxLength)
        {
            if (minLength < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum length must be larger than 0.");
            }

            return input == null ? false : input.Length.IsInRange(minLength, maxLength);
        }

        /// <summary>
        /// Indents the specified length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="length">The length.</param>
        /// <param name="indentationCharacter">The indentation character.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">str</exception>
        /// <exception cref="ArgumentNullException">length - Length must be greater than 0.</exception>
        public static string Indent(this string str, int length, char indentationCharacter)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException($"{nameof(str)} is null or empty.", nameof(str));
            }

            if (length == 0)
            {
                throw new ArgumentNullException(nameof(length), Resources.LengthMustBeGreaterThan0);
            }

            var sb = new StringBuilder();

            if (length < 0)
            {
                sb.Append(str);
            }

            for (var charCount = 1; charCount <= Math.Abs(length); charCount++)
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
        /// Determines whether [is credit card] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is credit card] [the specified input]; otherwise, <c>false</c>.</returns>
        public static bool IsCreditCard(this string input)
        {

            return input.HasValue(Properties.Resources.RegexCreditCard, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether [is domain address] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is domain address] [the specified input]; otherwise, <c>false</c>.</returns>
        public static bool IsDomainAddress(this string input)
        {
            return input.HasValue(Properties.Resources.RegexDomain, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether [is email address] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is email address] [the specified input]; otherwise, <c>false</c>.</returns>
        public static bool IsEmailAddress(this string input)
        {
            return input.HasValue(Properties.Resources.RegexEmail, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether [is first and last name] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is first last name] [the specified input]; otherwise, <c>false</c>.</returns>
        public static bool IsFirstLastName(this string input)
        {
            return input.HasValue(Properties.Resources.RegexFirstLastName, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is an ISBN.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is isbn; otherwise, <c>false</c>.</returns>
        public static bool IsISBN(this string input)
        {
            return input.HasValue(Properties.Resources.RegexISBN, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether the specified input is scientific value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is scientific; otherwise, <c>false</c>.</returns>
        public static bool IsScientific(this string input)
        {
            return input.HasValue(Properties.Resources.RegexScientific, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether the specified input is a valid string value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is string; otherwise, <c>false</c>.</returns>
        public static bool IsString(this string input)
        {
            return input.HasValue(Properties.Resources.RegexString, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is an URL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
        public static bool IsUrl(this string input)
        {
            return input.HasValue(Properties.Resources.RegexUrl, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether [is web safe] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is web safe] [the specified input]; otherwise, <c>false</c>.</returns>
        public static bool IsWebSafe(this string input)
        {
            return input.HasValue(Properties.Resources.RegexStringWebSafe, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is whitespace.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is whitespace; otherwise, <c>false</c>.</returns>
        /// <remarks>NEW: From .NET Core source.</remarks>
        public static bool IsWhitespace(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!IsWhitespace(input[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified character is whitespace.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns><c>true</c> if the specified character is whitespace; otherwise, <c>false</c>.</returns>
        /// <remarks>NEW: From .NET Core source.</remarks>
        public static bool IsWhitespace(this char character)
        {
            return (character <= ' ' && (character == ' ' || character == '\t' || character == '\r' || character == '\n'));
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
        /// <exception cref="ArgumentException">input</exception>
        public static IEnumerable<string> Split(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} is null or empty.", nameof(input));
            }

            return input.Trim().Split(new char[] { ',' }, options: StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        /// <remarks>NEW</remarks>
        public static string[] Split(this string value, char separator, StringSplitOptions options = StringSplitOptions.None) => value.Split(new[] { separator }, options);

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        /// <remarks>NEW</remarks>
        public static string[] Split(this string value, string separator, StringSplitOptions options = StringSplitOptions.None) => value.Split(new[] { separator }, options);

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="count">The count.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        /// <remarks>NEW</remarks>
        public static string[] Split(this string value, char separator, int count, StringSplitOptions options = StringSplitOptions.None) => value.Split(new[] { separator }, count, options);

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="count">The count.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        public static string[] Split(this string value, string separator, int count, StringSplitOptions options = StringSplitOptions.None) => value.Split(new[] { separator }, count, options);

        /// <summary>
        /// Starts the with ordinal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>NEW</remarks>
        public static bool StartsWithOrdinal(this string input, string valueToCompare)
        {
            if (valueToCompare == null)
            {
                return false;
            }

            return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.Ordinal);
        }

        /// <summary>
        /// Starts the with ordinal ignore case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>NEW</remarks>
        public static bool StartsWithOrdinalIgnoreCase(this string input, string valueToCompare)
        {
            if (valueToCompare == null)
            {
                return false;
            }

            return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Substrings the trim.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        /// <remarks>NEW: CODE FROM .NET CORE SOURCE</remarks>
        public static string SubstringTrim(this string value, int startIndex, int length)
        {
            Debug.Assert(value != null, "string must be non-null");
            Debug.Assert(startIndex >= 0, "startIndex must be non-negative");
            Debug.Assert(length >= 0, "length must be non-negative");
            Debug.Assert(startIndex <= value.Length - length, "startIndex + length must be <= value.Length");

            if (length == 0)
            {
                return string.Empty;
            }

            int endIndex = startIndex + length - 1;

            while (startIndex <= endIndex && char.IsWhiteSpace(value[startIndex]))
            {
                startIndex++;
            }

            while (endIndex >= startIndex && char.IsWhiteSpace(value[endIndex]))
            {
                endIndex--;
            }

            int newLength = endIndex - startIndex + 1;
            Debug.Assert(newLength >= 0 && newLength <= value.Length, "Expected resulting length to be within value's length");

            return
                newLength == 0 ? string.Empty :
                newLength == value.Length ? value :
                value.Substring(startIndex, newLength);
        }

        /// <summary>
        /// Trims a string.
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