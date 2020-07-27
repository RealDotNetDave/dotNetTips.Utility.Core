// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 07-27-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-27-2020
// ***********************************************************************
// <copyright file="BooleanExtensionsTests.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class BooleanExtensionsTests
    {
        [TestMethod]
        public void ToLowerCaseTest()
        {
            Assert.IsTrue(string.IsNullOrEmpty(false.ToLowerCase()) == false);

            Assert.IsTrue(string.IsNullOrEmpty(true.ToLowerCase()) == false);
        }
    }
}
