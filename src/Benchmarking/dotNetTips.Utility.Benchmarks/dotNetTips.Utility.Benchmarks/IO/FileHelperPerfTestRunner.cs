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
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Tips.Utility.Standard;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(FileHelper))]
    public class FileHelperPerfTestRunner : PerfTestRunner
    {

        private int _fileCount = 100;
        private int _fileLength = 1024;

        private IEnumerable<FileInfo> _tempFiles;

        private DirectoryInfo _tempFolder = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TMP.ToString()), "_dotNetTipsBenchmarkTest"));

        public override void Cleanup()
        {
            base.Cleanup();

            FileHelper.DeleteFiles(_tempFiles.Select(p => p.FullName));
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

        [Benchmark(Description = nameof(FileHelper.CopyFile))]
        public void TestCopyFile()
        {
            var destPath = this._tempFolder;

            var tempFile = this._tempFiles.PickRandom(1).SingleOrDefault();

            var result = FileHelper.CopyFile(tempFile, destPath);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(FileHelper.CopyFileAsync))]
        public async Task TestCopyFileAsync()
        {
            var destPath = this._tempFolder;

            var tempFile = this._tempFiles.PickRandom(1).SingleOrDefault();

            var result = await FileHelper.CopyFileAsync(tempFile, destPath).ConfigureAwait(false);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(FileHelper.DeleteFiles))]
        public void TestDeleteFiles()
        {
            var files = RandomData.GenerateFiles(100, 10);

            var errors = FileHelper.DeleteFiles(files.Files);

            base.Consumer.Consume(errors);

        }

        [Benchmark(Description = nameof(FileHelper.MoveFile))]
        public void TestMoveFile()
        {
            var destFile = RandomData.GenerateRandomFileName();
            var tempFile = RandomData.GenerateTempFile(this._fileLength);

            FileHelper.MoveFile(tempFile, destFile);
        }

        private IEnumerable<FileInfo> GenerateTempFiles()
        {
            var files = new List<FileInfo>(this._fileCount);

            for (int fileCount = 0; fileCount < this._fileCount; fileCount++)
            {
                files.Add(new FileInfo(RandomData.GenerateTempFile(this._fileLength)));
            }

            return files.AsEnumerable();
        }

    }
}
