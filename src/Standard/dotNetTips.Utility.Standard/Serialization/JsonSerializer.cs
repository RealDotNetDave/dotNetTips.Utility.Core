// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="JsonSerializer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Serialization
{
    /// <summary>
    /// Class JsonSerializer.
    /// </summary>
    public static class JsonSerializer
    {

        /// <summary>
        /// Deserializes the specified Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        public static T Deserialize<T>(string json)
            where T : class
        {
            Encapsulation.TryValidateParam(json, nameof(json));

            var obj = TypeHelper.GetDefault<T>();

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var ser = new DataContractJsonSerializer(typeof(T));
                obj = ser.ReadObject(ms) as T;
            }

            return obj;
        }

        /// <summary>
        /// Jsons the equal.
        /// </summary>
        /// <param name="actual">The actual.</param>
        /// <param name="expected">The expected.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
        public static bool JsonEqual(string actual, string expected)
        {
            using (var expectedDom = JsonDocument.Parse(expected))
            {
                using (var actualDom = JsonDocument.Parse(actual))
                {
                    return JsonEqual(expectedDom.RootElement, actualDom.RootElement);
                }
            }
        }

        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.String.</returns>
        public static string Serialize(object obj)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));

            var json = string.Empty;

            using (var ms = new MemoryStream())
            {
                var ser = new DataContractJsonSerializer(type: obj.GetType());

                ser.WriteObject(ms, obj);
                ms.Flush();
                json = Encoding.UTF8.GetString(ms.ToArray(), index: 0, count: ms.ToArray().Length);
            }

            return json;
        }

        private static bool JsonEqual(JsonElement expected, JsonElement actual)
        {
            var valueKind = expected.ValueKind;

            if (valueKind != actual.ValueKind)
            {
                return false;
            }

            switch (valueKind)
            {
                case JsonValueKind.Object:
                    var propertyNames = new HashSet<string>();

                    foreach (var property in expected.EnumerateObject())
                    {
                        propertyNames.Add(property.Name);
                    }

                    foreach (var property in actual.EnumerateObject())
                    {
                        propertyNames.Add(property.Name);
                    }

                    foreach (var name in propertyNames)
                    {
                        if (!JsonEqual(expected.GetProperty(name), actual.GetProperty(name)))
                        {
                            return false;
                        }
                    }

                    return true;
                case JsonValueKind.Array:
                    using (var expectedEnumerator = actual.EnumerateArray())
                    {
                        using (var actualEnumerator = expected.EnumerateArray())
                        {
                            while (expectedEnumerator.MoveNext())
                            {
                                if (!actualEnumerator.MoveNext())
                                {
                                    return false;
                                }

                                if (!JsonEqual(expectedEnumerator.Current, actualEnumerator.Current))
                                {
                                    return false;
                                }
                            }

                            return !actualEnumerator.MoveNext();
                        }
                    }
                case JsonValueKind.String:
                    return expected.GetString() == actual.GetString();
                case JsonValueKind.Number:
                case JsonValueKind.True:
                case JsonValueKind.False:
                case JsonValueKind.Null:
                    return expected.GetRawText() == actual.GetRawText();
                default:
                    throw new NotSupportedException($"Unexpected JsonValueKind: JsonValueKind.{valueKind}.");
            }
        }

    }
}
