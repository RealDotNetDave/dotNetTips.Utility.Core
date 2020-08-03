using BenchmarkDotNet.Attributes;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Tester;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetTips.Utility.Benchmarks.Extensions
{
    [BenchmarkCategory(nameof(StringBuilderExtensions))]
    public class StringBuilderExtensionsPerfTestRunner : PerfTestRunner
    {
        [Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes))]
        public void AppendBytes()
        {
            var sb = new StringBuilder();

            sb.AppendBytes(RandomData.GenerateByteArray(1));

            base.Consumer.Consume(sb.ToString());
        }

        [Benchmark(Description = nameof(StringBuilderExtensions.AppendJoin)+":Params")]
        public void AppendJoinParams()
        {
            var sb = new StringBuilder();

            sb.AppendJoin('-', RandomData.GenerateByteArray(1));

            base.Consumer.Consume(sb.ToString());
        }

        [Benchmark(Description = nameof(StringBuilderExtensions.AppendJoin))]
        public void AppendJoin()
        {
            var sb = new StringBuilder();

            sb.AppendJoin<byte>('-', RandomData.GenerateByteArray(1));

            base.Consumer.Consume(sb.ToString());
        }
    }
}
