﻿// ***********************************************************************
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
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
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var peopleArray = peopleList.ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();

            // Collection test
            var result1 = peopleList.AddFirst(person);

            Assert.IsTrue(result1.First().Equals(person));
            Assert.IsTrue(peopleList.AddFirst(null).Count == peopleList.Count);
            _ = Assert.ThrowsException<ArgumentReadOnlyException>(() => peopleList.ToReadOnlyCollection().AddFirst(person));

            // Array Test
            var result2 = peopleArray.AddFirst(person);
            PersonProper[] nullArray = default(PersonProper[]);
            Assert.IsTrue(result2.First().Equals(person));
            _ = Assert.ThrowsException<ArgumentNullException>(() => nullArray.AddFirst(null));
            _ = Assert.ThrowsException<ArgumentNullException>(() => result2.AddFirst(null));
            _ = Assert.ThrowsException<ArgumentReadOnlyException>(() => Array.AsReadOnly(result2).AddFirst(person));

        }

        [TestMethod]
        public void AddIfNotExistDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();

            // Test parameters
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(null, newPerson));

            _ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(newPerson.Id, null));

            // Test
            people.AddIfNotExists(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            var readonlyPeople = new ReadOnlyDictionary<string, PersonProper>(people);

            readonlyPeople.AddIfNotExists(newPerson.Id, newPerson);
            Assert.IsTrue(readonlyPeople.Count == 11);
        }

        [TestMethod]
        public void AddIfNotExistsComparerTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;
            var comparer = new PersonProperComparer();
            PersonProperComparer nullComparer = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentException>(() => people.AsReadOnly().AddIfNotExists(person, nullComparer));
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(nullPerson, comparer));
            _ = Assert.ThrowsException<ArgumentException>(() => people.ToReadOnlyCollection().AddIfNotExists(person, comparer));

            // TEST
            people.AddIfNotExists(person, comparer);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(person, comparer);
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

            people.AddIfNotExists();
            Assert.IsTrue(people.Count == 20);

        }

        [TestMethod]
        public void AddIfNotExistsSingleItemTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentException>(() => people.AsReadOnly().AddIfNotExists(person));
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(nullPerson));

            // TEST
            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(person);
            Assert.IsTrue(people.Count == 11);
        }

        [TestMethod]
        public void AddLastTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var peopleArray = peopleList.ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            //Test Parameters
            _ = Assert.ThrowsException<ArgumentException>(() => peopleList.ToReadOnlyCollection().AddLast(nullPerson));
            _ = Assert.ThrowsException<ArgumentException>(() => peopleArray.ToReadOnlyCollection().AddLast(nullPerson));
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddLast(nullPerson));
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleArray.AddLast(nullPerson));

            // Test List
            var result1 = peopleList.AddLast(person);
            Assert.IsTrue(result1.Last().Equals(person));
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddFirst(null));

            // Test Array
            var result2 = peopleArray.AddLast(person);
            Assert.IsTrue(result2.Last().Equals(person));
            Assert.IsTrue(peopleArray.AddLast(null).Length == peopleArray.Length);

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
        public void AreEqualTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

            Assert.IsFalse(people.ToArray().AreEqual(newPeople.ToArray()));
            Assert.IsFalse(people.ToArray().AreEqual(newPeople.ToArray()));
            Assert.IsTrue(people.AreEqual(people));

            //Test Null
            PersonCollection<PersonProper> nullCollection = null;

            Assert.IsTrue(nullCollection.AreEqual(null));
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
            var emptyCollection = new PersonCollection<PersonProper>();
            var coordinate = RandomData.GenerateCoordinate<Coordinate>();

            //Test params
            Assert.IsFalse(collection.ContainsAny());
            Assert.IsFalse(collection.ToArray().ContainsAny());
            Assert.IsFalse(emptyCollection.ContainsAny());

            Assert.IsFalse(collection.ContainsAny(coordinate));

            collection.Add(coordinate);

            Assert.IsTrue(collection.ContainsAny(coordinate));

            Assert.IsTrue(collection.ToArray().ContainsAny(coordinate));
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

            //Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

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

            // Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        [TestMethod]
        public void FirstOrDefaultTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person1 = RandomData.GeneratePerson<PersonProper>();
            var person2 = RandomData.GeneratePerson<PersonProper>();
            people.Add(person1);

            //Test Finding item in collection
            Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
            Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 100, person1).Equals(person1));
        }

        [TestMethod]
        public void FirstOrNullTest()
        {
            var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(10).AsEnumerable();
            var searchValue = coordinates.Last().X;

            //Test Params
            _ = Assert.ThrowsException<ArgumentNullException>(() => coordinates.FirstOrNull(null));

            //Test Finding Days of over 100
            Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
            Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
        }

        [TestMethod]
        public void FromDelimitedStringTest()
        {
            var testValue = ".net, c#, vb, f#";

            //Test
            Assert.IsTrue(testValue.ToDelimitedString(',').HasItems());
            Assert.IsTrue(testValue.ToDelimitedString().HasItems());
        }

        [TestMethod]
        public void GetOrAddTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(null, newPerson));
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(newPerson.Id, nullPerson));

            // TEST
            _ = people.GetOrAdd(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);

            _ = people.GetOrAdd(newPerson.Id, newPerson);
            Assert.IsTrue(people.Count == 11);


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
        public void IndexOfTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var testPerson = peopleList[5];

            //Test Parameters
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(testPerson, null));
            _ = Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(null, new PersonProperComparer()));

            // Test 
            Assert.IsTrue(peopleList.IndexOf(testPerson, new PersonProperComparer()) >= 0);
        }

        [TestMethod]
        public void ListHashCodeTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);

            var result = people.ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToArray().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

            result = people.ToReadOnlyCollection().ListHashCode();

            Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
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
        public void RemoveFirstTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveFirst().Count() == 9);

        }

        [TestMethod]
        public void RemoveLastTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveFirst().Count() == 9);

        }

        [TestMethod]
        public void ToDelimitedStringTest()
        {
            var words = RandomData.GenerateWords(10, 25, 50);

            Assert.IsNotNull(words.ToDelimitedString(','));
        }

        [TestMethod]
        public void ToObservableCollectionTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);

            //Test 
            Assert.IsTrue(people.ToObservableCollection().HasItems());
        }

        [TestMethod]
        public void UpsertDictionaryTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
            var newPerson = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            // Test Parameters
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(null, newPerson));
            _ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(newPerson.Id, nullPerson));

            // Test
            var item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);

            item = people.Upsert(newPerson.Id, newPerson);
            Assert.IsNotNull(item);
            Assert.IsTrue(people.Count == 11);
        }

    }

    public class PersonProperComparer : IEqualityComparer<PersonProper>
    {

        public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] PersonProper obj)
        {
            return obj.Id.GetHashCode();
        }

    }
}
