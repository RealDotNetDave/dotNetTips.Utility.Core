using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Helper class for executing methods.
    /// </summary>
    public static class ExecutionHelper
    {
        /// <summary>
        /// Progressives retry for a function call.
        /// </summary>
        /// <param name="operation">The operation to perform.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <param name="retryWaitMilliseconds">The retry wait milliseconds.</param>
        public static int ProgressiveRetry(Action operation, byte retryCount, int retryWaitMilliseconds)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(operation != null);
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(retryCount > 0);
            Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(retryWaitMilliseconds > 0);

            var attempts = 0;

            do
            {
                try
                {
                    attempts++;

                    operation();

                    return attempts;
                }
                catch (Exception ex)
                {
                    if (attempts == retryCount)
                    {
                        throw;
                    }

                    Trace.WriteLine(ex.GetAllMessages());

                    Task.Delay(retryWaitMilliseconds * attempts).Wait();
                }
            } while (true);
        }
    }
}
