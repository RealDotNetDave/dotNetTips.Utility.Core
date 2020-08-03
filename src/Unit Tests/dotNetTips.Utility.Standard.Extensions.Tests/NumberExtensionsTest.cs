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
    }
}
