using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {

        [TestMethod]
        public void DateTimeGetLastTest()
        {
            var result = DateTime.Now.GetLast(DayOfWeek.Monday);

            this.PrintResult(result, nameof(DateTimeGetLastTest));

            Assert.IsTrue(result <= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeGetNextTest()
        {
            var result = DateTime.Now.GetNext(DayOfWeek.Monday);

            this.PrintResult(result, nameof(DateTimeGetNextTest));

            Assert.IsTrue(result >= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeIntersectsTest()
        {
            var now = DateTime.Now;

            var result = now.Intersects(endDate: now.AddDays(100), intersectingStartDate: now.AddDays(1), intersectingEndDate: now.AddDays(10));

            this.PrintResult(result, nameof(DateTimeIntersectsTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeIsInRangeTest()
        {
            var now = DateTime.Now;

            var result = now.IsInRange(beginningTime: now.Subtract(new TimeSpan(1, 0, 0, 0)), endTime: now.AddDays(10));

            this.PrintResult(result, nameof(DateTimeIsInRangeTest));

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void DateTimeLocalTimeFromUtcTest()
        {
            var now = DateTime.Now;

            var result = now.LocalTimeFromUtc(-5);

            this.PrintResult(result, nameof(DateTimeLocalTimeFromUtcTest));

            Assert.IsTrue(result >= now);
        }

        [TestMethod]
        public void DateTimeMaxTest()
        {
            var now = DateTime.Now;

            var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

            this.PrintResult(result, nameof(DateTimeMaxTest));

            Assert.IsTrue(result == now);
        }

        [TestMethod]
        public void DateTimeNextDayOfTheWeekTest()
        {
            var now = DateTime.Now;

            var result = now.NextDayOfWeek(DayOfWeek.Sunday);

            this.PrintResult(result, nameof(DateTimeNextDayOfTheWeekTest));

            Assert.IsTrue(result >= now);
        }


        [TestMethod]
        public void DateTimeOffsetGetLastDayOfWeekTest()
        {
            var result = DateTimeOffset.Now.GetLastDayOfWeek(DayOfWeek.Monday);

            this.PrintResult(result, nameof(DateTimeOffsetGetLastDayOfWeekTest));

            Assert.IsTrue(result <= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeOffsetGetNextDayOfWeekTest()
        {
            var result = DateTimeOffset.Now.GetNextDayOfWeek(DayOfWeek.Monday);

            this.PrintResult(result, nameof(DateTimeOffsetGetNextDayOfWeekTest));

            Assert.IsTrue(result >= DateTime.Now);
        }

        [TestMethod]
        public void DateTimeOffsetIntersectsTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.Intersects(now.AddDays(100), now.AddDays(1), now.AddDays(10));

            this.PrintResult(result, nameof(DateTimeOffsetIntersectsTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeOffsetIsInRangeTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(10));

            this.PrintResult(result, nameof(DateTimeOffsetIsInRangeTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DateTimeOffsetMaxTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

            this.PrintResult(result, nameof(DateTimeOffsetMaxTest));

            Assert.IsTrue(result == now);
        }

        [TestMethod]
        public void DateTimeOffsetNextDayOfTheWeekTest()
        {
            var now = DateTimeOffset.Now;

            var result = now.NextDayOfWeek(DayOfWeek.Sunday);

            this.PrintResult(result, nameof(DateTimeOffsetNextDayOfTheWeekTest));

            Assert.IsTrue(result >= now);
        }

        [TestMethod]
        public void DateTimeOffsetToFriendlyStringTest()
        {
            var result = DateTimeOffset.Now.ToFriendlyDateString();

            this.PrintResult(result, nameof(DateTimeOffsetToFriendlyStringTest));

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }
        [TestMethod]
        public void DateTimeToFriendlyStringTest()
        {
            var result = DateTime.Now.ToFriendlyDateString();

            this.PrintResult(result, nameof(DateTimeToFriendlyStringTest));

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }

        [TestMethod]
        public void TimeSpanIsInRangeTest()
        {
            var now = new TimeSpan(3, 0, 0, 0);

            var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Multiply(10));

            this.PrintResult(result, nameof(TimeSpanIsInRangeTest));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestDateTime()
        {
            var now = DateTime.Now;

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestDateTimeOffset()
        {
            var now = DateTimeOffset.Now;

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionTestTimeSpan()
        {
            var now = TimeSpan.FromDays(5);

            var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), TimeSpan.FromDays(2).Add(new TimeSpan(1,0,0,0)), "TEST");

            Assert.IsTrue(result1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.Add(new TimeSpan(10, 0, 0, 0)), new TimeSpan(20, 0, 0, 0), "TEST"));
        }

        private void PrintResult<T>(T input, string methodName)
        {
            var message = $"{methodName}: {input}";

            Debug.WriteLine(message);
        }

    }
}
