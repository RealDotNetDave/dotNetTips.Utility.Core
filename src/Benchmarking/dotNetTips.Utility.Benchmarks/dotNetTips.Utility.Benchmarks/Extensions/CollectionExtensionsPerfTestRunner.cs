// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="CollectionExtensionsPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(CollectionExtensions))]
    public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
    {

        public override void Setup()
        {
            base.Setup();
        }

        [Benchmark(Description = nameof(CollectionExtensions.AddRange))]
        public void TestAddRange()
        {
            var people = new System.Collections.Generic.List<PersonProper>();

            CollectionExtensions.AddRange<PersonProper>(people, base.personProperCollection.PickRandom(base.CollectionCount / 2), true);

            base.Consumer.Consume(people.Count);
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

    }
}
