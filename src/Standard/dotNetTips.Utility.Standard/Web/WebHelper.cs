// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 09-02-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-04-2020
// ***********************************************************************
// <copyright file="WebHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Net;
using System.Threading.Tasks;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using Microsoft.AspNetCore.Http;

namespace dotNetTips.Utility.Standard.Web
{
    /// <summary>
    /// Class WebHelper.
    /// </summary>
    [Information("From dotNetTips.Utility", "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = 0)]
    public static class WebHelper
    {

        /// <summary>
        /// Gets the HTTP header names.
        /// </summary>
        /// <value>The HTTP header names.</value>
        [Information("From dotNetTips.Utility", "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = 0)]
        public static string[] HttpHeaderNames { get; } = Enum.GetNames(typeof(HttpRequestHeader));

        /// <summary>
        /// Downloads the string.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>System.String.</returns>
        public static string DownloadString(Uri address, string clientId = "NONE")
        {
            Encapsulation.TryValidateParam(address, nameof(address));

            // TODO: CHANGE TO HTTPCLIENT
            using (var client = new WebClient())
            {
                if (clientId.HasValue())
                {
                    client.Headers.Add("CLIENTID", clientId);
                }

                // Download the data
                return client.DownloadString(address);
            }
        }

        /// <summary>
        /// download string as an asynchronous operation.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>System.String.</returns>
        [Information("From dotNetTips.Utility", "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = 0)]
        public static async Task<string> DownloadStringAsync(Uri address, string clientId = "NONE")
        {
            Encapsulation.TryValidateParam(address, nameof(address));

            // TODO: CHANGE TO HTTPCLIENT
            using (var client = new WebClient())
            {
                if (clientId.HasValue())
                {
                    client.Headers.Add("CLIENTID", clientId);
                }

                // Download the data
                return await client.DownloadStringTaskAsync(address).ConfigureAwait(false);
            }
        }

        // public static async Task<TResult> PostAsync<TResult>(Uri address, HttpContent content)
        // {
        //    Encapsulation.TryValidateParam(address, nameof(address));
        //    Encapsulation.TryValidateParam<ArgumentNullException>(content!= null, nameof(content));

        // using (var client = new HttpClient())
        //    {
        //        var result = await client.PostAsync(address, content).ConfigureAwait(true);

        // if (result.IsSuccessStatusCode)
        //        {
        //            var resultResponse = await result.Content.ReadAsStringAsync().ConfigureAwait(true);

        // return JsonSerializer.Deserialize<TResult>(resultResponse);
        //        }
        //    }
        // }

        /// <summary>
        /// Determines whether the url is from the local server.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="request">The context.</param>
        /// <returns><c>true</c> if [is local URL] [the specified URL]; otherwise, <c>false</c>.</returns>
        /// <remarks>If you are using .NET 4 or above or .NET Core, this check is not needed unless you have turned
        /// off validation in the config file or in classes.</remarks>
        [Information(nameof(IsLocalUrl), author: "David McCarter", createdOn: "9/12/2020", modifiedOn: "9/14/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool IsLocalUrl(string url, HttpRequest request)
        {
            Encapsulation.TryValidateParam(url, nameof(url));
            Encapsulation.TryValidateParam<ArgumentNullException>(request.IsNotNull(), nameof(request));

            if (Uri.TryCreate(url, UriKind.Absolute, out var absoluteUri))
            {
                var validHostName = String.Equals(request.Host.ToUriComponent(),
                                                   absoluteUri.Host,
                                                   StringComparison.OrdinalIgnoreCase);

                return validHostName;
            }
            else
            {
                var isLocal = !url.StartsWith("http:", StringComparison.OrdinalIgnoreCase) &&
                    !url.StartsWith("https:", StringComparison.OrdinalIgnoreCase) &&
                    Uri.IsWellFormedUriString(url, UriKind.Relative);

                return isLocal;
            }
        }
    }
}
