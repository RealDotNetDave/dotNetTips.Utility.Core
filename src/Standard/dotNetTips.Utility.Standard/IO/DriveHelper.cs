// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2019
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class DriveHelper.
    /// </summary>
    public static class DriveHelper
    {
        /// <summary>
        /// Gets the fixed drives, that are ready, for a computer.
        /// </summary>
        /// <returns>IImmutableList&lt;DirectoryInfo&gt;.</returns>
        public static IImmutableList<DriveInfo> GetFixedDrives()
        {
            return DriveInfo.GetDrives().Where(p => p.DriveType == DriveType.Fixed & p.IsReady).Distinct().ToImmutableList();
        }

        /// <summary>
        /// Gets the removeable drives, that are ready, for a computer.
        /// </summary>
        /// <returns>IImmutableList&lt;DriveInfo&gt;.</returns>
        public static IImmutableList<DriveInfo> GetRemoveableDrives()
        {
            return DriveInfo.GetDrives().Where(p => p.DriveType == DriveType.Removable & p.IsReady).Distinct().ToImmutableList();
        }
    }
}
