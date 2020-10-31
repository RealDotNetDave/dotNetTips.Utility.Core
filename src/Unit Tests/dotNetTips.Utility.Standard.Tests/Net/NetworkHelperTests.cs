using System.Diagnostics;
using dotNetTips.Utility.Standard.Diagnostics;
using dotNetTips.Utility.Standard.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Net
{
    [TestClass]
    public class NetworkHelperTests
    {
        [TestMethod]
        public void IsHostAvailableTest()
        {
            var sw = PerformanceStopwatch.StartNew();

            var result = NetworkHelper.IsHostAvailable("www.google.com", timeout: 500);

            var pingTime = sw.StopReset();

            Debug.WriteLine($"Ping Time = {pingTime.TotalMilliseconds}");

            Assert.IsTrue(result);

            result = NetworkHelper.IsHostAvailable("xxxxxxx.xxxxxxxx.com", 500);

            Assert.IsFalse(result);

            //Google
            result = NetworkHelper.IsHostAvailable("8.8.4.4", timeout: 500);

            Assert.IsTrue(result);

            result = NetworkHelper.IsHostAvailable("8.8.4.4");

            Assert.IsTrue(result);
        }
    }
}
