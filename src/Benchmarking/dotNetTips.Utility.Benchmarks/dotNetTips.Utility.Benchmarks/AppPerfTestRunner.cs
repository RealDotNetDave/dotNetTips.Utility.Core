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
        public void TestGetEnvironmentVariables()
        {
            var result = App.GetEnvironmentVariables();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsProcessRunning))]
        public void TestIsProcessRunning()
        {
            var result = App.IsProcessRunning("devenv");

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsRunning))]
        public void TestIsRunning()
        {
            var result = App.IsRunning();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.IsRunningFromAspNet))]
        public void TestIsRunningFromAspNet()
        {
            var result = App.IsRunningFromAspNet();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.ReferencedAssemblies))]
        public void TestReferencedAssemblies()
        {
            var result = App.ReferencedAssemblies();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.StackTrace))]
        public void TestStackTrace()
        {
            var result = App.StackTrace;

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(App.WorkingSet))]
        public void TestWorkingSet()
        {
            var result = App.WorkingSet;

            base.Consumer.Consume(result);
        }

    }
}
