// ***********************************************************************
// Assembly         : dotNetTips.Utility.Core.Windows.Tests
// Author           : David McCarter
// Created          : 10-20-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-20-2020
// ***********************************************************************
// <copyright file="TempFileManagerTests.cs" company="dotNetTips.Utility.Core.Windows.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using dotNetTips.Utility.Core.Windows.IO;
using dotNetTips.Utility.Standard.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Core.Windows.Tests
{
    [TestClass]
    public class TempFileManagerTests
    {
        [TestMethod]
        public void CreateFilesTest()
        {
            using (var tfm = new TempFileManager())
            {
                var result = tfm.CreateFiles(10);

                foreach (var file in result)
                {
                    Assert.IsTrue(File.Exists(file));
                }
            }
        }

        [TestMethod]
        public void CreateFileTest()
        {
            using (var tfm = new TempFileManager())
            {
                Assert.IsTrue(File.Exists(tfm.CreateFile()));
            }
        }

        [TestMethod]
        public void DeleteAllFilesTest()
        {
            using (var tfm = new TempFileManager())
            {
                var result = tfm.CreateFiles(10);

                tfm.DeleteAllFiles();

                Assert.IsTrue(tfm.FilesList().Count() == 0);

                foreach (var fileName in result)
                {
                    Assert.IsTrue(File.Exists(fileName) == false);
                }
            }
        }

        [TestMethod]
        public void FilesListTest()
        {
            using (var tfm = new TempFileManager())
            {
                var result = tfm.CreateFiles(10);

                Assert.IsTrue(tfm.FilesList().Count() == 10);
            }
        }
    }
}
