// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="TypeHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks
{
    [BenchmarkCategory(nameof(TypeHelper))]
    public class TypeHelperPerfTestRunner : PerfTestRunner
    {

        private PersonProper _personProper;

        public override void Setup()
        {
            base.Setup();

            this._personProper = RandomData.GeneratePerson<PersonProper>();
        }

        [Benchmark(Description = nameof(TypeHelper.GetInstanceHashCode))]
        public void TestGetInstanceHashCode()
        {
            var result = TypeHelper.GetInstanceHashCode(this._personProper);

            base.Consumer.Consume(result);
        }

    }
}
