// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2020
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// StringBuilder Extensions.
    /// </summary>
    public static class StringBuilderExtensions
    {

        private const string DefaultSeparator = ", ";

        /// <summary>
        /// Appends the bytes.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="bytes">The bytes.</param>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static void AppendBytes(this StringBuilder builder, byte[] bytes)
        {
            if ((bytes == null) || (bytes.Length == 0))
            {
                throw new ArgumentException($"{nameof(bytes)} is null or empty.", nameof(bytes));
            }

            builder.Append("'0x");

            for (var i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
            }

            builder.Append('\'');
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendJoin<T>(this StringBuilder stringBuilder, IEnumerable<T> values, Action<StringBuilder, T> joinAction, string separator = ", ")
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            var appended = false;

            foreach (var value in values)
            {
                joinAction(stringBuilder, value);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the t parameter.</typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendJoin<T, TParam>(this StringBuilder stringBuilder, IEnumerable<T> values, TParam param, Action<StringBuilder, T, TParam> joinAction, string separator = ", ")
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param == null)
            {
                throw new ArgumentNullException(nameof(param), $"{nameof(param)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            var appended = false;

            foreach (var value in values)
            {
                joinAction(stringBuilder, value, param);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam1">The type of the t param1.</typeparam>
        /// <typeparam name="TParam2">The type of the t param2.</typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="param1">The param1.</param>
        /// <param name="param2">The param2.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendJoin<T, TParam1, TParam2>(this StringBuilder stringBuilder, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction, string separator = ", ")
        {
            if (param1 == null)
            {
                throw new ArgumentNullException(nameof(param1), $"{nameof(param1)} is null.");
            }

            if (param2 == null)
            {
                throw new ArgumentNullException(nameof(param2), $"{nameof(param2)} is null.");
            }

            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            var appended = false;

            foreach (var value in values)
            {
                joinAction(stringBuilder, value, param1, param2);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendValues(this StringBuilder stringBuilder, string separator, IEnumerable<string> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            separator = SetSeparator(separator);

            return stringBuilder.AppendValues(separator, values, (value) => stringBuilder.Append(value));
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendValues(this StringBuilder stringBuilder, string separator, params string[] values)
        {
            if ((values == null) || (values.Length == 0))
            {
                throw new ArgumentException($"{nameof(values)} is null or empty.", nameof(values));
            }

            separator = SetSeparator(separator);

            return stringBuilder.AppendValues(separator, values, (value) => stringBuilder.Append(value));
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendValues<T>(this StringBuilder stringBuilder, string separator, IEnumerable<T> values, Action<T> joinAction)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(value);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the t parameter.</typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendValues<T, TParam>(this StringBuilder stringBuilder, string separator, IEnumerable<T> values, TParam param, Action<T, TParam> joinAction)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param == null)
            {
                throw new ArgumentNullException(nameof(param), $"{nameof(param)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(value, param);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam1">The type of the t param1.</typeparam>
        /// <typeparam name="TParam2">The type of the t param2.</typeparam>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="param1">The param1.</param>
        /// <param name="param2">The param2.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendValues<T, TParam1, TParam2>(this StringBuilder stringBuilder, string separator, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param1 == null)
            {
                throw new ArgumentNullException(nameof(param1), $"{nameof(param1)} is null.");
            }

            if (param2 == null)
            {
                throw new ArgumentNullException(nameof(param2), $"{nameof(param2)} is null.");
            }

            if (joinAction == null)
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(stringBuilder, value, param1, param2);
                stringBuilder.Append(separator);
                appended = true;
            }

            if (appended)
            {
                stringBuilder.Length -= separator.Length;
            }

            return stringBuilder;
        }

        private static string SetSeparator(string separator)
        {
            if (separator.HasValue() == false)
            {
                separator = DefaultSeparator;
            }

            return separator;
        }

    }
}
