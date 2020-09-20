// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2020
// ***********************************************************************
// <copyright file="DriveHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Management;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class DriveHelper.
    /// </summary>
    public static class DriveHelper
    {

        /// <summary>
        /// Gets the serial number of a drive.
        /// </summary>
        /// <param name="drive">The drive.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(GetDriveSerialNumber), author: "David McCarter", createdOn: "9/6/2020", modifiedOn: "9/6/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static string GetDriveSerialNumber(string drive)
        {
            Encapsulation.TryValidateParam(drive, nameof(drive));

            var driveSerial = string.Empty;

            // No matter what is sent in, get just the drive letter
            var driveFixed = System.IO.Path.GetPathRoot(drive);
            driveFixed = driveFixed.Replace(@"\", string.Empty);

            // Perform Query
            using (ManagementObjectSearcher querySearch = new ManagementObjectSearcher(string.Format("SELECT VolumeSerialNumber FROM Win32_LogicalDisk Where Name = '{0}'", driveFixed)))
            {
                using (ManagementObjectCollection queryCollection = querySearch.Get())
                {
                    foreach (var moItem in queryCollection)
                    {
                        driveSerial = System.Convert.ToString(moItem.GetPropertyValue("VolumeSerialNumber"));
                        break;
                    }
                }
            }

            return driveSerial;
        }

        /// <summary>
        /// Gets the fixed drives, that are ready, for a computer.
        /// </summary>
        /// <returns>IImmutableList&lt;DirectoryInfo&gt;.</returns>
        public static IImmutableList<DriveInfo> GetFixedDrives()
        {
            return DriveInfo.GetDrives()
                .Where(p => p.DriveType == DriveType.Fixed & p.IsReady)
                .Distinct()
                .ToImmutableList();
        }

        /// <summary>
        /// Gets the removable drives, that are ready, for a computer.
        /// </summary>
        /// <returns>IImmutableList&lt;DriveInfo&gt;.</returns>
        public static IImmutableList<DriveInfo> GetRemovableDrives()
        {
            return DriveInfo.GetDrives()
                .Where(p => p.DriveType == DriveType.Removable & p.IsReady)
                .Distinct()
                .ToImmutableList();
        }
    }
}
