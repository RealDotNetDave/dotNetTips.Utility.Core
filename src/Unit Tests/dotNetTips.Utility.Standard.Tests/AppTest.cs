// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-20-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="AppTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests
{
    /// <summary>
    /// Class AppTest.
    /// </summary>
    [TestClass]
    public class AppTest
    {
        /// <summary>
        /// Tests the loading application information.
        /// </summary>
        [TestMethod]
        public void TestLoadingAppInfo()
        {
            var info = App.AppInfo;

            Assert.IsTrue(info.FileVersion.HasItems());
            Assert.IsTrue(info.Version.HasItems());
        }

        /// <summary>
        /// Tests the loading environment variables.
        /// </summary>
        [TestMethod]
        public void TestLoadingEnvironmentVariables()
        {
            var variables = App.GetEnvironmentVariables();

            Assert.IsNotNull(variables);

            Assert.IsTrue(variables.Count > 0);

            foreach (var variable in variables)
            {
                Debug.WriteLine($"{variable.Key}:{variable.Value}");
            }
        }

        /// <summary>
        /// Tests the loading environment variable.
        /// </summary>
        [TestMethod]
        public void TestLoadingEnvironmentVariable()
        {
            var variables = App.GetEnvironmentVariables();

            Assert.IsTrue(variables.ContainsKey(EnvironmentKey.Path.ToString()));
        }
    }
}
