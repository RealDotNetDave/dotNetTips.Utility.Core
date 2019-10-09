// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2019
// ***********************************************************************
// <copyright file="AppLogging.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class AppLogging.
    /// </summary>
    public static class AppLogging
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public static ILogger Logger
        {
            get; private set;
        }

        /// <summary>
        /// Gets the logger factory.
        /// </summary>
        /// <value>The logger factory.</value>
        public static ILoggerFactory LoggerFactory { get; private set; } = new LoggerFactory();

        /// <summary>
        /// Creates the logger.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>ILogger.</returns>
        public static ILogger CreateLogger<T>()
        {
            Logger = LoggerFactory.CreateLogger<T>();

            return Logger;
        }

        /// <summary>
        /// Creates the logger.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="loggerFactory">The logger factory.</param>
        /// <returns>Microsoft.Extensions.Logging.ILogger.</returns>
        public static ILogger CreateLogger<T>(ILoggerFactory loggerFactory)
        {
            LoggerFactory = loggerFactory;

            Logger = LoggerFactory.CreateLogger<T>();

            return Logger;
        }
    }
}
