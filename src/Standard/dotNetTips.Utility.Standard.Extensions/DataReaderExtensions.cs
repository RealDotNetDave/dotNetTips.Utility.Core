// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-08-2020
// ***********************************************************************
// <copyright file="DataReaderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// DataReaderExtensions.
    /// </summary>
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Converts DataReader to CSV format.
        /// </summary>
        /// <param name="dataReader">The data reader.</param>
        /// <param name="includeHeaderAsFirstRow">if set to <c>true</c> [include header as first row].</param>
        /// <param name="separator">The separator.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
        [Information(nameof(ToCsv), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static List<string> ToCsv(this IDataReader dataReader, bool includeHeaderAsFirstRow, string separator = ",")
        {
            if (dataReader is null)
            {
                throw new ArgumentNullException(nameof(dataReader));
            }

            if (string.IsNullOrEmpty(separator))
            {
                throw new ArgumentException($"'{nameof(separator)}' cannot be null or empty", nameof(separator));
            }

            var csvRows = new List<string>();
            StringBuilder sb = null;

            if (includeHeaderAsFirstRow)
            {
                sb = new StringBuilder();

                for (int index = 0; index <= dataReader.FieldCount - 1; index++)
                {
                    if (dataReader.GetName(index) != null)
                    {
                        sb.Append(dataReader.GetName(index));
                    }

                    if (index < dataReader.FieldCount - 1)
                    {
                        sb.Append(separator);
                    }
                }

                csvRows.Add(sb.ToString());
            }

            while (dataReader.Read())
            {
                sb = new StringBuilder();

                for (int index = 0; index <= dataReader.FieldCount - 2; index++)
                {
                    if (!dataReader.IsDBNull(index))
                    {
                        string value = dataReader.GetValue(index).ToString();
                        if (dataReader.GetFieldType(index) == typeof(string))
                        {
                            // If double quotes are used in value, ensure each are replaced but 2.
                            if (value.IndexOf("\"", StringComparison.Ordinal) >= 0)
                            {
                                value = value.Replace("\"", "\"\"");
                            }

                            // If separator are is in value, ensure it is put in double quotes.
                            if (value.IndexOf(separator, StringComparison.Ordinal) >= 0)
                            {
                                value = ( Convert.ToString("\"", CultureInfo.InvariantCulture) + value ) + "\"";
                            }
                        }

                        sb.Append(value);
                    }

                    if (index < dataReader.FieldCount - 1)
                    {
                        sb.Append(separator);
                    }
                }

                if (!dataReader.IsDBNull(dataReader.FieldCount - 1))
                {
                    sb.Append(dataReader.GetValue(dataReader.FieldCount - 1).ToString().Replace(separator, " "));
                }

                csvRows.Add(sb.ToString());
            }

            return csvRows;
        }
    }
}
