// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-30-2019
// ***********************************************************************
// <copyright file="PathHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.IO;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(PathHelper))]
    public class PathHelperPerfTestRunner : PerfTestRunner
    {
        // TODO: FIX
        // [Benchmark(Description = nameof(PathHelper.PathContainsWildcard))]
        // public bool TestPathContainsWildcard() => PathHelper.PathContainsWildcard(Environment.CurrentDirectory);
    }
}
