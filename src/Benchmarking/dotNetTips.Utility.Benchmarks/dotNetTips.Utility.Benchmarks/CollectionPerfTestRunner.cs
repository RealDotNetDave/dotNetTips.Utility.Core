// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2020
// ***********************************************************************
// <copyright file="CollectionPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotNetTips.Utility.Benchmarks
{
    // [ConcurrencyVisualizerProfiler()]
    /// <summary>
    /// Class CollectionPerfTestRunner.
    /// Implements the <see cref="dotNetTips.Utility.Benchmarks.PerfTestRunner" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Benchmarks.PerfTestRunner" />
    public class CollectionPerfTestRunner : PerfTestRunner
    {

        /// <summary>
        /// The person fixed collection
        /// </summary>
        protected PersonCollection<PersonFixed> personFixedCollection;

        /// <summary>
        /// The person proper array full
        /// </summary>
        protected PersonProper[] personProperArrayFull;

        /// <summary>
        /// The person proper array half
        /// </summary>
        protected PersonProper[] personProperArrayHalf;

        /// <summary>
        /// The person proper collection
        /// </summary>
        protected PersonCollection<PersonProper> personProperCollection;

        /// <summary>
        /// The person proper collection half count
        /// </summary>
        protected List<PersonProper> personProperListHalf;

        /// <summary>
        /// The person proper dictionary
        /// </summary>
        protected Dictionary<string, PersonProper> personProperDictionary;

        /// <summary>
        /// The sortable person proper collection
        /// </summary>
        protected PersonCollection<PersonProper> sortablePersonProperCollection;

        /// <summary>
        /// The test email
        /// </summary>
        protected string testEmail;

        /// <summary>
        /// Gets or sets the collection count.
        /// </summary>
        /// <value>The collection count.</value>
        [Params(25, 50, 100, 250, 500)]
        public int CollectionCount { get; set; }

        /// <summary>
        /// Setups this instance.
        /// </summary>
        public override void Setup()
        {
            base.Setup();

            BenchmarkDotNet.Loggers.ConsoleLogger.Default.WriteLine(BenchmarkDotNet.Loggers.LogKind.Info, $"Collection Count={this.CollectionCount}.");

            this.personFixedCollection = new PersonCollection<PersonFixed>();
            this.personFixedCollection.AddRange(RandomData.GeneratePersonCollection<PersonFixed>(this.CollectionCount));

            this.personProperCollection = new PersonCollection<PersonProper>();
            this.personProperCollection.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.CollectionCount));

            this.personProperDictionary = this.personProperCollection.ToDictionary(p => p.Id);

            this.testEmail = this.personProperCollection[RandomData.GenerateInteger(0, this.CollectionCount - 1)].Email;

            this.sortablePersonProperCollection = new PersonCollection<PersonProper>(this.personProperCollection);

            this.personProperArrayFull = this.personProperCollection.ToArray();
            this.personProperArrayHalf = this.personProperCollection.Take(CollectionCount / 2).ToArray();

            this.personProperListHalf = this.personProperCollection.Take(CollectionCount / 2).ToList();
        }

    }
}
