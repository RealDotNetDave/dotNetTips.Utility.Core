// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="CollectionExtensionsPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using CollectionExtensions = dotNetTips.Utility.Standard.Extensions.CollectionExtensions;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(CollectionExtensions))]
    public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
    {

        [Benchmark(Description = nameof(CollectionExtensions.AddFirst) + ":Array")]
        public void AddFirstToArray()
        {
            var people = base.personProperArrayFull.Clone<PersonProper>();

            var result = people.AddFirst(RandomData.GeneratePerson<PersonProper>());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Parm Array")]
        public void AddIfNotExistsCollection01()
        {
            var people = new List<PersonProper>(base.personProperCollection);
            var newPeople = new List<PersonProper>(base.personProperCollection).Take(10).ToArray();


            var result = people.AddIfNotExists(newPeople);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Dup Parm Array")]
        public void AddIfNotExistsCollection02()
        {
            var people = new List<PersonProper>(base.personProperCollection);
            var newPeople = people.Shuffle(10).ToArray();


            var result = people.AddIfNotExists(newPeople);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Comparer")]
        public void AddIfNotExistsComparer()
        {
            var people = new List<PersonProper>(base.CollectionCount);
            var comparer = new PersonProperComparer();

            foreach (var person in base.personProperCollection)
            {
                people.AddIfNotExists(person, comparer);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Dictionary")]
        public void AddIfNotExistsDictionary()
        {
            var people = new Dictionary<string, PersonProper>(base.CollectionCount);

            foreach (var person in base.personProperDictionary)
            {
                people.AddIfNotExists(person.Key, person.Value);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Param Array")]
        public void AddIfNotExistsParamArray()
        {
            var people = new List<PersonProper>(CollectionCount / 2);

            people.AddIfNotExists(base.personProperArrayHalf);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Single")]
        public void AddIfNotExistsSingle()
        {
            var people = new List<PersonProper>(base.CollectionCount);

            foreach (var person in base.personProperCollection)
            {
                people.AddIfNotExists(person);
            }

            base.Consumer.Consume(people);
        }


        [Benchmark(Description = nameof(CollectionExtensions.AddLast) + ":Array")]
        public void AddLastToArray()
        {
            var people = base.personProperArrayFull.Clone<PersonProper>();
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddLast(person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddLast) + ":List")]
        public void AddLastToList()
        {
            var people = base.personProperCollection.CopyToList();
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.AddLast(person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddRange))]
        public void AddRange()
        {
            var people = new List<PersonProper>();

            CollectionExtensions.AddRange(people, base.personProperCollection.Take(base.CollectionCount / 10), true);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AreEqual) + ":Array")]
        public void AreEqualArray()
        {
            var result = base.personProperArrayFull.AreEqual(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AreEqual) + ":List")]
        public void AreEqualList()
        {
            var result = base.personProperCollection.AreEqual(base.personProperListHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.BytesToString))]
        public void BytesToString()
        {
            var result = base.byteArray.BytesToString();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ClearNulls))]
        public void ClearNulls()
        {
            var people = base.personProperCollection;
            people.Add(null);

            var result = people.ClearNulls();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Clone))]
        public void Clone()
        {
            var result = base.personProperCollection.Clone<PersonCollection<PersonProper>>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ContainsAny) + ":Array")]
        public void ContainsAnyArray()
        {
            var people = base.personProperArrayFull.Take(base.CollectionCount / 10).ToList();
            people.Add(RandomData.GeneratePerson<PersonProper>());

            var result = base.personProperArrayFull.ContainsAny(people.ToArray());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ContainsAny) + ":List")]
        public void ContainsAnyList()
        {
            var people = base.personProperCollection.Take(base.CollectionCount / 10).ToList();
            people.Add(RandomData.GeneratePerson<PersonProper>());

            var result = base.personProperCollection.ContainsAny(people.ToArray());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.CopyToList))]
        public void CopyToList()
        {
            var result = base.personProperCollection.CopyToList();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Count))]
        public void Count()
        {
            var result = base.personProperCollection.Count();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Distinct))]
        public void Distinct()
        {
            var comparer = new PersonProperComparer();
            var result = base.personProperCollection.Distinct(comparer);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FastAny))]
        public void FastAny()
        {
            var result = base.personProperCollection.FastAny(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FastCount))]
        public void FastCount()
        {
            var result = base.personProperCollection.FastCount(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FirstOrDefault) + ": Alternate")]
        public void FirstOrDefaultAlternate()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = base.personProperCollection.FirstOrDefault(person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FirstOrDefault) + ": Predicate, Alternate")]
        public void FirstOrDefaultPredicateAlternate()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = base.personProperCollection.FirstOrDefault(p => p.Id == person.Id, person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FirstOrNull))]
        public void FirstOrNull()
        {
            var coord = RandomData.GenerateCoordinate<CoordinateProper>();

            var result = base.coordinateArray.FirstOrNull(p => p.X == coord.X);

            base.Consumer.Consume(result);
        }


        [Benchmark(Description = nameof(CollectionExtensions.GetOrAdd) + ":Dictionary")]
        public void GetOrAddDictionary()
        {
            var people = base.personProperDictionary;
            var person = base.personProperDictionary.Last();

            var result = people.GetOrAdd(person.Key, person.Value);

            base.Consumer.Consume(result);
        }


        [Benchmark(Description = nameof(CollectionExtensions.GetOrAdd) + ":Dictionary-New")]
        public void GetOrAddDictionaryNew()
        {
            var people = base.personProperDictionary;
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.GetOrAdd(person.Id, person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.HasItems))]
        public void HasItems()
        {
            var result = base.personProperCollection.HasItems(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.IndexOf))]
        public void IndexOf()
        {
            var result = base.personProperCollection.IndexOf(base.personProperCollection.Last());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.IndexOf) + ":Comparer")]
        public void IndexOfComparer()
        {
            var comparer = new PersonProperComparer();
            var result = base.personProperCollection.IndexOf(base.personProperCollection.Last(), comparer);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ListHashCode) + ":Array")]
        public void ListHashCodeArray()
        {
            var result = base.personProperArrayFull.ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ListHashCode) + ":List")]
        public void ListHashCodeList()
        {
            var result = base.personProperCollection.ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ListHashCode) + ":List-Read Only")]
        public void ListHashCodeReadOnlyList()
        {
            var result = base.personProperCollection.ToReadOnlyCollection().ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.OrderBy))]
        public void OrderBy()
        {
            var result = base.personProperCollection.OrderBy(p => p.City);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.OrderByOrdinal))]
        public void OrderByOrdinal()
        {
            var result = base.personProperCollection.OrderByOrdinal(p => p.City);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Page))]
        public void Page()
        {
            foreach (var people in base.personProperCollection.Page(10))
            {
                foreach (var person in people)
                {
                    base.Consumer.Consume(person);
                }
            }
        }

        [Benchmark(Description = nameof(CollectionExtensions.PickRandom))]
        public void PickRandom()
        {
            var result = base.personProperCollection.Take(base.CollectionCount / 10);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.RemoveFirst))]
        public void RemoveFirst()
        {
            var people = base.personProperArrayFull.Clone<PersonProper>();

            var result = people.RemoveFirst();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.RemoveLast))]
        public void RemoveLast()
        {
            var people = base.personProperArrayFull.Clone<PersonProper>();

            var result = people.RemoveLast();

            base.Consumer.Consume(result);
        }


        public override void Setup() { base.Setup(); }


        [Benchmark(Description = nameof(CollectionExtensions.Shuffle))]
        public void Shuffle()
        {
            var result = base.personProperCollection.Shuffle();
            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Shuffle))]
        public void ShuffleWithCount()
        {
            var result = base.personProperCollection.Shuffle(base.CollectionCount / 10);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.StartsWith))]
        public void StartsWith()
        {
            var result = base.personProperArrayFull.StartsWith(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.StructuralSequenceEqual))]
        public void StructuralSequenceEqual()
        {
            var result = base.personProperArrayFull.StructuralSequenceEqual(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDelimitedString))]
        public void ToDelimitedString()
        {
            var result = base.personProperCollection.ToDelimitedString(',');

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDictionary))]
        public void ToDictionary()
        {
            var result = base.personProperCollection.ToDictionary(p => p.Email);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDistinct))]
        public void ToDistinct()
        {
            var result = base.personProperCollection.Select(p => p.Email).ToArray().ToDistinct();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToImmutable) + ": Dictionary")]
        public void ToImmutableDictionary()
        {
            var result = base.personProperDictionary.ToImmutable();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToImmutable) + ": List")]
        public void ToImmutableList()
        {
            var result = base.personProperCollection.ToImmutable();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToLinkedList))]
        public void ToLinkedList()
        {
            var result = base.personProperCollection.ToLinkedList();

            base.Consumer.Consume(result);
        }

        //[Benchmark(Description = nameof(CollectionExtensions.ToListAsync))]
        //public void ToListAsync()
        //{
        //    var result = await base.personProperCollection.ToListAsync();

        //    base.Consumer.Consume(result);
        //}

        [Benchmark(Description = nameof(CollectionExtensions.ToObservableCollection))]
        public void ToObservableCollection()
        {
            var result = base.personProperCollection.ToObservableCollection();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToReadOnlyCollection))]
        public void ToReadOnlyCollection()
        {
            var result = base.personProperCollection.ToReadOnlyCollection();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Upsert))]
        public void UpsertDictionary()
        {
            var people = base.personProperDictionary;
            var person = base.personProperDictionary.Last();

            var result = people.Upsert(person.Key, person.Value);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Upsert) + ":New")]
        public void UpsertDictionaryNew()
        {
            var people = base.personProperDictionary;
            var person = RandomData.GeneratePerson<PersonProper>();

            var result = people.Upsert(person.Id, person);

            base.Consumer.Consume(result);
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
