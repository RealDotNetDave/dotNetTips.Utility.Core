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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static char[] InvalidFilterChars => _invalidFilterChars;

        /// <summary>
        /// Gets the invalid path name chars.
        /// </summary>
        /// <value>The invalid path name chars.</value>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static char[] InvalidPathNameChars => _invalidPathNameChars;

        /// <summary>
        /// Gets the path separators.
        /// </summary>
        /// <value>The path separators.</value>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static char[] PathSeparators => _pathSeparators;

        /// <summary>
        /// Combines the paths.
        /// </summary>
        /// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
        /// <param name="paths">The paths.</param>
        /// <returns>DirectoryInfo.</returns>
        [Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", modifiedOn: "8/10/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static DirectoryInfo CombinePaths(bool createIfNotExists, params string[] paths)
        {
            Encapsulation.TryValidateParam(paths, nameof(paths));

            var pathString = Path.Combine(paths);

            var di = new DirectoryInfo(pathString);

            if (createIfNotExists && di.Exists is false)
            {
                di.Create();
            }

            return di;
        }

        /// <summary>
        /// Combines the specified path strings.
        /// </summary>
        /// <param name="path1">The path1.</param>
        /// <param name="path2">The path2.</param>
        /// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
        /// <returns>DirectoryInfo.</returns>
        [Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", modifiedOn: "8/10/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static DirectoryInfo CombinePaths(string path1, string path2, bool createIfNotExists = false)
        {
            Encapsulation.TryValidateParam(path1, nameof(path1));
            Encapsulation.TryValidateParam(path2, nameof(path2));

            return CombinePaths(createIfNotExists, path1, path2);
        }

        /// <summary>
        /// Combines the paths.
        /// </summary>
        /// <param name="path1">The path1.</param>
        /// <param name="path2">The path2.</param>
        /// <param name="path3">The path3.</param>
        /// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
        /// <returns>DirectoryInfo.</returns>
        /// <returns>DirectoryInfo.</returns>
        [Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", modifiedOn: "8/10/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static DirectoryInfo CombinePaths(string path1, string path2, string path3, bool createIfNotExists = false)
        {
            Encapsulation.TryValidateParam(path1, nameof(path1));
            Encapsulation.TryValidateParam(path2, nameof(path2));
            Encapsulation.TryValidateParam(path3, nameof(path3));

            return CombinePaths(createIfNotExists, path1, path2, path3);
        }

        /// <summary>
        /// Combines the paths.
        /// </summary>
        /// <param name="path1">The path1.</param>
        /// <param name="path2">The path2.</param>
        /// <param name="path3">The path3.</param>
        /// <param name="path4">The path4.</param>
        /// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
        /// <returns>DirectoryInfo.</returns>
        [Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", modifiedOn: "8/10/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static DirectoryInfo CombinePaths(string path1, string path2, string path3, string path4, bool createIfNotExists = false)
        {
            Encapsulation.TryValidateParam(path1, nameof(path1));
            Encapsulation.TryValidateParam(path2, nameof(path2));
            Encapsulation.TryValidateParam(path3, nameof(path3));
            Encapsulation.TryValidateParam(path4, nameof(path4));

            return CombinePaths(createIfNotExists, path1, path2, path3, path4);
        }

        /// <summary>
        /// Ensures the trailing slash.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>System.String.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 88, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool PathHasInvalidChars(string path)
        {
            Encapsulation.TryValidateParam(path, nameof(path));

            return path.IndexOfAny(_invalidPathNameChars) != -1;
        }

    }
}
