// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 07-15-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2019
// ***********************************************************************
// <copyright file="ConcurrentDistinctConcurrentBagPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Collections.Generic.Concurrent;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Collections.Concurrent
{
    [BenchmarkCategory(nameof(DistinctConcurrentBag<PersonProper>), Categories.GenericCollections)]
    public class ConcurrentDistinctConcurrentBagPerfTestRunner : CollectionPerfTestRunner
    {

        private DistinctConcurrentBag<PersonProper> _distinctConcurrentBag;

        public override void Setup()
        {
            base.Setup();

            this._distinctConcurrentBag = new DistinctConcurrentBag<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(this.CollectionCount));
        }

        [Benchmark(Description = "Creating Using Constructor.")]
        public void Creating01()
        {
            var fakePeople = new DistinctConcurrentBag<PersonProper>(this.personProperCollection);

            base.Consumer.Consume(fakePeople);
        }

        [Benchmark(Description = "Creating Using ForEach().")]
        public void Creating02()
        {
            var fakePeople = new DistinctConcurrentBag<PersonProper>();

            this.personProperCollection.ForEach(p => { fakePeople.Add(p); });

            base.Consumer.Consume(fakePeople);
        }

        [Benchmark(Description = "Looping with foreach().")]
        public void LoopingForEach01()
        {
            foreach (var person in this._distinctConcurrentBag)
            {
                base.Consumer.Consume(person);
            }
        }

    }
}
