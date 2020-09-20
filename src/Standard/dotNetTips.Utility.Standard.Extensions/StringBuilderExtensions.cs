// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-10-2020
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
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// StringBuilder Extensions.
    /// </summary>
    [Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
    public static class StringBuilderExtensions
    {

        private const string DefaultSeparator = ", ";

        private static readonly char[] _specialCharacters = new[] { '"', '\\' };

        private static string SetSeparator(string separator)
        {
            if (separator.HasValue() == false)
            {
                separator = DefaultSeparator;
            }

            return separator;
        }

        /// <summary>
        /// Appends the bytes.
        /// </summary>
        /// <param name="sb">The builder.</param>
        /// <param name="bytes">The bytes.</param>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentException">bytes</exception>
        [Information("Orginal code from efcore-master on GitHub", author: "David McCarter", createdOn: "5/26/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 80, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static void AppendBytes(this StringBuilder sb, byte[] bytes)
        {
            if (sb == null)
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if ((bytes == null) || (bytes.Length == 0))
            {
                throw new ArgumentException($"{nameof(bytes)} is null or empty.", nameof(bytes));
            }

            sb.Append("'0x");

            for (var i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
            }

            sb.Append('\'');
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        [Information("Orginal code from efcore-master on GitHub", author: "David McCarter", createdOn: "5/26/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static StringBuilder AppendJoin<T>(this StringBuilder sb, IEnumerable<T> values, Action<StringBuilder, T> joinAction, string separator = ", ")
        {
            if (sb == null)
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
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
                joinAction(sb, value);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the t parameter.</typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param</exception>
        [Information("Orginal code from efcore-master on GitHub", author: "David McCarter", createdOn: "5/26/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static StringBuilder AppendJoin<T, TParam>(this StringBuilder sb, IEnumerable<T> values, TParam param, Action<StringBuilder, T, TParam> joinAction, string separator = ", ")
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.IsNull())
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param.IsNull())
            {
                throw new ArgumentNullException(nameof(param), $"{nameof(param)} is null.");
            }

            if (joinAction.IsNull())
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            var appended = false;

            foreach (var value in values)
            {
                joinAction(sb, value, param);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }

        /// <summary>
        /// Appends the values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam1">The type of the t param1.</typeparam>
        /// <typeparam name="TParam2">The type of the t param2.</typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="values">The values.</param>
        /// <param name="param1">The param1.</param>
        /// <param name="param2">The param2.</param>
        /// <param name="joinAction">The join action.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">param1</exception>
        /// <exception cref="ArgumentNullException">param2</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">param1</exception>
        /// <exception cref="ArgumentNullException">param2</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        [Information("Orginal code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static StringBuilder AppendJoin<T, TParam1, TParam2>(this StringBuilder sb, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction, string separator = ", ")
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (param1.IsNull())
            {
                throw new ArgumentNullException(nameof(param1), $"{nameof(param1)} is null.");
            }

            if (param2.IsNull())
            {
                throw new ArgumentNullException(nameof(param2), $"{nameof(param2)} is null.");
            }

            if (values.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (joinAction.IsNull())
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            var appended = false;

            foreach (var value in values)
            {
                joinAction(sb, value, param1, param2);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }

        /// <summary>
        /// Appends the key value.
        /// </summary>
        /// <param name="sb">The sb.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="includeQuotes">if set to <c>true</c> [include quotes].</param>
        /// <param name="includeComma">if set to <c>true</c> [include comma].</param>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentException">key</exception>
        /// <exception cref="ArgumentException">value</exception>
        /// <exception cref="ArgumentException">sb</exception>
        [Information("FROM .NET CORE SOURCE", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 65, Status = Status.Available)]
        public static void AppendKeyValue(this StringBuilder sb, string key, string value, bool includeQuotes = true, bool includeComma = true)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException($"{nameof(key)} is null or empty.", nameof(key));
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(value)} is null or empty.", nameof(value));
            }

            sb.Append(key);
            sb.Append('=');

            if (includeQuotes)
            {
                sb.Append('"');
                int lastSpecialIndex = 0;
                int specialIndex;

                while (true)
                {
                    specialIndex = value.IndexOfAny(_specialCharacters, lastSpecialIndex);

                    if (specialIndex >= 0)
                    {
                        sb.Append(value, lastSpecialIndex, specialIndex - lastSpecialIndex);
                        sb.Append('\\');
                        sb.Append(value[specialIndex]);
                        lastSpecialIndex = specialIndex + 1;
                    }
                    else
                    {
                        sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
                        break;
                    }
                }
                sb.Append('"');
            }
            else
            {
                sb.Append(value);
            }

            if (includeComma)
            {
                sb.Append(',');
                sb.Append(' ');
            }
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="sb">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        [Information("Orginal code from efcore-master on GitHub.", author: "David McCarter", createdOn: "7/1/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 75, Status = Status.Available)]
        public static StringBuilder AppendValues(this StringBuilder sb, string separator, IEnumerable<string> values)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            separator = SetSeparator(separator);

            return sb.AppendValues(separator, values, (value) => sb.Append(value));
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <param name="sb">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentException">values</exception>
        [Information("Orginal code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static StringBuilder AppendValues(this StringBuilder sb, string separator, params string[] values)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.HasItems() == false)
            {
                throw new ArgumentException($"{nameof(values)} is null or empty.", nameof(values));
            }

            separator = SetSeparator(separator);

            return sb.AppendValues(separator, values, (value) => sb.Append(value));
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        [Information("Orginal code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 82, Status = Status.Available)]
        public static StringBuilder AppendValues<T>(this StringBuilder sb, string separator, IEnumerable<T> values, Action<T> joinAction)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (joinAction.IsNull())
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(value);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam">The type of the t parameter.</typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param</exception>
        [Information("Orginal code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static StringBuilder AppendValues<T, TParam>(this StringBuilder sb, string separator, IEnumerable<T> values, TParam param, Action<T, TParam> joinAction)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param.IsNull())
            {
                throw new ArgumentNullException(nameof(param), $"{nameof(param)} is null.");
            }

            if (joinAction.IsNull())
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(value, param);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }

        /// <summary>
        /// Appends the join.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TParam1">The type of the t param1.</typeparam>
        /// <typeparam name="TParam2">The type of the t param2.</typeparam>
        /// <param name="sb">The string builder.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="values">The values.</param>
        /// <param name="param1">The param1.</param>
        /// <param name="param2">The param2.</param>
        /// <param name="joinAction">The join action.</param>
        /// <returns>StringBuilder.</returns>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param1</exception>
        /// <exception cref="ArgumentNullException">param2</exception>
        /// <exception cref="ArgumentNullException">joinAction</exception>
        /// <exception cref="ArgumentNullException">sb</exception>
        /// <exception cref="ArgumentNullException">values</exception>
        /// <exception cref="ArgumentNullException">param1</exception>
        /// <exception cref="ArgumentNullException">param2</exception>
        [Information("Orginal code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static StringBuilder AppendValues<T, TParam1, TParam2>(this StringBuilder sb, string separator, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction)
        {
            if (sb.IsNull())
            {
                throw new ArgumentNullException(nameof(sb), $"{nameof(sb)} is null.");
            }

            if (values.DoesNotHaveItems())
            {
                throw new ArgumentNullException(nameof(values), $"{nameof(values)} is null.");
            }

            if (param1.IsNull())
            {
                throw new ArgumentNullException(nameof(param1), $"{nameof(param1)} is null.");
            }

            if (param2.IsNull())
            {
                throw new ArgumentNullException(nameof(param2), $"{nameof(param2)} is null.");
            }

            if (joinAction.IsNull())
            {
                throw new ArgumentNullException(nameof(joinAction), $"{nameof(joinAction)} is null.");
            }

            separator = SetSeparator(separator);

            var appended = false;

            foreach (var value in values)
            {
                joinAction(sb, value, param1, param2);
                sb.Append(separator);
                appended = true;
            }

            if (appended)
            {
                sb.Length -= separator.Length;
            }

            return sb;
        }
    }
}
