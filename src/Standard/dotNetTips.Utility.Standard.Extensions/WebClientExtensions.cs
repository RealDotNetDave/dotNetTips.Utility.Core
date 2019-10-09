// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="WebClientExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class WebClientExtensions.
    /// </summary>
    public static class WebClientExtensions
    {
        /// <summary>
        /// Gets the json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">The client.</param>
        /// <param name="url">The URL.</param>
        /// <returns>T.</returns>
        public static T ConvertFrom<T>(this WebClient client, string url)
            where T : class
        {
            var data = client.DownloadString(url);

            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                var obj = (T)serializer.ReadObject(stream);

                stream.Flush();
                stream.Close();

                return obj;
            }
        }
    }
}