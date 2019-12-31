// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2019
// ***********************************************************************
// <copyright file="FileProcessorPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Tips.Utility.Standard;
using dotNetTips.Utility.Standard.Collections;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(FileProcessor))]
    public class FileProcessorPerfTestRunner : PerfTestRunner
    {
        private readonly DistinctBlockingCollection<string> _filesToDelete = new DistinctBlockingCollection<string>();

        private int _fileCount = 1000;
        private int _fileLength = 500;

        private IEnumerable<FileInfo> _tempFiles;

        private DirectoryInfo _tempFolder = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TMP.ToString()), "_dotNetTipsBenchmarkTest"));

        public override void Cleanup()
        {
            base.Cleanup();

            _ = FileHelper.DeleteFiles(_tempFiles.Select(p => p.FullName));

            _ = FileHelper.DeleteFiles(_filesToDelete);
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
        [Benchmark(Description = nameof(FileProcessor.CopyFiles))]
        public void TestCopyFilesWithEvent()
        {
            var processor = new FileProcessor();

            processor.Processed += this.Processor_Processed;

            processor.CopyFiles(_tempFiles, new DirectoryInfo(Path.GetTempPath()));

            processor.Processed -= this.Processor_Processed;
        }

        [Benchmark(Description = nameof(FileProcessor.DeleteFiles))]
        public void TestDeleteFilesWithEvent()
        {
            var tempFiles = RandomData.GenerateFiles(_fileCount, _fileLength);

            var processor = new FileProcessor();

            processor.Processed += this.Processor_Processed;

            _ = processor.DeleteFiles(_tempFiles);

            processor.Processed -= this.Processor_Processed;
        }

        [Benchmark(Description = nameof(FileProcessor.DeleteFolders))]
        public void TestDeleteFoldersWithEvent()
        {
            const int Capacity = 100;
            var tempFolder = Path.GetTempPath();

            var directories = new List<DirectoryInfo>(Capacity);

            for (int directoryCount = 0; directoryCount < Capacity; directoryCount++)
            {
                directories.Add(Directory.CreateDirectory(Path.Combine(tempFolder, RandomData.GenerateWord(15, 'A', 'Z'))));
            }

            var processor = new FileProcessor();

            processor.Processed += this.Processor_Processed;

            _ = processor.DeleteFolders(directories);

            processor.Processed -= this.Processor_Processed;
        }

        private IEnumerable<FileInfo> GenerateTempFiles()
        {
            var result = RandomData.GenerateFiles(_tempFolder.FullName, _fileCount, _fileLength);

            var tempFiles = new List<FileInfo>(_fileCount);

            tempFiles.AddRange(result.Select(file => new FileInfo(file)));

            return tempFiles;
        }

        private void Processor_Processed(object sender, FileProgressEventArgs e)
        {
            base.Consumer.Consume(e.Message);

            this._filesToDelete.Add(e.Name);
        }

    }
}
