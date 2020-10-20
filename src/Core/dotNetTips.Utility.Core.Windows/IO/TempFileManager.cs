// ***********************************************************************
// Assembly         : dotNetTips.Utility.Core.Windows
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-20-2020
// ***********************************************************************
// <copyright file="TempFileManager.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Core.Windows.IO
{
    /// <summary>
    /// TempFileManager creates and maintains a list of temporary files. Implements the <see cref="System.IDisposable"/>
    ///
    /// </summary>
    /// <seealso cref="System.IDisposable"/>
    [Information(nameof(TempFileManager), "David McCarter", "10/8/2020", "10/20/2020", UnitTestCoverage = 100, Status = Status.New)]
    public class TempFileManager : IDisposable
    {
        private bool _disposed;
        private List<string> _files = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempFileManager"/> class.
        /// </summary>
        public TempFileManager()
        {
        }

        private string GenerateRandomFile() { return Path.GetTempFileName(); }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged
        /// resources.
        /// </param>
        protected virtual new void Dispose(bool disposing)
        {
            if (!(this._disposed))
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if ((disposing))
                {
                    // Dispose managed resources.
                    this.DeleteAllFiles();
                }
            }

            this._disposed = true;
        }

        /// <summary>
        /// Creates a new temporary file.
        /// </summary>
        /// <returns>System.String.</returns>
        public string CreateFile()
        {
            string tempFile = GenerateRandomFile();

            this._files.Add(tempFile);

            return tempFile;
        }

        /// <summary>
        /// Creates multiple temp files.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns>ImmutableArray&lt;System.String&gt;.</returns>
        public IReadOnlyCollection<string> CreateFiles(int count)
        {
            count = count.EnsureMinimumValue(1);
            var files = new List<string>(count);

            for (int fileCount = 0; fileCount < count; fileCount++)
            {
                var fileName = GenerateRandomFile();

                files.Add(fileName);
            }

            this._files.AddRange(files);

            return files.ToReadOnlyCollection();
        }

        /// <summary>
        /// Deletes all temporary files.
        /// </summary>
        public void DeleteAllFiles()
        {
            if (this._files.HasItems())
            {
                var files = this._files.CopyToList();

                foreach (var fileName in files)
                {
                    this.DeleteFile(fileName);
                }
            }
        }

        /// <summary>
        /// Deletes a temporary file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void DeleteFile(string file)
        {
            Encapsulation.TryValidateParam(file, nameof(file));

            if (File.Exists(file))
            {
                File.Delete(file);
            }

            if (this._files.Contains(file))
            {
                this._files.Remove(file);
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// List of files currently being managed.
        /// </summary>
        /// <returns>IReadOnlyCollection&lt;System.String&gt;.</returns>
        public IReadOnlyCollection<string> FilesList() { return new ReadOnlyCollection<string>(this._files); }
    }
}
