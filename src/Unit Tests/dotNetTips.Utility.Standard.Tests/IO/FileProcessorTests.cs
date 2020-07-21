// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 05-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-20-2020
// ***********************************************************************
// <copyright file="FileProcessorTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.IO
{
    [TestClass]
    public class FileProcessorTests
    {
        [TestMethod]
        public void CopyFilesWithEventTest()
        {
            var processor = new FileProcessor();

            processor.Processed += this.Processor_Processed;

            var files = GenerateTempFiles(100, 5000);

            processor.CopyFiles(files, new DirectoryInfo(Path.GetTempPath()));

            processor.Processed -= this.Processor_Processed;
        }

        private void Processor_Processed(object sender, FileProgressEventArgs e)
        {
            Debug.WriteLine(e.Message);

            File.Delete(e.Name);
        }

        private IEnumerable<FileInfo> GenerateTempFiles(int fileCount, int fileLength)
        {
            var result = RandomData.GenerateFiles(_tempFolder.FullName, fileCount, fileLength);

            var tempFiles = new List<FileInfo>(fileCount);

            tempFiles.AddRange(result.Select(file => new FileInfo(file)));

            return tempFiles;
        }

        readonly DirectoryInfo _tempFolder = new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TMP.ToString()), "_dotNetTipsUnitTest"));
    }
}