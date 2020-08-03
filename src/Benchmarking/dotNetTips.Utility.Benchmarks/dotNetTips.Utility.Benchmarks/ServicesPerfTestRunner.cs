// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="ServicesPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.Extensions;
using System.Linq;

namespace dotNetTips.Utility.Benchmarks
{
    [BenchmarkCategory(nameof(Services))]
    public class ServicesPerfTestRunner : PerfTestRunner
    {

        string _service;

        public override void Setup()
        {
            base.Setup();

            _service = Services.AllServices().Randomize().FirstOrDefault();
        }

        [Benchmark(Description = nameof(Services.AllServices))]
        public void AllServices()
        {
            var result = Services.AllServices();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Services.ServiceExists))]
        public void ServiceExists()
        {
            var result = Services.ServiceExists(_service);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Services.ServiceStatus))]
        public void ServiceStatus()
        {
            var result = Services.ServiceStatus(_service);

            base.Consumer.Consume(result);
        }

    }
}
