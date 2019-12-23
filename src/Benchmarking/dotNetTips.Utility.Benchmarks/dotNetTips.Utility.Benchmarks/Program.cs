// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using dotNetTips.Utility.Benchmarks.Extensions;
using dotNetTips.Utility.Benchmarks.Logging;
using System;

namespace dotNetTips.Utility.Benchmarks
{
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            var config = DefaultConfig.Instance.With(Job.Default.With(CsProjCoreToolchain.NetCoreApp30));

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

            //BenchmarkRunner.Run<CollectionExtensionsPerfTestRunner>(config);

            Console.Beep();
            Console.Beep(5000, 1000);
            Console.ReadLine();
        }
    }
}
