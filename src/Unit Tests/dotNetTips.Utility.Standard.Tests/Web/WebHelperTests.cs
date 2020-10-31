using System;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Web
{
    [TestClass]
    public class WebHelperTests
    {
        [TestMethod]
        public void DownloadStringAsyncTest()
        {
            var result = WebHelper.DownloadStringAsync(new Uri(@"https://dotnettips.com"), clientId: "UNITTEST1").Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DownloadStringTest()
        {
            var result = WebHelper.DownloadString(new Uri(@"https://www.google.com/"), clientId: "UNITTEST2");

            Assert.IsTrue(result.HasValue());
        }

        [TestMethod]
        public void GetHeaderNamesTest()
        {
            var result = WebHelper.HttpHeaderNames;

            Assert.IsTrue(result.Count() > 0);
        }
    }
}
