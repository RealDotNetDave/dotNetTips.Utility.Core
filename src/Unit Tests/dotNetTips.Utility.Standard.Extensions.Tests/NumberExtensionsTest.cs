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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class NumberExtensionsTest
    {
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
        public void IsInRangeThrowsExceptionDecimal()
        {
            decimal number = 10.10m;

            Assert.IsTrue(number.IsInRangeThrowsException(1.10m, 20.55m, "TEST"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>number.IsInRangeThrowsException(122.10m, 22220.55m, "TEST"));
        }

        [TestMethod]
        public void IsInRangeThrowsExceptionDouble()
        {
            double number = 10.10;

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
    }
}
