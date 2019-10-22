// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-19-2019
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class DirectoryHelper.
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Applications the application data folder for Windows or Mac.
        /// </summary>
        /// <returns>Application data folder.</returns>
        public static string AppDataFolder()
        {
            var userPath = Environment.GetEnvironmentVariable(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "LOCALAPPDATA" : "Home");

            var companyName = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault().Company.Trim();

            var path = Path.Combine(userPath, companyName);

            return path;
        }

        /// <summary>
        /// Copies directory to a new location.
        /// </summary>
        /// <param name="sourceDirectory">The source directory.</param>
        /// <param name="destinationDirectory">The destination directory.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        public static void CopyDirectory(string sourceDirectory, string destinationDirectory, bool overwrite = true)
        {
            Encapsulation.TryValidateParam(sourceDirectory, nameof(sourceDirectory));
            Encapsulation.TryValidateParam(destinationDirectory, nameof(destinationDirectory));

            var directory = new DirectoryInfo(sourceDirectory);

            var directiories = directory.GetDirectories();

            if (Directory.Exists(destinationDirectory) == false)
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            var files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];

                file.CopyTo(Path.Combine(destinationDirectory, file.Name), overwrite);
            }

            for (int i = 0; i < directiories.Length; i++)
            {
                var subDirectory = directiories[i];

                CopyDirectory(subDirectory.FullName, Path.Combine(destinationDirectory, subDirectory.Name), overwrite);
            }
        }

        /// <summary>
        /// Deletes the directory.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void DeleteDirectory(string path)
        {
            DeleteDirectory(path, 1);
        }

        /// <summary>
        /// Deletes the directory with retry.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="retries">Number of retries.</param>
        /// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
        public static void DeleteDirectory(string path, int retries = 10)
        {
            Encapsulation.TryValidateParam(path, nameof(path));
            Encapsulation.TryValidateParam<ArgumentInvalidException>(Directory.Exists(path));

            retries = Math.Max(1, retries);
            var tries = 0;

            do
            {
                tries++;

                if (tries > 1)
                {
                    // If something has a transient lock on the file waiting may resolve the issue
                    Thread.Sleep((retries + 1) * 10);
                }

                try
                {
                    // On some systems, directories/files created are created with attributes
                    // that prevent them from being deleted. Set those attributes to be normal
                    SetFileAttributesToNormal(path);
                    Directory.Delete(path, true);

                    return;
                }
                catch (IOException) when (tries >= retries)
                {
                    throw;
                }
                catch (UnauthorizedAccessException) when (tries >= retries)
                {
                    throw;
                }
            }
            while (retries > tries);
        }

        /// <summary>
        /// Delete directory, with retries, as an asynchronous operation.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <returns>Task&lt;System.Boolean&gt;.</returns>
        /// <exception cref="System.ArgumentNullException">directory</exception>
        /// <exception cref="ArgumentNullException">directory</exception>
        public static async Task<bool> DeleteDirectoryAsync(DirectoryInfo directory)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(directory != null);

            if (directory.Exists)
            {
                await Task.Factory.StartNew(() =>
                {
                    DeleteDirectory(directory.FullName);
                    return true;
                }).ConfigureAwait(true);
            }

            return false;
        }

        /// <summary>
        /// Loads the files.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="searchOption">The search option.</param>
        /// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
        public static IEnumerable<FileInfo> LoadFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return LoadFiles(new List<DirectoryInfo> { new DirectoryInfo(path) }, searchPattern, searchOption);
        }

        /// <summary>
        /// Loads the files.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="searchOption">The search option.</param>
        /// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
        public static IEnumerable<FileInfo> LoadFiles(DirectoryInfo directory, string searchPattern, SearchOption searchOption)
        {
            return LoadFiles(new List<DirectoryInfo> { directory }, searchPattern, searchOption);
        }

        /// <summary>
        /// Loads the files.
        /// </summary>
        /// <param name="directories">The directories.</param>
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="searchOption">The search option.</param>
        /// <returns>IEnumerable(Of FileInfo).</returns>
        public static IEnumerable<FileInfo> LoadFiles(IEnumerable<DirectoryInfo> directories, string searchPattern, SearchOption searchOption)
        {
            Encapsulation.TryValidateParam(directories, nameof(directories));
            Encapsulation.TryValidateParam(searchPattern, nameof(searchPattern));
            Encapsulation.TryValidateParam(searchOption, nameof(searchOption));

            var files = new List<FileInfo>();

            var validDirectories = directories.Where(directory => directory.Exists).Select(directory => directory).ToList();

            validDirectories.ForEach(directory =>
            {
                try
                {
                    var directoryFiles = directory.EnumerateFiles(searchPattern, searchOption).ToArray();

                    if (directoryFiles.HasItems())
                    {
                        files.AddIfNotExists(directoryFiles);
                    }
                }
                catch (Exception ex) when (ex is DirectoryNotFoundException || ex is SecurityException)
                {
                    System.Diagnostics.Trace.WriteLine(ex.Message);
                }

            });

            return files.AsEnumerable();
        }

        /// <summary>
        /// Moves the directory.
        /// </summary>
        /// <param name="sourceDirectoryName">Name of the source directory.</param>
        /// <param name="destinationDirectoryName">Name of the destination directory.</param>
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
        {
            MoveDirectory(sourceDirectoryName, destinationDirectoryName, 1);
        }

        /// <summary>
        /// Moves the directory with retry.
        /// </summary>
        /// <param name="sourceDirectoryName">Name of the source dir.</param>
        /// <param name="destinationDirectoryName">Name of the destination dir.</param>
        /// <param name="retries">Number of retries.</param>
        /// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
        public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, int retries = 10)
        {
            Encapsulation.TryValidateParam(sourceDirectoryName, nameof(sourceDirectoryName));
            Encapsulation.TryValidateParam(destinationDirectoryName, nameof(destinationDirectoryName));
            Encapsulation.TryValidateParam<ArgumentInvalidException>(Directory.Exists(sourceDirectoryName));

            retries = Math.Max(1, retries);
            var tries = 0;

            do
            {
                tries++;

                if (tries > 1)
                {
                    // If something has a transient lock on the file waiting may resolve the issue
                    Thread.Sleep((retries + 1) * 10);
                }

                try
                {
                    Directory.Move(sourceDirectoryName, destinationDirectoryName);
                    return;
                }
                catch (IOException) when (tries >= retries)
                {
                    throw;
                }
                catch (UnauthorizedAccessException) when (tries >= retries)
                {
                    throw;
                }
            }
            while (tries < retries);
        }

        /// <summary>
        /// Safe directory search.
        /// </summary>
        /// <param name="rootDirectory">The root directory.</param>
        /// <param name="searchPattern">The search pattern.</param>
        /// <param name="searchOption">All or Top Directory Only</param>
        /// <returns>IEnumerable&lt;DirectoryInfo&gt;.</returns>
        public static IEnumerable<DirectoryInfo> SafeDirectorySearch(DirectoryInfo rootDirectory, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            Encapsulation.TryValidateParam(rootDirectory, nameof(rootDirectory));
            Encapsulation.TryValidateParam(searchPattern, nameof(searchPattern));

            var folders = new List<DirectoryInfo>
            {
                rootDirectory
            };

            for (int directoryCount = 0; directoryCount < rootDirectory.GetDirectories(searchPattern, searchOption).Length; directoryCount++)
            {
                try
                {
                    folders.AddRange(SafeDirectorySearch(rootDirectory.GetDirectories(searchPattern, searchOption)[directoryCount], searchPattern));
                }
                catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is DirectoryNotFoundException || ex is UnauthorizedAccessException)
                {
                    System.Diagnostics.Trace.WriteLine(ex.Message);
                }
            }

            return folders;
        }

        /// <summary>
        /// Sets the file attributes to normal for a path.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void SetFileAttributesToNormal(string path)
        {
            Encapsulation.TryValidateParam(path, nameof(path));

            for (var directoryCount = 0; directoryCount < Directory.GetDirectories(path).Length; directoryCount++)
            {
                SetFileAttributesToNormal(Directory.GetDirectories(path)[directoryCount]);
            }

            for (var fileCount = 0; fileCount < Directory.GetFiles(path).Length; fileCount++)
            {
                File.SetAttributes(Directory.GetFiles(path)[fileCount], System.IO.FileAttributes.Normal);
            }
        }
    }
}