// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="LoggingHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Logging;
using System;
using System.Linq;

namespace dotNetTips.Utility.Benchmarks.Logging
{
    [BenchmarkCategory(nameof(LoggingHelper))]
    public class LoggingHelperPerfTestRunner : PerfTestRunner
    {

        private Exception _testException;

        public override void Setup()
        {
            base.Setup();

            this._testException = new ArgumentException("Argument Exception!", new ArgumentOutOfRangeException("Argument Out Of Range!", new ArgumentNullException("Argument Null Exception!")));
        }

        [Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptionMessages))]
        public void TestRetrieveAllExceptionMessages()
        {
            var exceptions = LoggingHelper.RetrieveAllExceptionMessages(this._testException).ToArray();

            for (var exceptionCount = 0; exceptionCount < exceptions.Length; exceptionCount++)
            {
                var message = exceptions[exceptionCount];

                base.Consumer.Consume(message);
            }

        }

        [Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptions))]
        public void TestRetrieveAllExceptions()
        {
            var result = LoggingHelper.RetrieveAllExceptions(this._testException).Select(ex => ex).Count();

            base.Consumer.Consume(result);
        }

    }
}
