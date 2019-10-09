// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-10-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
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
        const int TestCount = 100;

        /// <summary>
        /// Adds the items to cache.
        /// </summary>
        [TestMethod]
        public void AddItemsToCache()
        {
            var cache = InMemoryCache.Instance;

            for (int i = 0; i < TestCount; i++)
            {
                cache.AddCacheItem<int>(RandomData.GenerateKey(), RandomData.GenerateInteger(i, 1000000));
            }

            Assert.IsTrue(cache.Count == TestCount);

        }
    }
}
