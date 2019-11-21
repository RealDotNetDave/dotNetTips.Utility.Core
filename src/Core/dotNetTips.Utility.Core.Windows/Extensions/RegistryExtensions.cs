// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 06-16-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2019
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

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
        /// <exception cref="System.PlatformNotSupportedException">The exception.</exception>
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
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="name">The name.</param>
        /// <returns>T.</returns>
        /// <exception cref="PlatformNotSupportedException">The exception.</exception>
        /// <exception cref="System.PlatformNotSupportedException">The exception.</exception>
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

                return returnValue;
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
