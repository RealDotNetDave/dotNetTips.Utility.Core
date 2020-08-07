// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 08-07-2020
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.InteropServices;
using dotNetTips.Utility.Standard.OOP;
using Microsoft.Win32;

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
        /// <exception cref="PlatformNotSupportedException">The platform exception.</exception>
        public static RegistryKey GetCurrentUserRegistryKey(string name)
        {
            Encapsulation.TryValidateParam(name, nameof(name));

            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? Registry.CurrentUser.OpenSubKey(name) : throw new PlatformNotSupportedException();
        }
    }
}
