// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 07-15-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2019
// ***********************************************************************
// <copyright file="FastSortedListPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Collections.Generic;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Collections.Concurrent
{
    [BenchmarkCategory(nameof(FastSortedList<PersonProper>), Categories.GenericCollections)]
    public class FastSortedListPerfTestRunner : CollectionPerfTestRunner
    {

        private FastSortedList<PersonProper> _peopleFastSortedList;

        public override void Setup()
        {
            base.Setup();

            this._peopleFastSortedList = new FastSortedList<PersonProper>(base.personProperCollection);
        }

        [Benchmark(Description = "Creating Using Constructor")]
        public void Creating01()
        {
            var people = new FastSortedList<PersonProper>(base.personProperCollection);

            base.Consumer.Consume(people);
        }

        [Benchmark(Description = "Creating Using for()")]
        public void Creating02()
        {
            var fakePeople = new FastSortedList<PersonProper>();

            base.personProperCollection.ForEach(p =>
            {
                fakePeople.Add(p);
            });

            base.Consumer.Consume(fakePeople);
        }

        [Benchmark(Description = "Looping with ForEach()")]
        public void LoopingForEach01()
        {
            this._peopleFastSortedList.ForEach(p =>
            {
                base.Consumer.Consume(p);
            });
        }

        [Benchmark(Description = "Sort()")]
        public void Sort01()
        {
            this._peopleFastSortedList.Sort();
        }

        [Benchmark(Description = "Sort(delegate) on Country")]
        public void Sort02()
        {
            this._peopleFastSortedList.Sort(delegate (PersonProper p1, PersonProper p2)
            {
                return p1.Country.CompareTo(p2.Country);
            });
        }

    }
}
