// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 07-15-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2019
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Collections;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester.Models;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Benchmarks.Collections.Concurrent
{
    [BenchmarkCategory(nameof(DistinctBlockingCollection<PersonProper>), Categories.GenericCollections)]
    public class DistinctBlockingCollectionPerfTestRunner : CollectionPerfTestRunner
    {

        private DistinctBlockingCollection<PersonProper> _peopleDistinctBlockingCollection;

        public override void Cleanup()
        {
            base.Cleanup();

            this._peopleDistinctBlockingCollection.TryDispose();
        }

        public override void Setup()
        {
            base.Setup();

            this._peopleDistinctBlockingCollection = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);
        }

        [Benchmark(Description = "Creating Using Constructor.")]
        public void Creating01()
        {
            var people = new DistinctBlockingCollection<PersonProper>(base.personProperCollection);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = "Creating Using for().")]
        public void Creating02()
        {
            var fakePeople = new DistinctBlockingCollection<PersonProper>();

            base.personProperCollection.ForEach(p =>
            {
                fakePeople.Add(p);
            });

            base.Consumer.Consume(fakePeople);
        }

        [Benchmark(Description = "Looping with foreach().")]
        public void LoopingForEach01()
        {
            foreach (var person in this._peopleDistinctBlockingCollection)
            {
                base.Consumer.Consume(person);
            }
        }

        [Benchmark(Description = "Looping with Parallel.ForEach().")]
        public void LoopingForEach02()
        {
            Parallel.ForEach(this._peopleDistinctBlockingCollection, p =>
                        {
                            base.Consumer.Consume(p);
                        });

        }

    }
}
