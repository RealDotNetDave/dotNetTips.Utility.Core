// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-11-2018
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2020
// ***********************************************************************
// <copyright file="PathHelperc.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.IO;
using System.Linq;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class PathHelper.
    /// </summary>
    public static class PathHelper
    {

        private static readonly char[] _invalidFilterChars = FileHelper.InvalidFileNameChars.Where(c => c != '*' && c != '|' && c != '?').ToArray();
        private static readonly char[] _invalidPathNameChars = Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

        private static readonly char[] _pathSeparators = new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };

        /// <summary>
        /// Gets the invalid filter chars.
        /// </summary>
        /// <value>The invalid filter chars.</value>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static char[] InvalidFilterChars => _invalidFilterChars;

        /// <summary>
        /// Gets the invalid path name chars.
        /// </summary>
        /// <value>The invalid path name chars.</value>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static char[] InvalidPathNameChars => _invalidPathNameChars;

        /// <summary>
        /// Gets the path separators.
        /// </summary>
        /// <value>The path separators.</value>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.New)]
        public static char[] PathSeparators => _pathSeparators;

        /// <summary>
        /// Ensures the trailing slash.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>System.String.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 88, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
        public static string EnsureTrailingSlash(string path)
        {
            Encapsulation.TryValidateParam(path, nameof(path));

            if (path[path.Length - 1] != Path.DirectorySeparatorChar)
            {
                return path + Path.DirectorySeparatorChar;
            }

            return path;
        }

        /// <summary>
        /// Determines whether [has invalid filter chars] [the specified path].
        /// </summary>
        /// <param name="filter">The path.</param>
        /// <returns><c>true</c> if [has invalid filter chars] [the specified path]; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
        public static bool HasInvalidFilterChars(string filter)
        {
            Encapsulation.TryValidateParam(filter, nameof(filter));

            return filter.IndexOfAny(_invalidFilterChars) != -1;
        }

        /// <summary>
        /// Checks to see if path contains any wild cards.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool PathContainsWildcard(string path)
        {
            Encapsulation.TryValidateParam(path, nameof(path));

            return (path?.IndexOf('*') != -1) || (path?.IndexOf('?') != -1);
        }



        /// <summary>
        /// Pathes the has invalid chars.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New)]
        public static bool PathHasInvalidChars(string path)
        {
            Encapsulation.TryValidateParam(path, nameof(path));

            return path.IndexOfAny(_invalidPathNameChars) != -1;
        }

    }
}
