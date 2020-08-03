// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="EnumExtensionsPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using System;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(EnumExtensions))]
    public class EnumExtensionsPerfTestRunner : PerfTestRunner
    {
        [Benchmark(Description = nameof(EnumExtensions.GetDescription))]
        public void GetDescription()
        {
            var testEnum = StringComparison.OrdinalIgnoreCase;

            var result = testEnum.GetDescription();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(EnumExtensions.GetItems))]
        public void GetItems()
        {
            var testEnum = StringComparison.OrdinalIgnoreCase;

            var result = testEnum.GetItems<StringComparison>();

            base.Consumer.Consume(result);
        }
    }
}
