// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-11-2020
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
    /// Class StringBuilderExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for StringBuilderExtensions
    public static class StringBuilderExtensions
    {

        /// <summary>
        /// Appends the bytes.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="bytes">The bytes.</param>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static void AppendBytes(this StringBuilder builder, byte[] bytes)
        {
            builder.Append("'0x");

            for (var i = 0; i < bytes.Length; i++)
            {
                if (i > 31)
                {
                    builder.Append("...");
                    break;
                }

                builder.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
            }

            builder.Append('\'');
        }
        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendJoin(this StringBuilder stringBuilder, IEnumerable<string> values, string separator = ", ") => stringBuilder.AppendJoin(values, (sb, value) => sb.Append(value), separator);

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="stringBuilder">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <returns>StringBuilder.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static StringBuilder AppendJoin(this StringBuilder stringBuilder, string separator, params string[] values) => stringBuilder.AppendJoin(values, (sb, value) => sb.Append(value), separator);

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

    }
}
