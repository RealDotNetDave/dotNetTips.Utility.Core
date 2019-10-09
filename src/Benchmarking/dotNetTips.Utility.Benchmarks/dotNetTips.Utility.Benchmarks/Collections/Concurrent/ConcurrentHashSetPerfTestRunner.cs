// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 07-10-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2019
// ***********************************************************************
// <copyright file="ConcurrentHashSetPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Collections.Generic.Concurrent;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Collections.Concurrent
{
    [BenchmarkCategory(nameof(ConcurrentHashSet<PersonProper>), Categories.GenericCollections)]
    public class ConcurrentHashSetPerfTestRunner : CollectionPerfTestRunner
    {

        private ConcurrentHashSet<PersonProper> _peopleConcurrentHashSet;

        public override void Setup()
        {
            base.Setup();

            this._peopleConcurrentHashSet = new ConcurrentHashSet<PersonProper>(base.personProperCollection);
        }

        [Benchmark(Description = "Create Using Constructor.")]
        public void TestCreating01()
        {
            var result = new ConcurrentHashSet<PersonProper>(base.personProperCollection);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = "Create Using ForEach().")]
        public void TestCreating02()
        {
            var fakePeople = new ConcurrentHashSet<PersonProper>();

            base.personProperCollection.ForEach(p => fakePeople.Add(p));

            base.Consumer.Consume(fakePeople);
        }

        [Benchmark(Description = "Looping with foreach().")]
        public void TestLoopingForEach01()
        {
            foreach (var person in this._peopleConcurrentHashSet)
            {
                base.Consumer.Consume(person.FirstName);
            }
        }

    }
}
