// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-16-2019
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace dotNetTips.Utility.Core.Windows.Win32
{
    /// <summary>
    /// Class RegistryHelper.
    /// </summary>
    public static class RegistryHelper
    {
        /// <summary>
        /// The key current user one drive
        /// </summary>
        public const string KeyCurrentUserOneDrive = @"Software\Microsoft\OneDrive";

        /// <summary>
        /// Gets the registry key.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>RegistryKey.</returns>
        /// <exception cref="PlatformNotSupportedException"></exception>
        /// <exception cref="System.PlatformNotSupportedException">The exception.</exception>
        /// <exception cref="PlatformNotSupportedException"></exception>
        public static RegistryKey GetCurrentUserRegistryKey(string name)
        {
            Encapsulation.TryValidateParam(name, nameof(name));

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Registry.CurrentUser.OpenSubKey(name);
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
