using System.Threading;
using static dotNetTips.Utility.Standard.Net.CountdownTimer;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// <para>A special dummy implementation for a queue of timers of infinite duration.</para>
    /// </summary>
    public class InfiniteTimerQueue : CountdownTimerQueue
    {
        public InfiniteTimerQueue() : base(Timeout.Infinite) { }

        /// <summary>
        /// <para>Always returns a dummy infinite timer.</para>
        /// </summary>
        public override CancelationTimer CreateTimer(Callback callback, object context) => new InfiniteTimer();
    }
}
