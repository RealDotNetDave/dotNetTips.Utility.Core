// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="AppInfo.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Globalization;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Info.
    /// </summary>
    public class AppInfo
    {
        /// <summary>
        /// Gets the company.
        /// </summary>
        /// <value>The company.</value>
        public string Company
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public string Configuration
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the copyright.
        /// </summary>
        /// <value>The copyright.</value>
        public string Copyright
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the culture.
        /// </summary>
        /// <value>The culture.</value>
        public string Culture
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the file version.
        /// </summary>
        /// <value>The file version.</value>
        public string FileVersion
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the assembly product.
        /// </summary>
        /// <value>The assembly product.</value>
        public string Product
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the assembly title.
        /// </summary>
        /// <value>The assembly title.</value>
        public string Title
        {
            get; internal set;
        }

        /// <summary>
        /// Gets the assembly version.
        /// </summary>
        /// <value>The assembly version.</value>
        public string Version
        {
            get; internal set;
        }

        /// <summary>
        /// Names the application name and version.
        /// </summary>
        /// <returns>System.String.</returns>
        public string NameAndVersion()
        {
            return string.Format(CultureInfo.CurrentCulture, Properties.Resources.AppNameAndVersion, (object)this.Product, (object)this.Version);
        }
    }
}
