// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="StringExtensionsPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(StringExtensions))]
    public class StringExtensionsPerfTestRunner : PerfTestRunner
    {
        private string _stringToTrim;

        public override void Setup()
        {
            base.Setup();

            this._stringToTrim = "         " + LongTestString + "                   ";
        }

        [Benchmark(Description = nameof(StringExtensions.ComputeSha256Hash))]
        public void TestComputeMD5Hash()
        {
            var result = LongTestString.ComputeSha256Hash();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.Concat))]
        public void TestConcat()
        {
            var result = LongTestString.Concat(",", true, "TEST1", "TEST2");

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.ContainsAny))]
        public void TestContainsAny()
        {
            var result = LongTestString.ContainsAny("A", "Z");

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
        public void TestDefaultIfNull()
        {
            var result = LongTestString.DefaultIfNull();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
        public void TestDefaultIfNullOrEmpty()
        {
            var result = LongTestString.DefaultIfNullOrEmpty("David");

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.HasValue))]
        public void TestHasValue()
        {
            var result = LongTestString.HasValue();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.Indent))]
        public void TestIndent()
        {
            var result = LongTestString.Indent(10, '>');

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(StringExtensions.ToTrimmedString))]
        public void TestToTrimmedString()
        {
            var result = this._stringToTrim.ToTrimmedString();

            base.Consumer.Consume(result);
        }

    }
}
