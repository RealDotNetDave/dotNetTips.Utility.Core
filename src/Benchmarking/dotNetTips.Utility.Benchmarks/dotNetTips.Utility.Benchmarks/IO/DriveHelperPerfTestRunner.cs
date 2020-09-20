// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-03-2019
// ***********************************************************************
// <copyright file="DriveHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.IO;

namespace dotNetTips.Utility.Benchmarks.IO
{
    [BenchmarkCategory(nameof(DriveHelper))]
    public class DriveHelperPerfTestRunner : PerfTestRunner
    {

        [Benchmark(Description = nameof(DriveHelper.GetDriveSerialNumber))]
        public void GetDriveSerialNumber()
        {
            var result = DriveHelper.GetDriveSerialNumber(DriveHelper.GetFixedDrives().PickRandom().Name);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(DriveHelper.GetFixedDrives))]
        public void GetFixedDrives()
        {
            var result = DriveHelper.GetFixedDrives();

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(DriveHelper.GetRemovableDrives))]
        public void GetRemovableDrives()
        {
            var result = DriveHelper.GetRemovableDrives();

            base.Consumer.Consume(result);
        }

    }
}
