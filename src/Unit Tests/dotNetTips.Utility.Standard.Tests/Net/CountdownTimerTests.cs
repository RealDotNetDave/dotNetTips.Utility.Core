using System.Threading;
using dotNetTips.Utility.Standard.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Net
{
    [TestClass]
    public class CountdownTimerTests
    {
        [TestMethod]
        public void CountdownTimerTest()
        {
            _timer = _defaultTimerQueue.CreateTimer(_timerCallback, "DATA");

            while (_timer.HasExpired == false)
            {
                Thread.Sleep(5);
            }

            Assert.IsTrue(_timer.HasExpired);

        }

        private const int _defaultTimeout = 1001;
        private static readonly TimerQueue _defaultTimerQueue = CountdownTimer.GetOrCreateQueue(_defaultTimeout);
        private dotNetTips.Utility.Standard.Net.CancelationTimer _timer;
        private static CountdownTimer.Callback _timerCallback = new CountdownTimer.Callback(TimerCallback);

        public static void TimerCallback(dotNetTips.Utility.Standard.Net.CancelationTimer timer, int timeNoticed, object context)
        {
            Assert.IsTrue(timer.HasExpired);
            Assert.IsTrue(context.ToString() == "DATA");
        }
    }
}
