// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 06-06-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="ConfigurationBuilderExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Configuration;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ConfigurationBuilderExtensions.
    /// </summary>
    public static class ConfigurationBuilderExtensions
    {
        /// <summary>
        /// Loads the configuration section based on the name of the type of T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="config">The configuration.</param>
        /// <returns>T.</returns>
        public static T LoadSection<T>(this IConfigurationRoot config) where T : class, new()
        {
            config.Bind(TypeExtensions.Create<T>());
            return config.GetSection(typeof(T).Name).Get<T>();
        }
    }
}
