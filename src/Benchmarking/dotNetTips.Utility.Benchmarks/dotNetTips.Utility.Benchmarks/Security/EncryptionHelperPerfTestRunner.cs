﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-03-2019
// ***********************************************************************
// <copyright file="EncryptionHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Security;
using dotNetTips.Utility.Standard.Tester;

namespace dotNetTips.Utility.Benchmarks.Security
{
    [BenchmarkCategory(nameof(EncryptionHelper))]
    public class EncryptionHelperPerfTestRunner : PerfTestRunner
    {

        [Benchmark(Description = "AesEncryption")]
        public void AesEncrypt()
        {
            using var keys = new AesManaged();

            var encryptResult = EncryptionHelper.AesEncrypt(RandomData.LongTestString, keys.Key, keys.IV);

            var decryptResult = EncryptionHelper.AesDecrypt(encryptResult, keys.Key, keys.IV);

            base.Consumer.Consume(decryptResult);
        }
        public override void Cleanup()
        {
            base.Cleanup();
        }

        public override void Setup()
        {
            base.Setup();

        }
    }
}
