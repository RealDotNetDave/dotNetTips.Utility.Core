// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 10-09-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-28-2020
// ***********************************************************************
// <copyright file="DirectoryHelperTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Tips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotNetTips.Tips.Utility.Standard.Tests.IO
{

    [TestClass]
    public class DirectoryHelperTests
    {
        private DirectoryInfo _tempPath;

        [TestMethod]
        public void AppDataFolderTest()
        {
            var folder = DirectoryHelper.AppDataFolder();

            Assert.IsTrue(string.IsNullOrEmpty(folder) == false);
        }

        [TestMethod]
        public void CopyAndDeleteDirectoryTest()
        {
            var destinationPath = Path.Combine(_tempPath.FullName, nameof(CopyAndDeleteDirectoryTest));

            var sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                          "dotNetTips.com-" + DateTime.Now.Ticks);

            var generatedFiles = RandomData.GenerateFiles(sourcePath, 500, 5000);

            try
            {
                DirectoryHelper.CopyDirectory(sourcePath, destinationPath, false);

                DirectoryHelper.DeleteDirectory(destinationPath, 3);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                DirectoryHelper.DeleteDirectory(sourcePath, 3);
            }
        }

        [TestMethod]
        public void CopyAndMoveDirectoryTest()
        {
            var destinationPath = Path.Combine(_tempPath.FullName, nameof(CopyAndMoveDirectoryTest));
            var folderToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories()
                .Where(p => p.GetFiles().Count() > 0)
                .Shuffle()
                .FirstOrDefault();

            try
            {
                DirectoryHelper.CopyDirectory(folderToCopy.FullName, _tempPath.FullName, false);
                DirectoryHelper.MoveDirectory(folderToCopy.FullName, destinationPath, 5);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                DirectoryHelper.DeleteDirectory(destinationPath);
            }
        }

        [TestInitialize]
        public void Initialize()
        {
            _tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-DIRECTORYHELPER-TEST"));

            if (_tempPath.Exists == false)
            {
                _tempPath.Create();
            }
            else
            {
                var array = _tempPath.EnumerateDirectories().ToArray();

                foreach (var directory in array)
                {
                    DirectoryHelper.DeleteDirectory(directory.FullName);
                }

                FileHelper.DeleteFiles(_tempPath.EnumerateFiles().Select(p => p.FullName));
            }
        }

        [TestMethod]
        public void LoadFilesTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

                var returnCount = 0;

                foreach (var file in DirectoryHelper.LoadFiles(searchFolders, "*.*", SearchOption.AllDirectories))
                {
                    returnCount++;
                }

                Assert.IsTrue(returnCount > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoadOneDriveFoldersTest()
        {
            var folders = dotNetTips.Utility.Core.Windows.IO.DirectoryHelper.LoadOneDriveFolders();

            Assert.IsTrue(folders != null && folders.Count() > 0);
        }

        [TestMethod]
        public void SafeDirectorySearchTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                searchFolders.Add(new DirectoryInfo(Environment.GetEnvironmentVariable(EnvironmentKey.TEMP.ToString())));

                var directories = new List<DirectoryInfo>();

                foreach (var directory in searchFolders)
                {
                    directories.AddRange(DirectoryHelper.SafeDirectorySearch(directory));
                }

                Assert.IsTrue(directories.Count > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SafeFileSearchTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                searchFolders.Add(new DirectoryInfo(Environment.GetEnvironmentVariable(EnvironmentKey.TEMP.ToString())));


                var searchResult = DirectoryHelper.SafeFileSearch(searchFolders, "*.*", SearchOption.AllDirectories);

                Assert.IsTrue(searchResult.HasItems());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
