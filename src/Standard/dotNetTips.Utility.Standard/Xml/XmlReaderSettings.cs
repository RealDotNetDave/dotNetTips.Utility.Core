// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-09-2020
// ***********************************************************************
// <copyright file="XmlReaderSettings.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard.Xml
{
    /// <summary>
    /// Class XmlReaderSettings.
    /// </summary>
    internal class XmlReaderSettings
    {
        /// <summary>
        /// Gets or sets the DTD processing.
        /// </summary>
        /// <value>The DTD processing.</value>
        public object DtdProcessing { get; set; }

        /// <summary>
        /// Gets or sets the XML resolver.
        /// </summary>
        /// <value>The XML resolver.</value>
        public object XmlResolver { get; set; }
    }
}
