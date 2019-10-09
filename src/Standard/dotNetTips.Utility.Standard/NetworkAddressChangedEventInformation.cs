// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="NetworkAddressChangedEventInformation.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Net.NetworkInformation;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class NetworkAddressChangedEventInformation.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.IEventInformation" />
    public sealed class NetworkAddressChangedEventInformation : IEventInformation
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the operational status.
        /// </summary>
        /// <value>The operational status.</value>
        public OperationalStatus OperationalStatus { get; internal set; }
    }
}