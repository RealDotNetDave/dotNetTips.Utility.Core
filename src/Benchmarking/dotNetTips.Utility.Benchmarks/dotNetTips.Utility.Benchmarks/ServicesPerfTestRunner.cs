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
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Benchmarks
{
    [BenchmarkCategory(nameof(Services))]
    public class ServicesPerfTestRunner : PerfTestRunner
    {

        string _service;

        [Benchmark(Description = nameof(Services.AllServices))]
        public void AllServices()
        {
            var result = Services.AllServices();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Services.ServiceExists))]
        public void ServiceExists()
        {
            var result = Services.ServiceExists(this._service);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(Services.ServiceStatus))]
        public void ServiceStatus()
        {
            var result = Services.ServiceStatus(this._service);

            base.Consumer.Consume(result);
        }

        public override void Setup()
        {
            base.Setup();

            this._service = Services.AllServices().Shuffle().FirstOrDefault();
        }

    }
}
