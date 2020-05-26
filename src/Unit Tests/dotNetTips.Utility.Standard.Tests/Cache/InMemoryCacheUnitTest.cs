// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-10-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-09-2020
// ***********************************************************************
// <copyright file="InMemoryCacheUnitTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Cache;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Cache
{
    /// <summary>
    /// Class InMemoryCacheUnitTest.
    /// </summary>
    [TestClass]
    public class InMemoryCacheUnitTest
    {
        /// <summary>
        /// The test count
        /// </summary>
        private const int _testCount = 100;

        /// <summary>
        /// Adds the items to cache.
        /// </summary>
        [TestMethod]
        public void AddItemsToCachTest()
        {
            var cache = InMemoryCache.Instance;

            for (int count = 0; count < _testCount; count++)
            {
                cache.AddCacheItem<int>(key: RandomData.GenerateKey(), item: RandomData.GenerateInteger(count, 1000000));
            }

            Assert.IsTrue(cache.Count == _testCount);
        }
    }
}
