// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 06-10-2018
//
// Last Modified By : David McCarter
// Last Modified On : 11-19-2020
// ***********************************************************************
// <copyright file="InMemoryCacheUnitTest.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Cache;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Cache
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class InMemoryCacheUnitTest
    {
        private const int TestCount = 100;

        [TestMethod]
        public void AddItemsToCacheTest()
        {
            var cache = InMemoryCache.Instance;

            for (var count = 0; count < TestCount; count++)
            {
                cache.AddCacheItem<int>(key: RandomData.GenerateKey(), item: RandomData.GenerateInteger(count, 1000000));
            }

            Assert.IsTrue(cache.Count == TestCount);
        }
    }
}
