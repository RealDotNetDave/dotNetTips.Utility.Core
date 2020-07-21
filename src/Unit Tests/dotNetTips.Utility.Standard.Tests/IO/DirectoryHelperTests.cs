// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 10-09-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-20-2020
// ***********************************************************************
// <copyright file="DirectoryHelperTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.IO
{
    /// <summary>
    /// Class DirectoryHelperUnitTest.
    /// </summary>
    [TestClass]
    public class DirectoryHelperTests
    {
        /// <summary>
        /// Loads the one drive folders test.
        /// </summary>
        [TestMethod]
        public void LoadOneDriveFoldersTest()
        {
            var folders = dotNetTips.Utility.Core.Windows.IO.DirectoryHelper.LoadOneDriveFolders();

            Assert.IsTrue(folders != null && folders.Count() > 0);
        }

        [TestMethod]
        public void AppDataFolderTest()
        {
            var folder = DirectoryHelper.AppDataFolder();

            Assert.IsTrue(string.IsNullOrEmpty(folder) == false);
        }

        [TestMethod]
        public void CopyAndDeleteDirectoryTest()
        {
            var destinationPath = Path.Combine(this._tempPath.FullName, nameof(CopyAndDeleteDirectoryTest));

            var sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "dotNetTips.com-" + DateTime.Now.Ticks);

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

        //[TestMethod]
        //public async Task LoadFilesAsysncTest()
        //{
        //    var searchFolders = new List<DirectoryInfo>();

        //    try
        //    {
        //        searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
        //        searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)));
        //        searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

        //        var returnCount = 0;

        //        await foreach (var files in dotNetTips.Utility.Core.Windows.IO.DirectoryHelper.LoadFilesAsync(searchFolders, "*.*", SearchOption.AllDirectories))
        //        {
        //            if (files.Count() > 0)
        //            {
        //                returnCount += files.Count();
        //            }
        //        }

        //        Assert.IsTrue(returnCount > 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.Fail(ex.Message);
        //    }
        //}

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
        public void SafeFileSearchTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

                var returnCount = 0;

                foreach (var file in DirectoryHelper.SafeFileSearch(searchFolders, "*.*", SearchOption.AllDirectories))
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
        public void CopyAndMoveDirectoryTest()
        {
            var destinationPath = Path.Combine(this._tempPath.FullName, nameof(CopyAndMoveDirectoryTest));
            var folderToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories().Where(p => p.GetFiles().Count() > 0).Randomize().FirstOrDefault();

            try
            {


                DirectoryHelper.CopyDirectory(folderToCopy.FullName, this._tempPath.FullName, false);
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
            this._tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-DIRECTORYHELPER-TEST"));

            if (this._tempPath.Exists == false)
            {
                this._tempPath.Create();
            }
            else
            {
                var array = this._tempPath.EnumerateDirectories().ToArray();

                foreach (var directory in array)
                {
                    DirectoryHelper.DeleteDirectory(directory.FullName);
                }

                FileHelper.DeleteFiles(this._tempPath.EnumerateFiles().Select(p => p.FullName));
            }
        }

        private DirectoryInfo _tempPath;
    }
}
