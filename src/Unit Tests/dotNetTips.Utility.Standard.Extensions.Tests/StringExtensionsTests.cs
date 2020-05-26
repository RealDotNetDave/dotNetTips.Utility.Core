// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 05-07-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2020
// ***********************************************************************
// <copyright file="StringExtensionsTests.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {

        [TestMethod]
        public void HasValueTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.HasValue());

            Assert.IsTrue(testValue.HasValue(10));

            Assert.IsFalse(testValue.HasValue("XXXXX"));
        }

        [TestMethod]
        public void ComputeMD5HashTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeMD5Hash()) == false);
        }

        [TestMethod]
        public void ComputeSha256HashTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeSha256Hash()) == false);
        }

        [TestMethod]
        public void ConcatTest()
        {
            var testValue1 = RandomData.GenerateWord(10);
            var testValue2 = RandomData.GenerateWord(15);

            Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", false, testValue2)) == false);
            Assert.IsTrue(testValue1.Concat("-", false, testValue2).Length == 26);
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            var testValue = "dotNetTips.com";

            Assert.IsTrue(testValue.ContainsAny("d", "T"));
        }

        [TestMethod]
        public void DefaultIfNullTest()
        {
            string testValue = null;

            Assert.IsTrue(testValue.DefaultIfNull().Length == 0);

            Assert.IsTrue(testValue.DefaultIfNull(RandomData.GenerateWord(5)).Length == 5);

        }

        [TestMethod]
        public void DefaultIfNullOrEmptyTest()
        {
            string testValue = null;

            Assert.IsTrue(testValue.DefaultIfNullOrEmpty(RandomData.GenerateWord(5)).Length == 5);
        }

        [TestMethod]
        public void IndentTest()
        {
            var testValue = RandomData.GenerateWord(100);

            var result = testValue.Indent(2, '>');

            Assert.IsTrue(result.Length > 100);
        }

        [TestMethod]
        public void ReplaceEllipsisWithPeriodTest()
        {
            var testValue = RandomData.GenerateWord(25) + "...";

            var result = testValue.ReplaceEllipsisWithPeriod();

            Assert.IsTrue(result.EndsWith("...") == false);
        }

        [TestMethod]
        public void SplitTest()
        {
            var testValue = RandomData.GenerateWord(25) + ',' + RandomData.GenerateWord(25);

            Assert.IsTrue(testValue.Split(',').Count() == 2);
        }

        [TestMethod]
        public void TrimTest()
        {
            var testValue = RandomData.GenerateWord(25) + "   ";

            Assert.IsTrue(testValue.ToTrimmedString().Length == 25);
        }
    }
}
