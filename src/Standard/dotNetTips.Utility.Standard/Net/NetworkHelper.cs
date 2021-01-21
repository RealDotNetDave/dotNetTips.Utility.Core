// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-31-2018
//
// Last Modified By : David McCarter
// Last Modified On : 11-19-2020
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Net.NetworkInformation;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Network helper methods.
    /// </summary>
    public static class NetworkHelper
    {

        /// <summary>
        /// Determines whether [is host available] [the specified host name or address].
        /// </summary>
        /// <param name="hostNameOrAddress">The host name or address.</param>
        /// <returns><c>true</c> if [is host available] [the specified host name or address]; otherwise, <c>false</c>.</returns>
        /// <remarks>Uses a 300 millisecond timeout.</remarks>
        [Information(UnitTestCoverage = 100, Status = Status.Available)]
        public static bool IsHostAvailable(string hostNameOrAddress)
        {
            Encapsulation.TryValidateParam(hostNameOrAddress, nameof(hostNameOrAddress));

            return IsHostAvailable(hostNameOrAddress, 300);
        }

        /// <summary>
        /// Determines whether [is host available] [the specified host name or address].
        /// </summary>
        /// <param name="hostNameOrAddress">The host name or address.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns><c>true</c> if [is host available] [the specified host name or address]; otherwise, <c>false</c>.</returns>
        [Information(UnitTestCoverage = 100, Status = Status.Available)]
        public static bool IsHostAvailable(string hostNameOrAddress, int timeout)
        {
            Encapsulation.TryValidateParam(hostNameOrAddress, nameof(hostNameOrAddress));
            Encapsulation.TryValidateParam(timeout, minimumValue: 10, maximumValue: int.MaxValue, paramName: nameof(timeout));

            try
            {
                using (var pinger = new Ping())
                {
                    var result = pinger.Send(hostNameOrAddress, timeout);

                    return result.Status == IPStatus.Success;
                }
            }
            catch (PingException pingEx)
            {
                Trace.WriteLine(pingEx.Message);
                return false;
            }
        }
    }
}
