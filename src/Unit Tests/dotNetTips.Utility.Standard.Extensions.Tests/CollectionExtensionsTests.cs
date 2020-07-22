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
using System.Linq;
using System.Text;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    /// <summary>
    /// Class CollectionExtensionsTest.
    /// </summary>
    [TestClass]
    public class CollectionExtensionsTests
    {

        [TestMethod]
        public void AddFirstTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddFirst(person);

            Assert.IsTrue(result.First().Equals(person));

        }

        [TestMethod]
        public void RemoveFirstTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            var result = people.RemoveFirst();

            Assert.IsTrue(result.Count() == 9);

        }

        [TestMethod]
        public void AddIfNotExistsSingleItemTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();

            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);
        }

        [TestMethod]
        public void AddIfNotExistsMultipleItemTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(10);

            people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);

            people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);
        }

        [TestMethod]
        public void AddLastTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddLast(person);

            Assert.IsTrue(result.Last().Equals(person));

        }

        [TestMethod]
        public void AreEqualTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

            var result = people.ToArray().AreEqual(newPeople.ToArray());

            Assert.IsFalse(result);

            result = people.AreEqual(newPeople);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddRangeListTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

            people.AddRange(newPeople);

            Assert.IsTrue(people.Count == 12);

            people.AddRange(newPeople, true);

            Assert.IsTrue(people.Count == 12);
        }

        [TestMethod]
        public void BytesToStringTest()
        {

            // ComputeHash - returns byte array  
            var bytes = Encoding.UTF8.GetBytes("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            // Convert byte array to a string   
            var result = bytes.BytesToString();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToList();
            var coordinate = RandomData.GenerateCoordinate<Coordinate>();

            Assert.IsFalse(collection.ContainsAny(coordinate));

            collection.Add(coordinate);

            Assert.IsTrue(collection.ContainsAny(coordinate));
        }


        [TestMethod]
        public void CopyToListTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = people.CopyToList();

            Assert.IsTrue(people.Count == newPeople.Count);
        }

        [TestMethod]
        public void CountTest()
        {
            const int count = 10;
            var people = RandomData.GeneratePersonCollection<PersonProper>(count).AsEnumerable();

            Assert.IsTrue(people.Count() == count);
        }
        /// <summary>
        /// Tests the fast any.
        /// </summary>
        [TestMethod]
        public void FastAnyTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
        }

        /// <summary>
        /// Tests the fast count.
        /// </summary>
        [TestMethod]
        public void FastCountTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        [TestMethod]
        public void GetOrAddTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();

            people.GetOrAdd<string, PersonProper>(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);
        }

        [TestMethod]
        public void AddIfNotExistDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();

            people.AddIfNotExists<string, PersonProper>(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists<string, PersonProper>(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);
        }

        [TestMethod]
        public void AddRangeDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2).ToDictionary(p => p.Id);

            people.AddRange(newPeople);
            Assert.IsTrue(people.Count == 12);

            people.AddRange(newPeople, true);
            Assert.IsTrue(people.Count == 12);
        }

        [TestMethod]
        public void HasItemsTest()
        {
            var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

            Assert.IsTrue(collection.HasItems());

            Assert.IsTrue(collection.HasItems(10));

            Assert.IsTrue(collection.ToObservableCollection().HasItems());

            Assert.IsTrue(collection.ToObservableCollection().HasItems(10));

            Assert.IsTrue(collection.ToList().HasItems());

            Assert.IsTrue(collection.ToList().HasItems(10));

            Assert.IsFalse(collection.ToList().HasItems(p => p.X == 999999999));
        }

        [TestMethod]
        public void PagingTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);
            const int pageCount = 10;
            var peopleCount = 0;
            var loopedCount = 0;

            foreach (var peoplePage in people.Page(pageCount))
            {
                loopedCount++;
                peopleCount += peoplePage.Count();
            }

            Assert.IsTrue(peopleCount == 1000);

            Assert.IsTrue(loopedCount == 100);
        }

        [TestMethod]
        public void ToDelimitedStringTest()
        {
            var words = RandomData.GenerateWords(10, 25, 50);

            Assert.IsNotNull(words.ToDelimitedString(','));
        }

        [TestMethod]
        public void UpsertDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();

            var item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);

            item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);
        }

    }
}
