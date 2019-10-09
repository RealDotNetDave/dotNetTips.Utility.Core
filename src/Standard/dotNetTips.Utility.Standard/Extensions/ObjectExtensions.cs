// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2017
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ************************************************************************

using dotNetTips.Utility.Standard.OOP;
using dotNetTips.Utility.Standard.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ObjectExtensions.
    /// </summary>
    public static class ObjectExtensions
    {
        #region Public Methods

        /// <summary>
        /// Returns the specified value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">value - Value cannot be null.</exception>
        /// <remarks>Original code by: Shimmy Weitzhandler</remarks>
        public static T As<T>(this object value)
        {
            return (T)value;
        }

        /// <summary>
        /// Ins the specified source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="list">The list.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">source - Source cannot be null.
        /// or
        /// list - List cannot be null or have a 0 length.</exception>
        /// <remarks>Original code by: Rory Becker</remarks>
        public static bool In<T>(this T source, params T[] list)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source cannot be null.");
            }

            if (list == null || list.Length == 0)
            {
                throw new ArgumentNullException(nameof(list), "List cannot be null or have a 0 length.");
            }

            foreach (T value in list)
            {
                if (value.Equals(source))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is not null] [the specified object].
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns><count>true</count> if [is not null] [the specified object]; otherwise, <count>false</count>.</returns>
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }

        /// <summary>
        /// Determines whether the specified object is null.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><count>true</count> if the specified object is null; otherwise, <count>false</count>.</returns>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        /// <summary>
        /// Tries to Dispose the object.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="throwException">if set to <count>true</count> [throw exception].</param>
        public static void TryDispose(this IDisposable obj, bool throwException)
        {
            try
            {
                if (IsNotNull(obj))
                {
                    obj.Dispose();
                }
            }
            catch
            {
                if (throwException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Tries the to call Dispose.
        /// </summary>
        /// <param name="obj">The obj.</param>
        public static void TryDispose(this IDisposable obj)
        {
            ObjectExtensions.TryDispose(obj, false);
        }

        /// <summary>
        /// Determines whether the specified object has the property.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns><c>true</c> if the specified property name has property; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">propertyName - Source cannot be null.</exception>
        public static bool HasProperty(this object instance, string propertyName)
        {
            Encapsulation.TryValidateParam(propertyName);

            var propertyInfo = instance.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == propertyName);

            return (propertyInfo != null);
        }

        /// <summary>
        /// Serializes object to Json.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>System.String.</returns>
        public static string ToJson(this object instance)
        {
            return JsonSerializer.Serialize(instance);
        }

        /// <summary>
        /// Saves object to Json file.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="file">The file.</param>
        public static void ToJsonFile(this object instance, string file)
        {
            var json = JsonSerializer.Serialize(instance);

            File.WriteAllText(file, json, Encoding.UTF8);
        }

        /// <summary>
        /// Creates object from Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        public static T FromJson<T>(this string json) where T : class
        {
            return JsonSerializer.Deserialize<T>(json);
        }

        /// <summary>
        /// Creates object from a Json file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="file">The file.</param>
        /// <returns>T.</returns>
        /// <exception cref="FileNotFoundException">File not found.</exception>
        public static T FromJsonFile<T>(string file, object instance) where T : class
        {
            Encapsulation.TryValidateParam(file);

            if (File.Exists(file) == false)
            {
                throw new FileNotFoundException("File not found.", file);
            }

            var json = File.ReadAllText(file, Encoding.UTF8);

            return JsonSerializer.Deserialize<T>(json);
        }

        #endregion Public Methods
    }
}