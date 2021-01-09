using System.Diagnostics.CodeAnalysis;
using System.Threading;
using dotNetTips.Utility.Standard.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Net
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CountdownTimerTests
    {

        private const int _defaultTimeout = 1001;
        private static readonly TimerQueue _defaultTimerQueue = CountdownTimer.GetOrCreateQueue(_defaultTimeout);
        static readonly CountdownTimer.Callback _timerCallback = new CountdownTimer.Callback(TimerCallback);
        private CancellationTimer _timer;

        public static void TimerCallback(CancellationTimer timer, int timeNoticed, object context)
        {
            Assert.IsTrue(timer.HasExpired);
            Assert.IsTrue(context.ToString() == "DATA");
        }

        [TestMethod]
        public void CountdownTimerTest()
        {
            this._timer = _defaultTimerQueue.CreateTimer(_timerCallback, "DATA");

            while (this._timer.HasExpired == false)
            {
                Thread.Sleep(5);
            }

            Assert.IsTrue(this._timer.HasExpired);

        }
    }
}
