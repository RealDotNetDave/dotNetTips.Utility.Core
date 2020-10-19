// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-08-2020
// ***********************************************************************
// <copyright file="DirectoryInfoExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// DirectoryInfoExtensions.
    /// </summary>
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// Gets the total size of a directory.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="ArgumentNullException">info</exception>
        [Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.New)]
        public static long GetSize(this DirectoryInfo info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            long size = 0;

            for (var i = 0; i < info.GetDirectories().Length; i++)
            {
                size += info.GetDirectories()[i].GetSize();
            }

            for (var i = 0; i < info.GetFiles().Length; i++)
            {
                size += info.GetFiles()[i].Length;
            }

            return size;
        }
    }
}
