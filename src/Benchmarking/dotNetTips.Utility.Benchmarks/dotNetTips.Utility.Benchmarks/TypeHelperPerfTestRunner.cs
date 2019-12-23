// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
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

        [Benchmark(Description = nameof(TypeHelper.Create))]
        public void TestCreate()
        {
            var result = TypeHelper.Create<PersonProper>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(TypeHelper.DoesObjectEqualInstance))]
        public void TestDoesObjectEqualInstance()
        {
            var person1 = RandomData.GeneratePerson<PersonProper>();
            var person2 = RandomData.GeneratePerson<PersonProper>();

            var result = TypeHelper.DoesObjectEqualInstance(person1, person2);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(TypeHelper.FindDerivedTypes))]
        public void TestFindDerivedTypes()
        {
            var result = TypeHelper.FindDerivedTypes(typeof(PersonProper), true);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(TypeHelper.GetDefault))]
        public void TestGetDefault()
        {
            var result = TypeHelper.GetDefault<PersonProper>();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(TypeHelper.GetInstanceHashCode))]
        public void TestGetInstanceHashCode()
        {
            var result = TypeHelper.GetInstanceHashCode(this._personProper);

            base.Consumer.Consume(result);
        }

    }
}
