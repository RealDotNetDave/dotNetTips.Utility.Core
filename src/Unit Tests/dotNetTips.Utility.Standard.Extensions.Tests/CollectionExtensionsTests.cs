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
using System;
using System.Diagnostics.CodeAnalysis;
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
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CollectionExtensionsTests
    {

        [TestMethod]
        public void AddFirstTest()
        {
            Tester.Collections.PersonCollection<PersonProper> peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper[] peopleArray = peopleList.ToArray();
            PersonProper person = RandomData.GeneratePerson<PersonProper>();

            // Collection test
            System.Collections.Generic.IList<PersonProper> result1 = peopleList.AddFirst(person);

            Assert.IsTrue(result1.First().Equals(person));

            Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddFirst(null));

            // Array Test
            PersonProper[] result2 = peopleArray.AddFirst(person);

            Assert.IsTrue(result2.First().Equals(person));

            Assert.ThrowsException<ArgumentNullException>(() => peopleArray.AddFirst(null));

        }

        [TestMethod]
        public void ListHashCodeTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);

            var result = people.ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToArray().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToReadOnlyCollection().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
        }

        [TestMethod]
        public void RemoveFirstTest()
        {
            PersonProper[] people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            PersonProper[] result = people.RemoveFirst();

            Assert.IsTrue(result.Count() == 9);

        }

        [TestMethod]
        public void AddIfNotExistsSingleItemTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            Assert.ThrowsException<ArgumentException>(() => people.AsReadOnly().AddIfNotExists(person));
            Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(nullPerson));

            // TEST
            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);
        }

        [TestMethod]
        public void AddIfNotExistsMultipleItemTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            Tester.Collections.PersonCollection<PersonProper> newPeople = RandomData.GeneratePersonCollection<PersonProper>(10);

            people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);

            people.AddIfNotExists(newPeople.ToArray());
            Assert.IsTrue(people.Count == 20);
        }

        [TestMethod]
        public void AddLastTest()
        {
            Tester.Collections.PersonCollection<PersonProper> peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper[] peopleArray = peopleList.ToArray();
            PersonProper person = RandomData.GeneratePerson<PersonProper>();

            // Test List
            System.Collections.Generic.IList<PersonProper> result1 = peopleList.AddLast(person);
            Assert.IsTrue(result1.Last().Equals(person));
            Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddFirst(null));

            // Test Array
            PersonProper[] result2 = peopleArray.AddLast(person);
            Assert.IsTrue(result2.Last().Equals(person));
            Assert.ThrowsException<ArgumentNullException>(() => peopleArray.AddFirst(null));

        }

        [TestMethod]
        public void AreEqualTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            Tester.Collections.PersonCollection<PersonProper> newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

            var result = people.ToArray().AreEqual(newPeople.ToArray());

            Assert.IsFalse(result);

            result = people.AreEqual(newPeople);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddRangeListTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            Tester.Collections.PersonCollection<PersonProper> newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

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
            Coordinate coordinate = RandomData.GenerateCoordinate<Coordinate>();

            Assert.IsFalse(collection.ContainsAny(coordinate));

            collection.Add(coordinate);

            Assert.IsTrue(collection.ContainsAny(coordinate));

            Assert.IsTrue(collection.ToArray().ContainsAny(coordinate));
        }


        [TestMethod]
        public void CopyToListTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            System.Collections.Generic.List<PersonProper> newPeople = people.CopyToList();

            Assert.IsTrue(people.Count == newPeople.Count);
        }

        [TestMethod]
        public void CountTest()
        {
            const int count = 10;
            System.Collections.Generic.IEnumerable<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(count).AsEnumerable();

            Assert.IsTrue(people.Count() == count);
        }
        /// <summary>
        /// Tests the fast any.
        /// </summary>
        [TestMethod]
        public void FastAnyTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
        }

        /// <summary>
        /// Tests the fast count.
        /// </summary>
        [TestMethod]
        public void FastCountTest()
        {
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        [TestMethod]
        public void GetOrAddTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            PersonProper newPerson = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd<string, PersonProper>(null, newPerson));
            Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd<string, PersonProper>(newPerson.Id, nullPerson));

            // TEST
            people.GetOrAdd<string, PersonProper>(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            people.GetOrAdd<string, PersonProper>(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);


        }

        [TestMethod]
        public void AddIfNotExistDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            PersonProper newPerson = RandomData.GeneratePerson<PersonProper>();

            // Test parameters
            Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists<string, PersonProper>(null, newPerson));

            Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists<string, PersonProper>(newPerson.Id, null));

            // Test
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
            System.Collections.Generic.IEnumerable<Coordinate> collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

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
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(1000);
            const int pageCount = 10;
            var peopleCount = 0;
            var loopedCount = 0;

            foreach (System.Collections.Generic.IEnumerable<PersonProper> peoplePage in people.Page(pageCount))
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
            System.Collections.Immutable.ImmutableList<string> words = RandomData.GenerateWords(10, 25, 50);

            Assert.IsNotNull(words.ToDelimitedString(','));
        }

        [TestMethod]
        public void UpsertDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            PersonProper newPerson = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(null, newPerson));
            Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(newPerson.Id, nullPerson));

            // Test
            PersonProper item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);

            item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);
        }

    }
}
