// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 07-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Net;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class HttpResponseHeaderExtensions.
    /// </summary>
    public static class HttpResponseHeaderExtensions
    {

        private static readonly string[] _headerNames = {
            "Cache-Control",
            "Connection",
            "Date",
            "Keep-Alive",
            "Pragma",
            "Trailer",
            "Transfer-Encoding",
            "Upgrade",
            "Via",
            "Warning",
            "Allow",
            "Content-Length",
            "Content-Type",
            "Content-Encoding",
            "Content-Language",
            "Content-Location",
            "Content-MD5",
            "Content-Range",
            "Expires",
            "Last-Modified",
            "Accept-Ranges",
            "Age",
            "ETag",
            "Location",
            "Proxy-Authenticate",
            "Retry-After",
            "Server",
            "Set-Cookie",
            "Vary",
            "WWW-Authenticate",
        };

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <param name="header">The header.</param>
        /// <returns>System.String.</returns>
        /// <remarks>NEW</remarks>
        public static string GetName(this HttpResponseHeader header)
        {
            return _headerNames[(int)header];
        }

    }
}
