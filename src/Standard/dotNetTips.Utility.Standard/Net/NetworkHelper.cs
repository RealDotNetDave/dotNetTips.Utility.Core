// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-31-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-08-2020
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using System.Net.NetworkInformation;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Class NetworkHelper.
    /// </summary>
    public static class NetworkHelper
    {
        /// <summary>
        /// Determines whether [is host available] [the specified host name or address].
        /// </summary>
        /// <param name="hostNameOrAddress">The host name or address.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns><c>true</c> if [is host available] [the specified host name or address]; otherwise, <c>false</c>.</returns>
        public static bool IsHostAvailable(string hostNameOrAddress, int timeout)
        {
            Encapsulation.TryValidateParam(hostNameOrAddress, nameof(hostNameOrAddress));

            using (var pinger = new Ping())
            {
                var result = pinger.Send(hostNameOrAddress, timeout);

                return result.Status == IPStatus.Success;
            }
        }

        /// <summary>
        /// Determines whether [is host available] [the specified host name or address].
        /// </summary>
        /// <param name="hostNameOrAddress">The host name or address.</param>
        /// <returns><c>true</c> if [is host available] [the specified host name or address]; otherwise, <c>false</c>.</returns>
        /// <remarks>Uses a 300 millisecond timeout.</remarks>
        public static bool IsHostAvailable(string hostNameOrAddress)
        {
            return IsHostAvailable(hostNameOrAddress, 300);
        }
    }
}
