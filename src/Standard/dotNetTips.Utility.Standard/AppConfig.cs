// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-06-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2019
// ***********************************************************************
// <copyright file="AppConfig.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.IO;
using Microsoft.Extensions.Configuration;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class AppConfig.
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// The file name
        /// </summary>
        private const string _fileName = "appsettings.json";

        /// <summary>
        /// Creates a new IConfigurationRoot object for the application that can include environment variables.
        /// </summary>
        /// <param name="addEnvironmentVariables">if set to <c>true</c> [add environment variables].</param>
        /// <returns>IConfigurationRoot</returns>
        public static IConfigurationRoot LoadConfiguration(bool addEnvironmentVariables)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile(_fileName, optional: false, reloadOnChange: true);

            if (addEnvironmentVariables)
            {
                builder.AddEnvironmentVariables();
            }

            return builder.Build();
        }
    }
}
