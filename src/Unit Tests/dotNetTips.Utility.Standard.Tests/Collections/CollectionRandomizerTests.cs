using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Utility.Standard.Collections;
using dotNetTips.Utility.Standard.Common;
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

            while (collectionRandomizer.MoveNext() && counter < 55)
            {
	            var item = collectionRandomizer.Current;
	            Debug.WriteLine(item.ToString());
	            counter++;
            }

            Assert.AreEqual(55, counter);
        }
        [TestMethod]
        public void GetNextTest()
        {
            const int count = 10;
            var collection = RandomData.GeneratePersonCollection<PersonProper>(count);
            var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection);

            var counter = 0;

            while(collectionRandomizer.MoveNext())
            {
	            var item = collectionRandomizer.Current;

				counter++;

                Debug.WriteLine(item.ToString());

            } 

            Assert.AreEqual(count,counter);
        }

        [TestMethod]
        public void NullCollectionTest()
        {
			var collection = new List<PersonProper>();
            Assert.ThrowsException<ArgumentInvalidException>(()=>new CollectionRandomizer<PersonProper>(collection));

        }

        [TestMethod]
        public void RepeatCountTest()
        {
	        const int count = 10;
	        const int repeatCnt = 3;
	        const int total = count * repeatCnt;
	        var collection = RandomData.GeneratePersonCollection<PersonProper>(count);
	        var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection, repeatCnt);

	        var counter = 0;

			foreach(var item in collectionRandomizer)
	        {
		        Debug.WriteLine(item.Email);
		        counter++;
	        }

	        Assert.AreEqual(total,counter);
        }

        [TestMethod]
        public void ShuffleTest()
        {
	        const int count = 10;
	        const int repeatCnt = 2;

	        var collection = RandomData.GeneratePersonCollection<PersonProper>(count);
	        var collectionRandomizer = new CollectionRandomizer<PersonProper>(collection, repeatCnt);

	        var list1 = new List<PersonProper>(collectionRandomizer.Take(count));
	        var list2 = new List<PersonProper>(collectionRandomizer.Take(count));

			Assert.IsFalse(list1.SequenceEqual(list2));

			// Unshuffle to see if they started the same
			list1.Sort();
			list2.Sort();
			Assert.IsTrue(list1.SequenceEqual(list2));
        }


	}
}
