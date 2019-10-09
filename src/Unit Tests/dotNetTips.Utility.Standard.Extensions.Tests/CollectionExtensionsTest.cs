// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 09-28-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-02-2019
// ***********************************************************************
// <copyright file="CollectionExtensionsTest.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    /// <summary>
    /// Class CollectionExtensionsTest.
    /// </summary>
    [TestClass]
    public class CollectionExtensionsTest
    {
        /// <summary>
        /// Tests the fast any.
        /// </summary>
        [TestMethod]
        public void TestFastAny()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsFalse(people.FastAny(p => p.Age.TotalDays > 100));
        }

        /// <summary>
        /// Tests the fast count.
        /// </summary>
        [TestMethod]
        public void TestFastCount()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        /// <summary>
        /// Defines the test method TestPaging.
        /// </summary>
        /// TODO Edit XML Comment Template for TestPaging
        [TestMethod]
        public void TestPaging()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);
            const int pageCount = 10;
            var peopleCount = 0;
            var loopedCount = 0;

            foreach(var peoplePage in people.Page(pageCount))
            {
                loopedCount++;
                peopleCount += peoplePage.Count();
            }

            Assert.IsTrue(peopleCount == 1000);

            Assert.IsTrue(loopedCount == 100);
        }
    }
}
