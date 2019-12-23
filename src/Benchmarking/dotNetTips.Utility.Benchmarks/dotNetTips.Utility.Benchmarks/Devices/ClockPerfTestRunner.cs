// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="ClockPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Devices;
using System;

namespace dotNetTips.Utility.Benchmarks.Devices
{
    [BenchmarkCategory(nameof(Clock))]
    public class ClockPerfTestRunner : PerfTestRunner
    {

        [Benchmark(Description = nameof(Clock.DaysInCurrentMonth))]
        public int TestDaysInCurrentMonth() => Clock.DaysInCurrentMonth;

        [Benchmark(Description = nameof(Clock.DaysInCurrentUtcMonth))]
        public int TestDaysInCurrentUtcMonth() => Clock.DaysInCurrentUtcMonth;

        [Benchmark(Description = nameof(Clock.LocalTime))]
        public DateTime TestLocalTime() => Clock.LocalTime;

        [Benchmark(Description = nameof(Clock.TickCount))]
        public int TestTickCount() => Clock.TickCount;

        [Benchmark(Description = nameof(Clock.UtcTime))]
        public DateTime TestUtcTime() => Clock.UtcTime;

    }
}
