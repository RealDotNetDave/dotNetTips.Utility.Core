// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="JsonSerializerPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Serialization;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Serialization
{
    [BenchmarkCategory(nameof(JsonSerializer))]
    public class JsonSerializerPerfTestRunner : CollectionPerfTestRunner
    {

        private string _json;

        public override void Setup()
        {
            base.Setup();

            _json = JsonSerializer.Serialize(base.personProperCollection);
        }

        [Benchmark(Description = nameof(JsonSerializer.Deserialize))]
        public void TestDeserialize()
        {
            var result = JsonSerializer.Deserialize<PersonCollection<PersonProper>>(_json);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(JsonSerializer.Serialize))]
        public void TestSerialize()
        {
            var result = JsonSerializer.Serialize(base.personProperCollection);

            base.Consumer.Consume(result);
        }

    }
}
