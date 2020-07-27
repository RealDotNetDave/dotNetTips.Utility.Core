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

            Assert.IsFalse(testNumber.IsNegative());

            Assert.IsFalse(Convert.ToDecimal(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToDouble(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToSByte(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToInt64(testNumber).IsNegative());

            Assert.IsFalse(Convert.ToInt16(testNumber).IsNegative());
        }
    }
}
