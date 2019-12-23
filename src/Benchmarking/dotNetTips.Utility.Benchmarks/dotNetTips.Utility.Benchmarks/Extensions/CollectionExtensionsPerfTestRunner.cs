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
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester.Models;
using System.Linq;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(Standard.Extensions.CollectionExtensions))]
    public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
    {
        public override void Setup() { base.Setup(); }

        [Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists))]
        public void TestAddIfNotExists()
        {
            var people = new System.Collections.Generic.List<PersonProper>();

            foreach (var person in base.personProperCollection)
            {
                people.AddIfNotExists(person);
            }

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddRange))]
        public void TestAddRange()
        {
            var people = new System.Collections.Generic.List<PersonProper>();

            Standard.Extensions.CollectionExtensions
                .AddRange<PersonProper>(people, base.personProperCollection.PickRandom(base.CollectionCount / 2), true);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = "CollectionExtensions.Clone")]
        public void TestClone()
        {
            var result = base.personProperCollection.Clone<PersonProper>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.CopyToList))]
        public void TestCopyToList()
        {
            var result = base.personProperCollection.CopyToList();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Count))]
        public void TestCount()
        {
            var result = base.personProperCollection.Count();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FastAny))]
        public void TestFastAny()
        {
            var result = base.personProperCollection.FastAny(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.FastCount))]
        public void TestFastCount()
        {
            var result = base.personProperCollection.FastCount(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.HasItems))]
        public void TestHasItems()
        {
            var result = base.personProperCollection.HasItems(p => p.City.Contains("SAN"));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.OrderBy))]
        public void TestOrderBy()
        {
            var result = base.personProperCollection.OrderBy(p => p.City);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Page))]
        public void TestPage()
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
        public void TestPickRandom()
        {
            var result = base.personProperCollection.PickRandom(CollectionCount / 2);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.Randomize))]
        public void TestRandomize()
        {
            var result = base.personProperCollection.Randomize();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDelimitedString))]
        public void TestToDelimitedString()
        {
            var result = base.personProperCollection.ToDelimitedString(',');

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDictionary))]
        public void TestToDictionary()
        {
            var result = base.personProperCollection.ToDictionary(p => p.Email);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToDistinct))]
        public void TestToDistinct()
        {
            var result = base.personProperCollection.Select(p => p.Email).ToArray().ToDistinct();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToImmutable))]
        public void TestToImmutable()
        {
            var result = base.personProperCollection.ToImmutable();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToLinkedList))]
        public void TestToLinkedList()
        {
            var result = base.personProperCollection.ToLinkedList();

            base.Consumer.Consume(result);
        }

        //[Benchmark(Description = nameof(CollectionExtensions.ToListAsync))]
        //public void TestToListAsync()
        //{
        //    var result = await base.personProperCollection.ToListAsync();

        //    base.Consumer.Consume(result);
        //}

        [Benchmark(Description = nameof(CollectionExtensions.ToObservableCollection))]
        public void TestToObservableCollection()
        {
            var result = base.personProperCollection.ToObservableCollection();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(CollectionExtensions.ToReadOnlyCollection))]
        public void TestToReadOnlyCollection()
        {
            var result = base.personProperCollection.ToReadOnlyCollection();

            base.Consumer.Consume(result);
        }

    }
}
