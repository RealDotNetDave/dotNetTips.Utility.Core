// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2020
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Common;
using Microsoft.AspNetCore.Http;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// HttpContext Extensions.
    /// </summary>
    public static class HttpContextExtensions
    {
        /// <summary>
        /// Gets the remote ip address.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>System.String.</returns>
        [Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", "9/04/2020", UnitTestCoverage = 0, Status = Status.New)]
        public static string GetRemoteIPAddress(this HttpContext context)
        {
            return context.Connection.RemoteIpAddress.ToString();
        }
    }
}
