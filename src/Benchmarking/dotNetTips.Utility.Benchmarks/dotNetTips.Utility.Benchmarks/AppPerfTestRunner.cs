// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="AppPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard;

namespace dotNetTips.Utility.Benchmarks
{
    [BenchmarkCategory(nameof(App))]
    public class AppPerfTestRunner : PerfTestRunner
    {
        public override void Setup() { base.Setup(); }

        [Benchmark(Description = nameof(App.GetEnvironmentVariables))]
        public void GetEnvironmentVariables()
        {
            var result = App.GetEnvironmentVariables();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsProcessRunning))]
        public void IsProcessRunning()
        {
            var result = App.IsProcessRunning("devenv");

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsRunning))]
        public void IsRunning()
        {
            var result = App.IsRunning();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsRunningFromAspNet))]
        public void IsRunningFromAspNet()
        {
            var result = App.IsRunningFromAspNet();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.ReferencedAssemblies))]
        public void ReferencedAssemblies()
        {
            var result = App.ReferencedAssemblies();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.StackTrace))]
        public void StackTrace()
        {
            var result = App.StackTrace;

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.WorkingSet))]
        public void WorkingSet()
        {
            var result = App.WorkingSet;

            base.Consumer.Consume(result);
        }

    }
}
