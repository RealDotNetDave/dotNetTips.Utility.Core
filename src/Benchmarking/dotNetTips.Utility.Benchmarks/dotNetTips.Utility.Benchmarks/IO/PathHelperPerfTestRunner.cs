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
using System;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(PathHelper))]
    public class PathHelperPerfTestRunner : PerfTestRunner
    {
        [Benchmark(Description = nameof(PathHelper.PathContainsWildcard))]
        public void PathContainsWildcardTest()
        {
            var result = PathHelper.PathContainsWildcard(Environment.CurrentDirectory);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(PathHelper.EnsureTrailingSlash))]
        public void EnsureTrailingSlashTest()
        {
            var result = PathHelper.EnsureTrailingSlash(Environment.CurrentDirectory);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(PathHelper.HasInvalidFilterChars))]
        public void HasInvalidFilterChars()
        {
            var result = PathHelper.HasInvalidFilterChars(RandomData.GenerateWord(15));

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(PathHelper.PathHasInvalidChars))]
        public void PathHasInvalidCharsTest()
        {
            var result = PathHelper.PathHasInvalidChars(Environment.CurrentDirectory);

            base.Consumer.Consume(result);
        }
    }
}
