// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="XmlHelperPerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using dotNetTips.Utility.Standard.Xml;

namespace dotNetTips.Utility.Benchmarks.Xml
{
    [BenchmarkCategory(nameof(XmlHelper))]
    public class XmlHelperPerfTestRunner : CollectionPerfTestRunner
    {

        private string _xml;

        public override void Setup()
        {
            base.Setup();

            _xml = XmlHelper.Serialize(base.personProperCollection);
        }

        [Benchmark(Description = nameof(XmlHelper.Deserialize))]
        public void TestDeserialize()
        {
            var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(_xml);

            base.Consumer.Consume(result);
        }

        [Benchmark(Description = nameof(XmlHelper.Serialize))]
        public void TestSerialize()
        {
            var result = XmlHelper.Serialize(base.personProperCollection);

            base.Consumer.Consume(result);
        }

    }
}
