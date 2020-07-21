// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2020
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
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
        /// Gets the abstract methods.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
        public static IEnumerable<MethodInfo> GetAllAbstractMethods(this Type type)
        {
            return type.GetRuntimeMethods().Where(m => m.IsAbstract);
        }
        /// <summary>
        /// Gets all fields.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;FieldInfo&gt;.</returns>
        public static IEnumerable<FieldInfo> GetAllFields(this Type type)
        {
            var typeInfo = type.GetTypeInfo();

            while (typeInfo != null)
            {
                foreach (var fieldInfo in typeInfo.DeclaredFields)
                {
                    yield return fieldInfo;
                }

                typeInfo = typeInfo.BaseType?.GetTypeInfo();
            }
        }

        /// <summary>
        /// Gets the generic methods.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
        /// <remarks>NEW</remarks>
        public static IEnumerable<MethodInfo> GetAllGenericMethods(this Type type)
        {
            return type.GetRuntimeMethods().Where(m => m.IsGenericMethod);
        }

        /// <summary>
        /// Gets all methods.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static IEnumerable<MethodInfo> GetAllMethods(this Type type)
        {
            var typeInfo = type.GetTypeInfo();

            while (typeInfo != null)
            {
                foreach (var methodInfo in typeInfo.DeclaredMethods)
                {
                    yield return methodInfo;
                }

                typeInfo = typeInfo.BaseType?.GetTypeInfo();
            }
        }

        /// <summary>
        /// Gets all properties.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;PropertyInfo&gt;.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
        {
            var typeInfo = type.GetTypeInfo();

            while (typeInfo != null)
            {
                foreach (var propertyInfo in typeInfo.DeclaredProperties)
                {
                    yield return propertyInfo;
                }

                typeInfo = typeInfo.BaseType?.GetTypeInfo();
            }
        }

        /// <summary>
        /// Gets the public methods.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
        /// <remarks>NEW</remarks>
        public static IEnumerable<MethodInfo> GetAllPublicMethods(this Type type)
        {
            return type.GetRuntimeMethods().Where(m => m.IsPublic);
        }

        /// <summary>
        /// Gets the static methods.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>IEnumerable&lt;MethodInfo&gt;.</returns>
        /// <remarks>NEW</remarks>
        public static IEnumerable<MethodInfo> GetAllStaticMethods(this Type type)
        {
            return type.GetRuntimeMethods().Where(m => m.IsStatic);
        }
        /// <summary>
        /// Gets the field hash.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="callback">The callback.</param>
        /// <returns>Hash for the field as System.String.</returns>
        /// <exception cref="ArgumentNullException">callback</exception>
        public static string GetFieldHash<T>(this Func<T> callback)
        {
            if (callback is null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return new string(callback.Target.GetType().GetFields().Where(x => x.MemberType == MemberTypes.Field).Select(x => x.GetValue(callback.Target)).Where(x => x != null).SelectMany(x => x.ToString()).ToArray());
        }


        /// <summary>
        /// Gets the type members with given attribute.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the t attribute.</typeparam>
        /// <param name="type">The type.</param>
        /// <returns>System.ValueTuple&lt;System.String, TAttribute, System.Boolean, System.Boolean, Type&gt;[].</returns>
        /// <exception cref="InvalidOperationException">Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it</exception>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static (string Name, TAttribute Attribute, bool IsPrivate, bool IsStatic, Type ParameterType)[] GetTypeMembersWithAttribute<TAttribute>(this Type type)
        where TAttribute : Attribute
        {
            var allFields = type.GetFields()
                                .Select(f => (
                                    Name: f.Name,
                                    Attribute: f.GetAttribute<TAttribute>(),
                                    IsPrivate: f.IsPrivate,
                                    IsStatic: f.IsStatic,
                                    ParameterType: f.FieldType));

            var allProperties = type.GetProperties()
                                    .Select(p => (
                                        Name: p.Name,
                                        Attribute: p.GetAttribute<TAttribute>(),
                                        IsPrivate: p.GetSetMethod() == null,
                                        IsStatic: p.GetSetMethod() != null && p.GetSetMethod().IsStatic,
                                        PropertyType: p.PropertyType));

            var joined = allFields.Concat(allProperties).Where(member => member.Attribute != null).ToArray();

            foreach (var member in joined.Where(m => m.IsPrivate))
            {
                throw new InvalidOperationException($"Member \"{member.Name}\" must be public if it has the [{typeof(TAttribute).Name}] attribute applied to it");
            }

            return joined;
        }

        /// <summary>
        /// Determines whether the specified method information has attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodInfo">The method information.</param>
        /// <returns><c>true</c> if the specified method information has attribute; otherwise, <c>false</c>.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static bool HasAttribute<T>(this MethodInfo methodInfo) where T : Attribute =>
            methodInfo.GetAttribute<T>() != null;

        /// <summary>
        /// Determines whether [has parameterless constructor] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if [has parameterless constructor] [the specified type]; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">type</exception>
        public static bool HasParameterlessConstructor(this Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) != null;
        }

        /// <summary>
        /// Determines whether the specified type is nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if the specified type is nullable; otherwise, <c>false</c>.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static bool IsNullable(this Type type) => Nullable.GetUnderlyingType(type) != null;

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
        /// Resolves the attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <returns>T.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static T GetAttribute<T>(this Type type) where T : Attribute =>
    type?.GetTypeInfo().GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();

        /// <summary>
        /// Resolves the attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methodInfo">The method information.</param>
        /// <returns>T.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static T GetAttribute<T>(this MethodInfo methodInfo) where T : Attribute =>
            methodInfo?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;

        /// <summary>
        /// Resolves the attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyInfo">The property information.</param>
        /// <returns>T.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static T GetAttribute<T>(this PropertyInfo propertyInfo) where T : Attribute =>
            propertyInfo?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;

        /// <summary>
        /// Resolves the attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldInfo">The field information.</param>
        /// <returns>T.</returns>
        /// <remarks>NEW: Orginal Code from: https://github.com/dotnet/BenchmarkDotNet</remarks>
        public static T GetAttribute<T>(this FieldInfo fieldInfo) where T : Attribute =>
            fieldInfo?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;

    }


}