// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2020
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

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(Standard.Extensions.CollectionExtensions))]
    public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
    {

        private readonly CoordinateProper _coordinate = RandomData.GenerateCoordinate<CoordinateProper>();


        private readonly PersonProper _person = RandomData.GeneratePerson<PersonProper>();
        private PersonProper[] _personArray;

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddFirst) + ":Array")]
        public void AddFirstToArray01()
        {
            var result = this._personArray.AddFirst(this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Params")]
        public void AddIfNotExistsCollection01()
        {
            var people = new List<PersonProper>(base.personProperCollection);
            var newPeople = new List<PersonProper>(base.personProperCollection).Take(10).ToArray();

            var result = people.AddIfNotExists(newPeople);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Params with dups")]
        public void AddIfNotExistsCollection02()
        {
            var people = new List<PersonProper>(base.personProperCollection);
            var newPeople = people.Shuffle(this.CollectionCount / 2).ToArray();

            var result = people.AddIfNotExists(newPeople);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Comparer")]
        public void AddIfNotExistsComparer01()
        {
            var people = new List<PersonProper>(base.CollectionCount);
            var comparer = new PersonProperComparer();

            foreach (var person in base.personProperCollection)
            {
                people.AddIfNotExists(person, comparer);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Dictionary")]
        public void AddIfNotExistsDictionary01()
        {
            var people = new Dictionary<string, PersonProper>(base.CollectionCount);

            foreach (var person in base.personProperDictionary)
            {
                people.AddIfNotExists(person.Key, person.Value);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Params")]
        public void AddIfNotExistsParamArray01()
        {
            var people = new List<PersonProper>(( this.CollectionCount / 2 ).EnsureMinimumValue(2));

            people.AddIfNotExists(base.personProperArrayHalf);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddIfNotExists) + ":Single Item")]
        public void AddIfNotExistsSingle01()
        {
            var people = new List<PersonProper>(base.CollectionCount);

            foreach (var person in base.personProperCollection)
            {
                people.AddIfNotExists(person);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddLast) + ":Array")]
        public void AddLastToArray01()
        {
            var result = this._personArray.AddLast(this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddLast) + ":List")]
        public void AddLastToList01()
        {
            var people = base.personProperCollection.CopyToList();

            var result = people.AddLast(this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AddRange))]
        public void AddRange()
        {
            var people = new List<PersonProper>();

            people.AddRange(base.personProperCollection.Take(base.CollectionCount / 2), true);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AreEqual) + ":Array")]
        public void AreEqualArray()
        {
            var result = base.personProperArrayFull.AreEqual(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.AreEqual) + ":List")]
        public void AreEqualList()
        {
            var result = base.personProperCollection.AreEqual(base.personProperListHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.BytesToString))]
        public void BytesToString()
        {
            var result = base.byteArray.BytesToString();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ClearNulls))]
        public void ClearNulls()
        {
            var people = base.personProperCollection;
            people.AddLast(null);

            var result = people.ClearNulls();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Clone))]
        public void Clone()
        {
            var result = base.personProperCollection.Clone<PersonCollection<PersonProper>>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ContainsAny) + ":Array")]
        public void ContainsAnyArray()
        {
            var people = base.personProperArrayFull.Take(this.CollectionCount / 2).ToList();
            people.Add(RandomData.GeneratePerson<PersonProper>());

            var result = base.personProperArrayFull.ContainsAny(people.ToArray());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ContainsAny) + ":List")]
        public void ContainsAnyList()
        {
            var people = base.personProperCollection.Take(this.CollectionCount / 2).ToList();
            people.Add(RandomData.GeneratePerson<PersonProper>());

            var result = base.personProperCollection.ContainsAny(people.ToArray());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.CopyToList))]
        public void CopyToList()
        {
            var result = base.personProperCollection.CopyToList();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Count))]
        public void Count()
        {
            var result = base.personProperCollection.Count();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Distinct))]
        public void Distinct()
        {
            var comparer = new PersonProperComparer();
            var result = base.personProperCollection.Distinct(comparer);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.FastAny))]
        public void FastAny()
        {
            var result = base.personProperCollection.FastAny(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.FastCount))]
        public void FastCount()
        {
            var result = base.personProperCollection.FastCount(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.FirstOrDefault) + ": Alternate")]
        public void FirstOrDefaultAlternate()
        {
            var result = base.personProperCollection.FirstOrDefault(this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.FirstOrDefault) + ": Predicate, Alternate")]
        public void FirstOrDefaultPredicateAlternate()
        {
            var result = base.personProperCollection.FirstOrDefault(p => p.Id == this._person.Id, this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.FirstOrNull))]
        public void FirstOrNull()
        {
            var result = base.coordinateArray.FirstOrNull(p => p.X == this._coordinate.X);

            base.Consumer.Consume(result);
        }


        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.GetOrAdd) + ":Dictionary")]
        public void GetOrAddDictionary()
        {
            var people = base.personProperDictionary;
            var person = base.personProperDictionary.Last();

            var result = people.GetOrAdd(person.Key, person.Value);

            base.Consumer.Consume(result);
        }


        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.GetOrAdd) + ":Dictionary-New")]
        public void GetOrAddDictionaryNew()
        {
            var people = base.personProperDictionary;

            var result = people.GetOrAdd(this._person.Id, this._person);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.HasItems))]
        public void HasItems()
        {
            var result = base.personProperCollection.HasItems(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.IndexOf))]
        public void IndexOf()
        {
            var result = base.personProperCollection.IndexOf(base.personProperCollection.Last());

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.IndexOf) + ":Comparer")]
        public void IndexOfComparer()
        {
            var comparer = new PersonProperComparer();
            var result = base.personProperCollection.IndexOf(base.personProperCollection.Last(), comparer);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ListHashCode) + ":Array")]
        public void ListHashCodeArray()
        {
            var result = base.personProperArrayFull.ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ListHashCode) + ":List")]
        public void ListHashCodeList()
        {
            var result = base.personProperCollection.ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ListHashCode) + ":List-Read Only")]
        public void ListHashCodeReadOnlyList()
        {
            var result = base.personProperCollection.ToReadOnlyCollection().ListHashCode();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.OrderBy))]
        public void OrderBy()
        {
            var result = base.personProperCollection.OrderBy(p => p.City);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.OrderByOrdinal))]
        public void OrderByOrdinal()
        {
            var result = base.personProperCollection.OrderByOrdinal(p => p.City);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Page))]
        public void Page()
        {
            foreach (var people in base.personProperCollection.Page(2))
            {
                foreach (var person in people)
                {
                    base.Consumer.Consume(person);
                }
            }
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.PickRandom))]
        public void PickRandom()
        {
            var result = base.personProperCollection.Take(base.CollectionCount / 2);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.RemoveFirst))]
        public void RemoveFirst()
        {
            var result = this._personArray.RemoveFirst();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.RemoveLast))]
        public void RemoveLast()
        {
            var result = this._personArray.RemoveLast();

            base.Consumer.Consume(result);
        }


        public override void Setup()
        {
            base.Setup();

            this._personArray = base.personProperArrayFull;
        }


        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Shuffle))]
        public void Shuffle()
        {
            var result = base.personProperCollection.Shuffle();
            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Shuffle) + ": With Count")]
        public void ShuffleWithCount()
        {
            var result = base.personProperCollection.Shuffle(( this.CollectionCount / 2 ).EnsureMinimumValue(2));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.StartsWith))]
        public void StartsWith()
        {
            var result = base.personProperArrayFull.StartsWith(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.StructuralSequenceEqual))]
        public void StructuralSequenceEqual()
        {
            var result = base.personProperArrayFull.StructuralSequenceEqual(base.personProperArrayHalf);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToDelimitedString))]
        public void ToDelimitedString()
        {
            var result = base.personProperCollection.ToDelimitedString(',');

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToDictionary))]
        public void ToDictionary()
        {
            var result = base.personProperCollection.ToDictionary(p => p.Email);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToDistinct))]
        public void ToDistinct()
        {
            var result = base.personProperCollection.Select(p => p.Email).ToArray().ToDistinct();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToImmutable) + ": Dictionary")]
        public void ToImmutableDictionary()
        {
            var result = base.personProperDictionary.ToImmutable();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToImmutable) + ": List")]
        public void ToImmutableList()
        {
            var result = base.personProperCollection.ToImmutable();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToLinkedList))]
        public void ToLinkedList()
        {
            var result = base.personProperCollection.ToLinkedList();

            base.Consumer.Consume(result);
        }

        //[Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToListAsync))]
        //public void ToListAsync()
        //{
        //    var result = await base.personProperCollection.ToListAsync();

        //    base.Consumer.Consume(result);
        //}

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToObservableCollection))]
        public void ToObservableCollection()
        {
            var result = base.personProperCollection.ToObservableCollection();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.ToReadOnlyCollection))]
        public void ToReadOnlyCollection()
        {
            var result = base.personProperCollection.ToReadOnlyCollection();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Upsert))]
        public void UpsertDictionary()
        {
            var people = base.personProperDictionary;
            var person = base.personProperDictionary.Last();

            var result = people.Upsert(person.Key, person.Value);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Standard.Extensions.CollectionExtensions.Upsert) + ":New Person")]
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
