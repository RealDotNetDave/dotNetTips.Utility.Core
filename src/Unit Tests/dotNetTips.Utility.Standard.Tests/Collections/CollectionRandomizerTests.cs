using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Collections;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Collections
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CollectionRandomizerTests
    {

        [TestMethod]
        public void GetNextRepeatTest()
        {
            const int count = 10;
            var collection = RandomData.GeneratePersonCollection<PersonProper>(count);
            var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection, true);

            var counter = 0;

            do
            {
                var item = collectionRandomizer.GetNext();

                counter++;

                Debug.WriteLine(item.ToString());

            } while (counter < 55);

            Assert.IsTrue(55 == counter);
        }
        [TestMethod]
        public void GetNextTest()
        {
            const int count = 10;
            var collection = RandomData.GeneratePersonCollection<PersonProper>(count);
            var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection);

            var counter = 0;

            do
            {
                var item = collectionRandomizer.GetNext();

                counter++;

                Debug.WriteLine(item.ToString());

            } while (collectionRandomizer.HasRemainingItems);

            Assert.IsTrue(count == counter);
        }

        [TestMethod]
        public void NullCollectionTest()
        {
            List<PersonProper> collection = new List<PersonProper>();
            var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection);

            Assert.ThrowsException<NullReferenceException>(collectionRandomizer.GetNext);

        }
    }
}
