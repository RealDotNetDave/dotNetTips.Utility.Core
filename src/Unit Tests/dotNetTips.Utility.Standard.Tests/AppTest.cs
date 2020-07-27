// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-20-2018
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2020
// ***********************************************************************
// <copyright file="AppTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using dotNetTips.Utility.Standard;
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
        public void LoadingAppInfoTest()
        {
            AppInfo info = App.AppInfo;

            Assert.IsTrue(string.IsNullOrEmpty(info.FileVersion) == false);
            Assert.IsTrue(string.IsNullOrEmpty(info.Version) == false);
        }

        /// <summary>
        /// Tests the loading environment variables.
        /// </summary>
        [TestMethod]
        public void LoadingEnvironmentVariablesTest()
        {
            System.Collections.Immutable.IImmutableDictionary<string, string> variables = App.GetEnvironmentVariables();

            Assert.IsNotNull(variables);

            Assert.IsTrue(variables.Count > 0);

            foreach (System.Collections.Generic.KeyValuePair<string, string> variable in variables)
            {
                Debug.WriteLine($"{variable.Key}:{variable.Value}");
            }
        }

        /// <summary>
        /// Tests the loading environment variable.
        /// </summary>
        [TestMethod]
        public void LoadingEnvironmentVariableTest()
        {
            var variables = App.GetEnvironmentVariables();

            Assert.IsTrue(variables.ContainsKey(EnvironmentKey.Path.ToString()));
        }

        [TestMethod]
        public void ExecutingFolderTest()
        {
            var result = App.ExecutingFolder();

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }
    }
}
