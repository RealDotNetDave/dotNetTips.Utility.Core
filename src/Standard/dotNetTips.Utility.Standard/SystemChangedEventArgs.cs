// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="SystemChangedEventArgs.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class SystemChangedEventArgs. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class SystemChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the type of the system event.
        /// </summary>
        /// <value>The type of the system event.</value>
        public SystemEventType SystemEventType { get; internal set; }

        /// <summary>
        /// Gets the event information.
        /// </summary>
        /// <value>The event information.</value>
        public IEnumerable<IEventInformation> EventInformation { get; internal set; }
    }
}