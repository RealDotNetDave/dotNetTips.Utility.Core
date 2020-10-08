// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-07-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-07-2020
// ***********************************************************************
// <copyright file="SecurityHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Security;

namespace dotNetTips.Utility.Benchmarks.Security
{
    [BenchmarkCategory(nameof(SecurityHelper), Categories.String, Categories.Security)]
    public class SecurityHelperPerfTestRunner : PerfTestRunner
    {
        public override void Cleanup()
        {
            base.Cleanup();
        }

        [Benchmark(Description = nameof(SecurityHelper.CompareSecureStrings))]
        public void CompareSecureStrings()
        {
            var secureString1 = SecurityHelper.LoadSecureString(TestEmailMixedCase);
            var secureString2 = SecurityHelper.LoadSecureString(TestEmailMixedCase);

            var result = SecurityHelper.CompareSecureStrings(secureString1, secureString2);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(SecurityHelper.LoadSecureString))]
        public void LoadSecureString()
        {
            var result = SecurityHelper.LoadSecureString(TestEmailMixedCase);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(SecurityHelper.ReadSecureString))]
        public void ReadSecureString()
        {
            var secureString = SecurityHelper.LoadSecureString(TestEmailMixedCase);

            var result = SecurityHelper.ReadSecureString(secureString);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = "Read String Characters", Baseline = true)]
        public void ReadStringCharacters()
        {
            var result = string.Empty;

            foreach (var character in TestEmailMixedCase.ToCharArray())
            {
                result += character;
            }

            base.Consumer.Consume(result);
        }

        public override void Setup()
        {
            base.Setup();

        }

    }
}
