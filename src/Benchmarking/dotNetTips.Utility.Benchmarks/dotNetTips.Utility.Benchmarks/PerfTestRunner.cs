// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 10-02-2019
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="PerfTestRunner.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Order;
using System;
using static BenchmarkDotNet.Attributes.MarkdownExporterAttribute;

namespace dotNetTips.Utility.Benchmarks
{
    /// <summary>
    /// Class PerfTest.
    /// Implements the <see cref="Object" />
    /// </summary>
    /// <seealso cref="Object" />
    [CategoriesColumn]
    [CsvExporter]
    [EvaluateOverhead]
    [GcServer(true)]
    [GitHub]
    [HtmlExporter]
    //[JsonExporter("Core.Utility.Benchmark")]
    [MarkdownExporter]
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.Method)]
    [StopOnFirstError]
    public abstract class PerfTestRunner
    {

        /// <summary>
        /// The email1
        /// </summary>
        protected const string Email1 = "davidmccarter@live.com";

        /// <summary>
        /// The email2
        /// </summary>
        protected const string Email2 = TestEmailLowerCase;

        /// <summary>
        /// The failed text
        /// </summary>
        protected const string FailedText = "failed";

        /// <summary>
        /// The long test string
        /// </summary>
        protected const string LongTestString = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

        /// <summary>
        /// The lower case string
        /// </summary>
        protected const string LowerCaseString = "david mccarter";

        /// <summary>
        /// The proper case string
        /// </summary>
        protected const string ProperCaseString = "David McCarter";

        /// <summary>
        /// The success text
        /// </summary>
        protected const string SuccessText = "success";

        /// <summary>
        /// The test email lower case
        /// </summary>
        protected const string TestEmailLowerCase = "dotnetdave@live.com";

        /// <summary>
        /// The test email mixed case
        /// </summary>
        protected const string TestEmailMixedCase = "DavidMcCarter@live.com";

        /// <summary>
        /// The upper case string
        /// </summary>
        protected const string UpperCaseString = "DAVID MCCARTER";

        /// <summary>
        /// The test date time offset
        /// </summary>
        protected readonly DateTimeOffset TestDateTimeOffset = DateTimeOffset.Now;

        private readonly Consumer _consumer = new Consumer();

        /// <summary>
        /// The test time span
        /// </summary>
        private TimeSpan _testTimeSpan = new TimeSpan(300, 13, 33, 34, 9876);

        /// <summary>
        /// Gets the consumer.
        /// </summary>
        /// <value>The consumer.</value>
        /// TODO Edit XML Comment Template for Consumer
        protected Consumer Consumer => this._consumer;

        /// <summary>
        /// Gets or sets the test time span.
        /// </summary>
        /// <value>The test time span.</value>
        /// TODO Edit XML Comment Template for TestTimeSpan
        protected TimeSpan TestTimeSpan
        {
            get
            {
                return _testTimeSpan;
            }
            set
            {
                _testTimeSpan = value;
            }
        }

        /// <summary>
        /// Cleanups this instance.
        /// </summary>
        /// TODO Edit XML Comment Template for Cleanup
        public virtual void Cleanup()
        {
            BenchmarkDotNet.Loggers.ConsoleLogger.Default.WriteLine(BenchmarkDotNet.Loggers.LogKind.Info, $"Init() - {this.GetType().FullName}.");
        }

        /// <summary>
        /// Globals the cleanup.
        /// </summary>
        /// TODO Edit XML Comment Template for GlobalCleanup
        [GlobalCleanup]
        public void GlobalCleanup()
        {
            this.Cleanup();
        }

        /// <summary>
        /// Globals the setup.
        /// </summary>
        /// TODO Edit XML Comment Template for GlobalSetup
        [GlobalSetup]
        public void GlobalSetup()
        {
            this.Setup();
        }

        /// <summary>
        /// Setups this instance.
        /// </summary>
        /// TODO Edit XML Comment Template for Setup
        public virtual void Setup()
        {
            // BenchmarkDotNet.Loggers.ConsoleLogger.Default.WriteLine(BenchmarkDotNet.Loggers.LogKind.Info, $"TEST {HostEnvironmentInfo.GetInformation()}.");
            BenchmarkDotNet.Loggers.ConsoleLogger.Default.WriteLine(BenchmarkDotNet.Loggers.LogKind.Info, $"Init() - {this.GetType().FullName}.");
        }

    }
}
