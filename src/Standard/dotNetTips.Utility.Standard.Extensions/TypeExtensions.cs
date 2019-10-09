// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2019
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using System.Reflection;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class TypeExtensions.
    /// </summary>
    public static class TypeExtensions
    {

        /// <summary>
        /// Gets the field hash.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="callback">The callback.</param>
        /// <returns>System.String.</returns>
        public static string GetFieldHash<T>(this Func<T> callback)
        {
            return new string(callback.Target.GetType().GetFields().Where(x => x.MemberType == MemberTypes.Field).Select(x => x.GetValue(callback.Target)).Where(x => x != null).SelectMany(x => x.ToString()).ToArray());
        }

        /// <summary>
        /// Determines whether [has parameterless constructor] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if [has parameterless constructor] [the specified type]; otherwise, <c>false</c>.</returns>
        public static bool HasParameterlessConstructor(this Type type)
        {
            return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) != null;
        }
        /// <summary>
        /// Return maximum type. Works with value and reference types.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj1">The obj1.</param>
        /// <param name="obj2">The obj2.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">obj1 - Object 1 cannot be null.
        /// or
        /// obj2 - Object 1 cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">obj1 - Object 1 cannot be null.
        /// or
        /// obj2 - Object 1 cannot be null.</exception>
        /// <remarks>Original code by: Jeremy Clark</remarks>
        public static T Max<T>(this T obj1, T obj2) where T : IComparable
        {
            if (obj2 == null)
            {
                throw new ArgumentNullException(nameof(obj2), $"{nameof(obj1)} cannot be null.");
            }

            return obj1.CompareTo(obj2) >= 0 ? obj1 : obj2;
        }

        /// <summary>
        /// Creates type instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        /// <remarks>Original code by: Jeremy Clark</remarks>
        internal static T Create<T>() where T : class, new()
        {
            var instance = Activator.CreateInstance<T>();

            return instance is T ? instance : null;
        }
    }
}