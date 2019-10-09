// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="DirectoryHelperUnitTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.IO
{
    /// <summary>
    /// Class DirectoryHelperUnitTest.
    /// </summary>
    [TestClass]
    public class FileHelperUnitTests
    {
        [TestMethod]
        public async Task CopyFileAsyncTestAsync()
        {
            try
            {
                var options = new EnumerationOptions
                {
                    IgnoreInaccessible = false,
                    RecurseSubdirectories = true,

                };

                var directory =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var fileToCopy = new DirectoryInfo(directory).GetFiles("*.*").Where(p1 => p1.Extension.Equals(".pdb") == false).Where(p1 => p1.Extension.Equals(".dll") == false).Where(p2 => p2.Extension.Equals(".exe") == false).Randomize().FirstOrDefault();

                var result = await FileHelper.CopyFileAsync(fileToCopy, this._tempPath);

                Assert.IsTrue(result > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void DeleteFilesTest()
        {
            try
            {
                var filesToCopy = new DirectoryInfo(Environment.CurrentDirectory).GetFiles("*.*", SearchOption.AllDirectories).Randomize().Take(5);

                var filesCopied = new List<FileInfo>(filesToCopy.Count());

                foreach (var file in filesToCopy)
                {
                    filesCopied.Add(file.CopyTo(Path.Combine(this._tempPath.FullName, file.Name), true));
                }

                var result = FileHelper.DeleteFiles(filesCopied.Select(p => p.FullName));

                Assert.IsTrue(result.Count() == 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void DownloadFileFromTheWebTest()
        {
            try
            {
                const string fileToDownload = @"https://dotnettips.files.wordpress.com/2018/03/cropped-rtw-dotnettips-com-logo05x1.png";

                FileHelper.DownloadFileFromWeb(new Uri(fileToDownload), Path.Combine(this._tempPath.FullName, "dotNetTips.Com.logo.png"));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestInitialize]
        public void Initialize()
        {
            this._tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-FILEHELPER-TEST"));

            if (this._tempPath.Exists == false)
            {
                this._tempPath.Create();
            }
            else
            {
                foreach (var directory in this._tempPath.EnumerateDirectories().ToArray())
                {
                    directory.Delete();
                }

                FileHelper.DeleteFiles(this._tempPath.EnumerateFiles().Select(p => p.FullName));
            }
        }

       private DirectoryInfo _tempPath;
    }
}
