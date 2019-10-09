// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="SystemEventType.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Enum SystemEventType
    /// </summary>
    public enum SystemEventType
    {

        /// <summary>
        /// System Event not selected.
        /// </summary>
        None,

        /// <summary>
        /// The network address changed
        /// </summary>
        NetworkAddressChanged,

        /// <summary>
        /// The network availability changed
        /// </summary>
        NetworkAvailabilityChanged,

        /// <summary>
        /// Unhandled Exception
        /// </summary>
        UnhandledException
    }
}