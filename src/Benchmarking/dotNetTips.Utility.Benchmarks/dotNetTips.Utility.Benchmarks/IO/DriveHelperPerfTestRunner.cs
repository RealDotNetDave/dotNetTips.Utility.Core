// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2019
// ***********************************************************************
// <copyright file="DriveHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.IO;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(DriveHelper))]
    public class DriveHelperPerfTestRunner : PerfTestRunner
    {

        [Benchmark(Description = nameof(DriveHelper.GetFixedDrives))]
        public void TestGetFixedDrives()
        {
            var result = DriveHelper.GetFixedDrives();

            base.Consumer.Consume(result);
        }

    }
}
