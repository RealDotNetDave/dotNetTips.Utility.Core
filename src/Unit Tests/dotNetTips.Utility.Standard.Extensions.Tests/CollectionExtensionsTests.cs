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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
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
            PersonProper[] peopleArray = peopleList.ToArray();
            PersonProper person = RandomData.GeneratePerson<PersonProper>();


            // Collection test
            var result1 = peopleList.AddFirst(person);

            Assert.IsTrue(result1.First().Equals(person));
            Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddFirst(null));
            Assert.ThrowsException<ArgumentException>(() => peopleList.ToReadOnlyCollection().AddFirst(person));

            // Array Test
            PersonProper[] result2 = peopleArray.AddFirst(person);

            Assert.IsTrue(result2.First().Equals(person));
            Assert.ThrowsException<ArgumentNullException>(() => peopleArray.AddFirst(null));
            Assert.ThrowsException<ArgumentException>(() => Array.AsReadOnly<PersonProper>(peopleArray).AddFirst(person));

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

            var readonlyPeople = new ReadOnlyDictionary<string, PersonProper>(people);

            readonlyPeople.AddIfNotExists(newPerson.Id, newPerson);
            Assert.IsTrue(readonlyPeople.Count == 11);
        }

        [TestMethod]
        public void AddIfNotExistsComparerTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;
            PersonProperComparer comparer = new PersonProperComparer();
            PersonProperComparer nullComparer = null;

            // Test Parameters
            Assert.ThrowsException<ArgumentException>(() => people.AsReadOnly().AddIfNotExists(person, nullComparer));
            Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(nullPerson, comparer));
            Assert.ThrowsException<ArgumentException>(() => people.ToReadOnlyCollection().AddIfNotExists(person, comparer));

            // TEST
            people.AddIfNotExists(person, comparer);
            Assert.IsTrue(people.Count == 11);

            people.AddIfNotExists(person, comparer);
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

            people.AddIfNotExists();
            Assert.IsTrue(people.Count == 20);

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
        public void AddLastTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            var peopleArray = peopleList.ToArray();
            var person = RandomData.GeneratePerson<PersonProper>();
            PersonProper nullPerson = null;

            //Test Parameters
            Assert.ThrowsException<ArgumentException>(() => peopleList.ToReadOnlyCollection().AddLast(nullPerson));
            Assert.ThrowsException<ArgumentException>(() => peopleArray.ToReadOnlyCollection().AddLast(nullPerson));
            Assert.ThrowsException<ArgumentNullException>(() => peopleList.AddLast(nullPerson));
            Assert.ThrowsException<ArgumentNullException>(() => peopleArray.AddLast(nullPerson));

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
            Tester.Collections.PersonCollection<PersonProper> people = RandomData.GeneratePersonCollection<PersonProper>(10);
            Tester.Collections.PersonCollection<PersonProper> newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

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
            Coordinate coordinate = RandomData.GenerateCoordinate<Coordinate>();

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
            var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

            //Test Params
            Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

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
            Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

            //Test Finding Days of over 100
            Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
        }

        [TestMethod]
        public void FirstOrDefaultTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);
            var person1 = RandomData.GeneratePerson<PersonProper>();
            var person2 = RandomData.GeneratePerson<PersonProper>();

            //Test Params
            Assert.ThrowsException<ArgumentNullException>(() => people.FirstOrDefault(null));
            Assert.ThrowsException<ArgumentNullException>(() => people.FirstOrDefault(null, person1));
            Assert.ThrowsException<ArgumentNullException>(() => people.FirstOrDefault(p => p.Age.TotalDays > 100, null));

            //Test Finding Days of over 100
            Assert.IsTrue(people.FirstOrDefault(person1) == person1);
            Assert.IsTrue(people.FirstOrDefault(p => p.Age.TotalDays > 100, person1).Equals(person1));
        }

        [TestMethod]
        public void FirstOrNullTest()
        {
            var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(10).AsEnumerable();
            var searchValue = coordinates.Last().X;

            //Test Params
            Assert.ThrowsException<ArgumentNullException>(() => coordinates.FirstOrNull(null));

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
        public void IndexOfTest()
        {
            var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
            PersonProper testPerson = peopleList[5];

            //Test Parameters
            Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(testPerson, null));
            Assert.ThrowsException<ArgumentNullException>(() => peopleList.IndexOf(null, new PersonProperComparer()));

            // Test 
            Assert.IsTrue(peopleList.IndexOf(testPerson, new PersonProperComparer()) >= 0);
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
        public void RemoveFirstTest()
        {
            PersonProper[] people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveFirst().Count() == 9);

        }

        [TestMethod]
        public void RemoveLastTest()
        {
            PersonProper[] people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

            Assert.IsTrue(people.RemoveFirst().Count() == 9);

        }

        [TestMethod]
        public void ToDelimitedStringTest()
        {
            System.Collections.Immutable.ImmutableList<string> words = RandomData.GenerateWords(10, 25, 50);

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
