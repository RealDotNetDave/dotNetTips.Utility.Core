// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="FileHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Tips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(FileHelper))]
    public class FileHelperPerfTestRunner : PerfTestRunner
    {

        private readonly int _fileCount = 100;
        private readonly int _fileLength = 1024;

        private readonly DirectoryInfo _tempFolder = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TMP.ToString()), "_dotNetTipsBenchmarkTest"));

        private IEnumerable<FileInfo> _tempFiles;

        public override void Cleanup()
        {
            base.Cleanup();

            FileHelper.DeleteFiles(this._tempFiles.Select(p => p.FullName));
        }

        [Benchmark(Description = nameof(FileHelper.CopyFileAsync))]
        public async Task CopyFileAsyncTest()
        {
            DirectoryInfo destPath = this._tempFolder;

            FileInfo tempFile = this._tempFiles.PickRandom();

            var result = await FileHelper.CopyFileAsync(tempFile, destPath).ConfigureAwait(false);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(FileHelper.CopyFile))]
        public void CopyFileTest()
        {
            DirectoryInfo destPath = this._tempFolder;

            FileInfo tempFile = this._tempFiles.PickRandom();

            var result = FileHelper.CopyFile(tempFile, destPath);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(FileHelper.DeleteFiles))]
        public void DeleteFilesTest()
        {
            (string Path, IEnumerable<string> Files) files = RandomData.GenerateFiles(100, 10);

            IEnumerable<(string FileName, string ErrorMessage)> errors = FileHelper.DeleteFiles(files.Files);

            base.Consumer.Consume(errors);

        }

        [Benchmark(Description = nameof(FileHelper.FileHasInvalidChars))]
        public void FileHasInvalidCharsTest()
        {
            var destFile = RandomData.GenerateRandomFileName();

            base.Consumer.Consume(FileHelper.FileHasInvalidChars(destFile));
        }

        [Benchmark(Description = nameof(FileHelper.MoveFile))]
        public void MoveFileTest()
        {
            var destFile = RandomData.GenerateRandomFileName();
            var tempFile = RandomData.GenerateTempFile(this._fileLength);

            FileHelper.MoveFile(tempFile, destFile);
        }

        public override void Setup()
        {
            base.Setup();

            this._tempFolder.Create();

            ConsoleLogger.Default.WriteLine(LogKind.Info, $"Temp Folder: {this._tempFolder}.");

            // Copy files for test
            this._tempFiles = this.GenerateTempFiles();

            ConsoleLogger.Default.WriteLine(LogKind.Info, $"Files Copied: {this._tempFiles.Count()}.");

        }

        private IEnumerable<FileInfo> GenerateTempFiles()
        {
            var files = new List<FileInfo>(this._fileCount);

            for (var fileCount = 0; fileCount < this._fileCount; fileCount++)
            {
                files.Add(new FileInfo(RandomData.GenerateTempFile(this._fileLength)));
            }

            return files.AsEnumerable();
        }

    }
}
