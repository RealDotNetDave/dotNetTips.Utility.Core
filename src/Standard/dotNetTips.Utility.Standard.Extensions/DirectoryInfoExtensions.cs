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
using System.IO;
using System.Linq;
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
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="searchOption">The search opion.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="ArgumentNullException">info</exception>
        [Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/20/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static long GetSize(this DirectoryInfo info,
                                   string searchPattern = "*.*",
                                   SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            if(info is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(info));
            }

            if(string.IsNullOrEmpty(searchPattern))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(searchPattern));
            }

            if(Enum.IsDefined(typeof(SearchOption), searchOption) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(searchOption));
            }

            var size = info.GetFiles(searchPattern, searchOption).Sum(p => p.Length);

            return size;
        }
    }
}
