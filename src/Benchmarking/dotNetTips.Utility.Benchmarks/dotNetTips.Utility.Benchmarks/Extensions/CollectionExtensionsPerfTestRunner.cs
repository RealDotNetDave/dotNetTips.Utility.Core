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
using System;
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
    [BenchmarkCategory(nameof(Standard.Extensions.CollectionExtensions))]
    public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
    {

        [Benchmark(Description = nameof(CollectionExtensions.AddFirst) + ":Array")]
        public void AddFirstToArray()
        {
            var people = base.personProperArrayFull.Clone<PersonProper>();

            var result = people.AddFirst(RandomData.GeneratePerson<PersonProper>());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Comparer")]
        public void AddIfNotExistsComparer()
        {
            var people = new System.Collections.Generic.List<PersonProper>(base.CollectionCount);
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
            var people = new System.Collections.Generic.Dictionary<string, PersonProper>(base.CollectionCount);

            foreach (var person in base.personProperDictionary)
            {
                people.AddIfNotExists<string, PersonProper>(person.Key, person.Value);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Param Array")]
        public void AddIfNotExistsParamArray()
        {
            var people = new System.Collections.Generic.List<PersonProper>(CollectionCount / 2);

            people.AddIfNotExists(base.personProperArrayHalf);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ":Single")]
        public void AddIfNotExistsSingle()
        {
            var people = new System.Collections.Generic.List<PersonProper>(base.CollectionCount);

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
            var people = new System.Collections.Generic.List<PersonProper>();

            Standard.Extensions.CollectionExtensions
                .AddRange<PersonProper>(people, base.personProperCollection.PickRandom(base.CollectionCount / 2), true);

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

        [Benchmark(Description = nameof(CollectionExtensions.Clone))]
        public void Clone()
        {
            var result = base.personProperCollection.Clone<PersonCollection<PersonProper>>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ContainsAny) + ":Array")]
        public void ContainsAnyArray()
        {
            var people = base.personProperArrayFull.PickRandom(CollectionCount / 2).ToList();
            people.Add(RandomData.GeneratePerson<PersonProper>());

            var result = base.personProperArrayFull.ContainsAny(people.ToArray());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ContainsAny) + ":List")]
        public void ContainsAnyList()
        {
            var people = base.personProperCollection.PickRandom(CollectionCount / 2).ToList();
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
            var result = base.personProperCollection.PickRandom(CollectionCount / 2);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Randomize))]
        public void Randomize()
        {
            var result = base.personProperCollection.Randomize();

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

        [Benchmark(Description = nameof(CollectionExtensions.ToImmutable))]
        public void ToImmutable()
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
