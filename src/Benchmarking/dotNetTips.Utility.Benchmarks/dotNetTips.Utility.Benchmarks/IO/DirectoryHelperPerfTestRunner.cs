// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 07-16-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="DirectoryHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(DirectoryHelper))]
    public class DirectoryHelperPerfTestRunner : PerfTestRunner
    {

        private const string FileExtension = "DirectoryPerfTest.temp";
        private string _tempFilePath;
        private IEnumerable<string> _tempFiles;

        public override void Cleanup()
        {
            base.Cleanup();

            FileHelper.DeleteFiles(_tempFiles);
        }

        public override void Setup()
        {
            base.Setup();

            var result = RandomData.GenerateFiles(count: 1000, fileLength: 1000, FileExtension);

            _tempFiles = result.Files;
            _tempFilePath = result.Path;
        }

        //[Benchmark(Description = nameof(DirectoryHelper.LoadOneDriveFolders))]
        //public void TestLoadOneDriveFolders()
        //{
        //    foreach (var folder in DirectoryHelper.LoadOneDriveFolders())
        //    {
        //        var at = folder.AccountType;
        //    }
        //}

        [Benchmark(Description = nameof(DirectoryHelper.LoadFiles))]
        public void TestLoadDirectoryFiles()
        {
            var searchFolders = new List<DirectoryInfo>
            {
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)),
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)),
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            };

            foreach (var file in DirectoryHelper.LoadFiles(searchFolders, "*.*", SearchOption.AllDirectories))
            {
                base.Consumer.Consume(file);
            }
        }

        [Benchmark(Description = nameof(dotNetTips.Utility.Core.Windows.IO.DirectoryHelper.LoadFilesAsync))]
        public async Task TestLoadDirectoryFilesAsync()
        {
            var searchFolders = new List<DirectoryInfo>
            {
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)),
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)),
                new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            };

            await foreach (var files in dotNetTips.Utility.Core.Windows.IO.DirectoryHelper.LoadFilesAsync(searchFolders, "*.*", SearchOption.AllDirectories))
            {
                foreach (var file in files)
                {
                    base.Consumer.Consume(file);
                }
            }
        }

        [Benchmark(Description = nameof(DirectoryHelper.SafeDirectorySearch))]
        public void TestSafeDirectorySearch()
        {
            var result = DirectoryHelper.SafeDirectorySearch(new DirectoryInfo(_tempFilePath), "*." + FileExtension);

            base.Consumer.Consume(result);
        }

    }
}
