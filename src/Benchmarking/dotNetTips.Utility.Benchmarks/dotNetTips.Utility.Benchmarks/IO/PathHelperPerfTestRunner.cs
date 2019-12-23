// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-03-2019
// ***********************************************************************
// <copyright file="PathHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.IO;
using System;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(PathHelper))]
    public class PathHelperPerfTestRunner : PerfTestRunner
    {
        [Benchmark(Description = nameof(PathHelper.PathContainsWildcard))]
        public void TestPathContainsWildcard()
        {
            var result= PathHelper.PathContainsWildcard(Environment.CurrentDirectory);

            base.Consumer.Consume(result);
        }
    }
}
