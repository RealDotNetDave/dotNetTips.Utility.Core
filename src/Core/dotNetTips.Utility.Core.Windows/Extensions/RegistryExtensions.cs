﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 06-16-2018
//
// Last Modified By : David McCarter
// Last Modified On : 08-07-2020
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.InteropServices;
using dotNetTips.Utility.Standard.OOP;
using Microsoft.Win32;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class RegistryExtensions.
    /// </summary>
    public static class RegistryExtensions
    {
        /// <summary>
        /// Gets the registry key sub key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="name">The name.</param>
        /// <returns>RegistryKey.</returns>
        /// <exception cref="PlatformNotSupportedException">The exception.</exception>
        public static RegistryKey GetSubKey(this RegistryKey key, string name)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam(name, nameof(name));

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return key.OpenSubKey(name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }

        /// <summary>
        /// Gets the registry key value.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="name">The name.</param>
        /// <returns>T.</returns>
        /// <exception cref="PlatformNotSupportedException">The exception.</exception>
        public static T GetValue<T>(this RegistryKey key, string name)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam(name, nameof(name));

#pragma warning disable CS8653 // A default expression introduces a null value for a type parameter.
            var returnValue = default(T);
#pragma warning restore CS8653 // A default expression introduces a null value for a type parameter.

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var keyValue = key.GetValue(name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                if (keyValue != null)
                {
                    returnValue = (T)keyValue;
                }

#pragma warning disable CS8603 // Possible null reference return.
                return returnValue;
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
