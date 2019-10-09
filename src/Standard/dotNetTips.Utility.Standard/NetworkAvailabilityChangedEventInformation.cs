// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="NetworkAvailabilityChangedEventInformation.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class NetworkAvailabilityChangedEventInformation.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.IEventInformation" />
    public sealed class NetworkAvailabilityChangedEventInformation : IEventInformation
    {
        /// <summary>
        /// Gets a value indicating whether [network available].
        /// </summary>
        /// <value><c>true</c> if [network available]; otherwise, <c>false</c>.</value>
        public bool NetworkAvailable { get; internal set; }
    }
}