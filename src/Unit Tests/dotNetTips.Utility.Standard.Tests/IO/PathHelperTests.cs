// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 11-21-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-20-2020
// ***********************************************************************
// <copyright file="PathHelperTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.IO.Tests
{
    [TestClass()]
    public class PathHelperTests
    {

        [TestMethod()]
        public void EnsureTrailingSlashTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.EnsureTrailingSlash(path);

            Assert.IsTrue(result.EndsWith(Path.DirectorySeparatorChar));

            result = PathHelper.EnsureTrailingSlash(@"C:\Windows\");

            Assert.IsTrue(result.EndsWith(Path.DirectorySeparatorChar));
        }

        [TestMethod]
        public void InvalidFilterCharsTest()
        {
            var result = PathHelper.InvalidFilterChars;

            Assert.IsTrue(result.Count() > 0);
        }

        [TestMethod]
        public void InvalidPathNameCharsTest()
        {
            var result = PathHelper.InvalidPathNameChars;

            Assert.IsTrue(result.Count() > 0);
        }

        [TestMethod]
        public void PathSeparatorsTest()
        {
            var result = PathHelper.PathSeparators;

            Assert.IsTrue(result.Count() > 0);
        }


        [TestMethod()]
        public void HasInvalidFilterCharsTest()
        {
            var filter = "*.*";

            var result = PathHelper.HasInvalidFilterChars(filter);

            Assert.IsFalse(result);

            //Test invalid filter
            filter = $":";

            result = PathHelper.HasInvalidFilterChars(filter);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void PathContainsWildcardTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.PathContainsWildcard(path);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PathHasInvalidCharsTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.PathHasInvalidChars(path);

            Assert.IsFalse(result);

            //Test invalid path name
            path = $"{path}|";

            result = PathHelper.PathHasInvalidChars(path);

            Assert.IsTrue(result);
        }

    }
}