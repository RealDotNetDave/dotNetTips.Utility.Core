// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-09-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2020
// ***********************************************************************
// <copyright file="TypeHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class TypeHelper.
    /// </summary>
    public static class TypeHelper
    {

        private const char DefaultNestedTypeDelimiter = '+';

        private static readonly Dictionary<Type, string> _builtInTypeNames = new Dictionary<Type, string>
        {
            { typeof(void), "void" },
            { typeof(bool), "bool" },
            { typeof(byte), "byte" },
            { typeof(char), "char" },
            { typeof(decimal), "decimal" },
            { typeof(double), "double" },
            { typeof(float), "float" },
            { typeof(int), "int" },
            { typeof(long), "long" },
            { typeof(object), "object" },
            { typeof(sbyte), "sbyte" },
            { typeof(short), "short" },
            { typeof(string), "string" },
            { typeof(uint), "uint" },
            { typeof(ulong), "ulong" },
            { typeof(ushort), "ushort" }
        };

        /// <summary>
        /// Creates type instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        /// <remarks>Original code by: Jeremy Clark</remarks>
        public static T Create<T>() where T : class
        {
            var instance = Activator.CreateInstance<T>();

            return instance is T ? instance : null;
        }

        /// <summary>
        /// Creates the specified parameter array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="paramArray">The parameter array.</param>
        /// <returns>T.</returns>
        public static T Create<T>(params object[] paramArray)
        {
            var instance = (T)Activator.CreateInstance(typeof(T), args: paramArray);

            return instance;
        }

        /// <summary>
        /// Does the object equal instance.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="instance">The instance.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool DoesObjectEqualInstance(object value, object instance)
        {
            var result = object.ReferenceEquals(value, instance);

            return result;
        }

        /// <summary>
        /// Finds the derived types.
        /// </summary>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="classOnly">if set to <c>true</c> [class only].</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        public static IEnumerable<Type> FindDerivedTypes(Type baseType, bool classOnly)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            return FindDerivedTypes(path, SearchOption.TopDirectoryOnly, baseType, classOnly);
        }


        /// <summary>
        /// Finds the derived types.
        /// </summary>
        /// <param name="currentDomain">The current domain.</param>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="classOnly">if set to <c>true</c> [class only].</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        public static IEnumerable<Type> FindDerivedTypes(AppDomain currentDomain, Type baseType, bool classOnly)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(currentDomain != null, nameof(currentDomain));
            Encapsulation.TryValidateParam<ArgumentNullException>(baseType != null, nameof(baseType));

            List<Type> types = null;

            var array = currentDomain.GetAssemblies();

            for (var assemblyCount = 0; assemblyCount < array.Length; assemblyCount++)
            {
                var assembly = array[assemblyCount];
                var tempTypes = LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly).ToList();

                if (tempTypes.HasItems())
                {
                    if (types == null)
                    {
                        types = tempTypes;
                    }
                    else
                    {
                        types.AddRange(tempTypes);
                    }
                }
            }

            return types;
        }

        /// <summary>
        /// Finds the derived types.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="searchOption">The search option.</param>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="classOnly">if set to <c>true</c> [class only].</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <exception cref="dotNetTips.Utility.Standard.Common.DirectoryNotFoundException">Could not find path.</exception>
        /// <exception cref="ArgumentNullException">Could not find path.</exception>
        public static IEnumerable<Type> FindDerivedTypes(string path, SearchOption searchOption, Type baseType, bool classOnly)
        {
            Encapsulation.TryValidateParam(path, nameof(path), "Must pass in path and file name to the assembly.");
            Encapsulation.TryValidateParam<ArgumentNullException>(baseType != null, nameof(baseType), "Parent Type must be defined");

            var foundTypes = new List<Type>();

            if (Directory.Exists(path) == false)
            {
                throw new dotNetTips.Utility.Standard.Common.DirectoryNotFoundException("Could not find path.", path);
            }

            var files = Directory.EnumerateFiles(path, "*.dll", searchOption);

            var list = files.ToList();

            for (var i = 0; i < list.Count; i++)
            {
                string file = list[i];
                var assy = Assembly.LoadFile(file);

                var containsBaseType = assy.ExportedTypes.ToList().TrueForAll(p => p.BaseType != null &&
                    p.BaseType.FullName == baseType.FullName);

                if (containsBaseType)
                {
                    foundTypes.AddRange(LoadDerivedTypes(assy.DefinedTypes, baseType, classOnly));
                }
            }

            return foundTypes;
        }

        /// <summary>
        /// Gets the default type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        public static T GetDefault<T>()
        {
            var result = default(T);

            return result;
        }

        /// <summary>
        /// Gets the instance hash code.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>Int32.</returns>
        public static int GetInstanceHashCode(object instance)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(instance != null, nameof(instance));

            var hash = -1;

            hash = instance.GetType().GetRuntimeProperties().Where(p => p != null).Select(prop => prop.GetValue(instance)).Where(value => value != null).Aggregate(-1, (accumulator, value) => accumulator ^ value.GetHashCode());

            return hash;
        }

        /// <summary>
        /// Gets the display name of the type.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="fullName">if set to <c>true</c> [full name].</param>
        /// <returns>System.String.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
        public static string GetTypeDisplayName(object item, bool fullName = true)
        {
            return item == null ? null : GetTypeDisplayName(item.GetType(), fullName);
        }

        /// <summary>
        /// Pretty print a type name.
        /// </summary>
        /// <param name="type">The <see cref="Type" />.</param>
        /// <param name="fullName"><c>true</c> to print a fully qualified name.</param>
        /// <param name="includeGenericParameterNames"><c>true</c> to include generic parameter names.</param>
        /// <param name="includeGenericParameters"><c>true</c> to include generic parameters.</param>
        /// <param name="nestedTypeDelimiter">Character to use as a delimiter in nested type names</param>
        /// <returns>The pretty printed type name.</returns>
        /// <exception cref="ArgumentNullException">type</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = DefaultNestedTypeDelimiter)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type), $"{nameof(type)} is null.");
            }

            var builder = new StringBuilder();

            ProcessType(builder, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));

            return builder.ToString();
        }

        /// <summary>
        /// Loads the derived types of a type.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="classOnly">if set to <c>true</c> [class only].</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        private static IEnumerable<Type> LoadDerivedTypes(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
        {
            // works out the derived types
            var list = types.ToList();

            for (var i = 0; i < list.Count; i++)
            {
                var type = list[i];

                // if classOnly, it must be a class
                // useful when you want to create instance
                if (classOnly && !type.IsClass)
                {
                    continue;
                }

                if (baseType.IsInterface)
                {
                    if (type.GetInterface(baseType.FullName) != null)
                    {
                        // add it to result list
                        yield return type;
                    }
                }
                else if (type.IsSubclassOf(baseType))
                {
                    // add it to result list
                    yield return type;
                }
            }
        }

        private static void ProcessArrayType(StringBuilder builder, Type type, in DisplayNameOptions options)
        {
            Type innerType = type;
            while (innerType.IsArray)
            {
                innerType = innerType.GetElementType();
            }

            ProcessType(builder, innerType, options);

            while (type.IsArray)
            {
                builder.Append(ControlChars.StartSquareBracket);
                builder.Append(ControlChars.Comma, type.GetArrayRank() - 1);
                builder.Append(ControlChars.EndSquareBracket);
                type = type.GetElementType();
            }
        }

        private static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, in DisplayNameOptions options)
        {
            var offset = 0;

            if (type.IsNested)
            {
                offset = type.DeclaringType.GetGenericArguments().Length;
            }

            if (options.FullName)
            {
                if (type.IsNested)
                {
                    ProcessGenericType(builder, type.DeclaringType, genericArguments, offset, options);
                    builder.Append(options.NestedTypeDelimiter);
                }
                else if (!string.IsNullOrEmpty(type.Namespace))
                {
                    builder.Append(type.Namespace);
                    builder.Append(ControlChars.Dot);
                }
            }

            var genericPartIndex = type.Name.IndexOf('`');
            if (genericPartIndex <= 0)
            {
                builder.Append(type.Name);
                return;
            }

            builder.Append(type.Name, 0, genericPartIndex);

            if (options.IncludeGenericParameters)
            {
                builder.Append(ControlChars.StartAngleBracket);

                for (var i = offset; i < length; i++)
                {
                    ProcessType(builder, genericArguments[i], options);

                    if (i + 1 == length)
                    {
                        continue;
                    }

                    builder.Append(ControlChars.Comma);
                    if (options.IncludeGenericParameterNames || !genericArguments[i + 1].IsGenericParameter)
                    {
                        builder.Append(ControlChars.Space);
                    }
                }

                builder.Append(ControlChars.EndAngleBracket);
            }
        }

        private static void ProcessType(StringBuilder builder, Type type, in DisplayNameOptions options)
        {
            if (type.IsGenericType)
            {
                var genericArguments = type.GetGenericArguments();
                ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
            }
            else if (type.IsArray)
            {
                ProcessArrayType(builder, type, options);
            }
            else if (_builtInTypeNames.TryGetValue(type, out var builtInName))
            {
                builder.Append(builtInName);
            }
            else if (type.IsGenericParameter)
            {
                if (options.IncludeGenericParameterNames)
                {
                    builder.Append(type.Name);
                }
            }
            else
            {
                var name = options.FullName ? type.FullName : type.Name;
                builder.Append(name);

                if (options.NestedTypeDelimiter != DefaultNestedTypeDelimiter)
                {
                    builder.Replace(DefaultNestedTypeDelimiter, options.NestedTypeDelimiter, builder.Length - name.Length, name.Length);
                }
            }
        }

        /// <summary>
        /// Struct DisplayNameOptions
        /// </summary>
        private readonly struct DisplayNameOptions
        {

            /// <summary>
            /// Initializes a new instance of the <see cref="DisplayNameOptions"/> struct.
            /// </summary>
            /// <param name="fullName">if set to <c>true</c> [full name].</param>
            /// <param name="includeGenericParameterNames">if set to <c>true</c> [include generic parameter names].</param>
            /// <param name="includeGenericParameters">if set to <c>true</c> [include generic parameters].</param>
            /// <param name="nestedTypeDelimiter">The nested type delimiter.</param>
            public DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
            {
                FullName = fullName;
                IncludeGenericParameters = includeGenericParameters;
                IncludeGenericParameterNames = includeGenericParameterNames;
                NestedTypeDelimiter = nestedTypeDelimiter;
            }

            /// <summary>
            /// Gets a value indicating whether [full name].
            /// </summary>
            /// <value><c>true</c> if [full name]; otherwise, <c>false</c>.</value>
            public bool FullName { get; }

            /// <summary>
            /// Gets a value indicating whether [include generic parameter names].
            /// </summary>
            /// <value><c>true</c> if [include generic parameter names]; otherwise, <c>false</c>.</value>
            public bool IncludeGenericParameterNames { get; }

            /// <summary>
            /// Gets a value indicating whether [include generic parameters].
            /// </summary>
            /// <value><c>true</c> if [include generic parameters]; otherwise, <c>false</c>.</value>
            public bool IncludeGenericParameters { get; }

            /// <summary>
            /// Gets the nested type delimiter.
            /// </summary>
            /// <value>The nested type delimiter.</value>
            public char NestedTypeDelimiter { get; }

        }

    }
}
