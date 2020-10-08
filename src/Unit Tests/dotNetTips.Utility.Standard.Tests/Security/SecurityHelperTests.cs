// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 10-07-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-07-2020
// ***********************************************************************
// <copyright file="SecurityHelperTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Security;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Security
{
    [TestClass]
    public class SecurityHelperTests
    {
        [TestMethod]
        public void LoadSecureStringTest01()
        {
            var testString = RandomData.GenerateWord(10, 100);

            using (var secureString = SecurityHelper.LoadSecureString(testString))
            {
                Assert.IsNotNull(secureString);

                Assert.IsTrue(secureString.Length >= 10);

                Assert.IsFalse(secureString.IsReadOnly());
            }
        }

        [TestMethod]
        public void LoadSecureStringTest02()
        {
            var testString = RandomData.GenerateWord(10, 100);

            using (var secureString = SecurityHelper.LoadSecureString(testString, true))
            {
                Assert.IsNotNull(secureString);

                Assert.IsTrue(secureString.Length >= 10);

                Assert.IsTrue(secureString.IsReadOnly());
            }
        }

        [TestMethod]
        public void ReadSecureStringTest01()
        {
            var testString = RandomData.GenerateWord(10, 100);

            using (var secureString = SecurityHelper.LoadSecureString(testString, true))
            {
                var convertedString = SecurityHelper.ReadSecureString(secureString);

                Assert.IsNotNull(convertedString);

                Assert.IsTrue(convertedString.Length >= 10);

                Assert.IsTrue(testString == convertedString);
            }
        }

        [TestMethod]
        public void CompareSecureStringTest01()
        {
            var testString = RandomData.GenerateWord(10, 100);

            using (var secureString1 = SecurityHelper.LoadSecureString(testString, true))
            {
                using (var secureString2 = SecurityHelper.LoadSecureString(testString))
                {
                    Assert.IsTrue(SecurityHelper.CompareSecureStrings(secureString1, secureString2));
                }
            }
        }
    }
}
