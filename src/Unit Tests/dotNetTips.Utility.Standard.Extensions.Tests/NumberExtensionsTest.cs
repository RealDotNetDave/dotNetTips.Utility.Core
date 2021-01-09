// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="NumberExtensionsTest.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class NumberExtensionsTest
    {

        [TestMethod]
        public void DoubleToFormattedStringTest()
        {
            var testValue = double.Parse("555.555");

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.RoundTrip);
            PrintResult(result, nameof(NumericFormat.RoundTrip));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Decimal));
            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Hexadecimal));

        }

        [TestMethod]
        public void IntToFormattedStringTest()
        {
            var testValue = RandomData.GenerateInteger();

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void IsInRangeThrowsExceptionDecimal()
        {
            decimal number = 10.10m;

            Assert.IsTrue(number.IsInRangeThrowsException(1.10m, 20.55m, "TEST"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => number.IsInRangeThrowsException(122.10m, 22220.55m, "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionDouble()
        {
            var number = 10.10d;

            Assert.IsTrue(number.IsInRangeThrowsException(1.10, 20.55, "TEST"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => number.IsInRangeThrowsException(122.10, 22220.55, "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionInt()
        {
            int number = 10;

            Assert.IsTrue(number.IsInRangeThrowsException(1, 20, "TEST"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => number.IsInRangeThrowsException(122, 22220, "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionLong()
        {
            long number = 10;

            Assert.IsTrue(number.IsInRangeThrowsException(1, 20, "TEST"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => number.IsInRangeThrowsException(122, 22220, "TEST"));
        }
        [TestMethod]
        public void IsNegativeTest()
        {
            const int testNumber = 10;
            const int testBadNumber = -100;

            //Test good number
            Assert.IsFalse(testNumber.IsNegative());

            Assert.IsFalse(Convert.ToDecimal(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToDouble(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToSByte(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToInt64(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToInt16(testNumber).IsNegative());


            //Test bad number
            Assert.IsTrue(testBadNumber.IsNegative());

            Assert.IsTrue(Convert.ToDecimal(testBadNumber).IsNegative());

            Assert.IsTrue(Convert.ToDouble(testBadNumber).IsNegative());

            Assert.IsTrue(Convert.ToSByte(testBadNumber).IsNegative());

            Assert.IsTrue(Convert.ToInt64(testBadNumber).IsNegative());

            Assert.IsTrue(Convert.ToInt16(testBadNumber).IsNegative());
        }

        [TestMethod]
        public void LongToFormattedStringTest()
        {
            var testValue = long.MaxValue / 2000;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void ShortToFormattedStringTest()
        {
            var testValue = short.MaxValue;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 3);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 4);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
        }

        [TestMethod]
        public void UIntToFormattedStringTest()
        {
            var testValue = uint.MaxValue / 200;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void ULongToFormattedStringTest()
        {
            var testValue = ulong.MaxValue / 2000000;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        [TestMethod]
        public void UShortToFormattedStringTest()
        {
            var testValue = ushort.MaxValue;

            var result = testValue.ToFormattedString(NumericFormat.Currency);
            PrintResult(result, nameof(NumericFormat.Currency));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Decimal);
            PrintResult(result, nameof(NumericFormat.Decimal));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Exponential);
            PrintResult(result, nameof(NumericFormat.Exponential));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.FixedPoint);
            PrintResult(result, nameof(NumericFormat.FixedPoint));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.General);
            PrintResult(result, nameof(NumericFormat.General));
            Assert.IsTrue(result.Length > 4);

            result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
            PrintResult(result, nameof(NumericFormat.Hexadecimal));
            Assert.IsTrue(result.Length > 3);

            result = testValue.ToFormattedString(NumericFormat.Number);
            PrintResult(result, nameof(NumericFormat.Number));
            Assert.IsTrue(result.Length > 5);

            result = testValue.ToFormattedString(NumericFormat.Percent);
            PrintResult(result, nameof(NumericFormat.Percent));
            Assert.IsTrue(result.Length > 5);

            Assert.ThrowsException<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

        }

        private static void PrintResult<T>(T input, string methodName)
        {
            var message = $"{methodName}: {input}";

            Debug.WriteLine(message);
        }
    }
}
