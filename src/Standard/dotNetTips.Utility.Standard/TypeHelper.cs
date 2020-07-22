// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-09-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
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
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class TypeHelper.
    /// </summary>
    public static class TypeHelper
    {

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
        /// <exception cref="DirectoryNotFoundException">Could not find path.</exception>
        /// <exception cref="dotNetTips.Utility.Standard.DirectoryNotFoundException">Could not find path.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Could not find path.</exception>
        /// <exception cref="ArgumentNullException">Could not find path.</exception>
        public static IEnumerable<Type> FindDerivedTypes(string path, SearchOption searchOption, Type baseType, bool classOnly)
        {
            Encapsulation.TryValidateParam(path, nameof(path), "Must pass in path and file name to the assembly.");
            Encapsulation.TryValidateParam<ArgumentNullException>(baseType != null, nameof(baseType), "Parent Type must be defined");

            var foundTypes = new List<Type>();

            if (Directory.Exists(path) == false)
            {
                throw new DirectoryNotFoundException("Could not find path.", path);
            }

            var files = Directory.EnumerateFiles(path, "*.dll", searchOption);

            var list = files.ToList();

            for (int i = 0; i < list.Count; i++)
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
        /// Loads the derived types of a type.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="classOnly">if set to <c>true</c> [class only].</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        private static IEnumerable<Type> LoadDerivedTypes(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
        {
            // works out the derived types
            List<TypeInfo> list = types.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                TypeInfo type = list[i];

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

    }
}