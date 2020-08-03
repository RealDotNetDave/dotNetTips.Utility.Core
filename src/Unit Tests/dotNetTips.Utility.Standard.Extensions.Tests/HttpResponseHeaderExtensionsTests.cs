using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Standard.Extensions;
using System;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class HttpResponseHeaderExtensionsTests
    {
        [TestMethod]
        public void GetNameTest()
        {
            foreach (var name in Enum.GetNames(typeof(HttpResponseHeader)))
            {
                if (Enum.TryParse<HttpResponseHeader>(name, out HttpResponseHeader result))
                {
                    Assert.IsTrue(result.GetName().Length > 0);
                }
            }
        }
    }
}
