// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 07-29-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-29-2020
// ***********************************************************************
// <copyright file="SocketsHelperTests.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Net
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class SocketsHelperTests
    {
        [TestMethod]
        public void Test()
        {
            var result = SocketsHelper.CreateAndStartTcpListenerOnAnonymousPort();

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.listener);
            Assert.IsTrue(result.port > 0);

            result.listener.Stop();
        }
    }
}
