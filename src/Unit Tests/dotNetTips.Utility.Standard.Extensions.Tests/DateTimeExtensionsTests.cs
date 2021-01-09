using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DateTimeExtensionsTests
    {

        [TestMethod]
        public void DateTimeGetLastTest()
        {
            var result = DateTime.Now.GetLast(DayOfWeek.Monday);

            PrintResult(result, nameof(this.DateTimeGetLastTest));

            Assert.IsTrue(result <= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeGetNextTest()
        {
            var result = DateTime.Now.GetNext(DayOfWeek.Monday);

            PrintResult(result, nameof(this.DateTimeGetNextTest));

            Assert.IsTrue(result >= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeToFormattedStringTest()
        {
            var now = DateTime.Now;

            var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

            PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

            PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.FullDateTime);

            PrintResult(result, nameof(DateTimeFormat.FullDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

            PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

            PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.Jan01Comma2020);

            PrintResult(result, nameof(DateTimeFormat.Jan01Comma2020));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.Janurary01Comma2020);

            PrintResult(result, nameof(DateTimeFormat.Janurary01Comma2020));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.LongDate);

            PrintResult(result, nameof(DateTimeFormat.LongDate));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.LongTime);

            PrintResult(result, nameof(DateTimeFormat.LongTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.MonthDay);

            PrintResult(result, nameof(DateTimeFormat.MonthDay));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.RFC1123);

            PrintResult(result, nameof(DateTimeFormat.RFC1123));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

            PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.ShortDate);

            PrintResult(result, nameof(DateTimeFormat.ShortDate));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.ShortTime);

            PrintResult(result, nameof(DateTimeFormat.ShortTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

            PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

            PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

            Assert.IsTrue(result.Length > 5);

            result = now.ToFormattedString(DateTimeFormat.MonthYear);

            PrintResult(result, nameof(DateTimeFormat.MonthYear));

            Assert.IsTrue(result.Length > 5);
        }

        private static void PrintResult<T>(T input, string methodName)
        {
            var message = $"{methodName}: {input}";

            Debug.WriteLine(message);
        }
    }
}
