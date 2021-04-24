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

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Serialization;
using dotNetTips.Utility.Standard.Tester.Models;

namespace dotNetTips.Utility.Benchmarks.Serialization
{
    [BenchmarkCategory(nameof(JsonSerializer))]
    public class JsonSerializerPerfTestRunner : CollectionPerfTestRunner
    {

        private string _json;

        [Benchmark(Description = nameof(JsonSerializer.Deserialize))]
        public void DeserializeTest()
        {
            var result = JsonSerializer.Deserialize<List<PersonProper>>(this._json);

            base.Consumer.Consume(result);
        }

        //[Benchmark(Description = nameof(JsonSerializer.Deserialize))]
        //public void JsonEqualTest()
        //{
        //    var result = JsonSerializer.JsonEqual(this._json, this._json);

        //    base.Consumer.Consume(result);
        //}

        //[Benchmark(Description = nameof(JsonSerializer.Serialize))]
        //public void SerializeTest()
        //{
        //    var result = JsonSerializer.Serialize(base.personProperCollection);

        //    base.Consumer.Consume(result);
        //}

        public override void Setup()
        {
            base.Setup();

            this._json = JsonSerializer.Serialize(base.personProperCollection.ToList<PersonProper>());
        }

    }
}
