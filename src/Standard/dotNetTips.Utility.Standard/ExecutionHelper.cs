// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2020
// ***********************************************************************
// <copyright file="ExecutionHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// Progressive retry for a function call.
        /// </summary>
        /// <param name="operation">The operation to perform.</param>
        /// <param name="retryCount">The retry count (default 3).</param>
        /// <param name="retryWaitMilliseconds">The retry wait milliseconds (default 100).</param>
        /// <returns>System.Int32.</returns>
        public static int ProgressiveRetry(Action operation, byte retryCount = 3, int retryWaitMilliseconds = 100)
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

                    Debug.WriteLine(ex.GetAllMessages());

                    Task.Delay(retryWaitMilliseconds * attempts).Wait();
                }
            } while (true);
        }
    }
}
