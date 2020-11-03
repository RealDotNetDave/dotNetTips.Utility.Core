﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-09-2018
//
// Last Modified By : David McCarter
// Last Modified On : 02-12-2020
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard
{

    /// <summary>
    /// Class UnhandledExceptionEventInformation.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.IEventInformation" />
    public sealed class UnhandledExceptionEventInformation : IEventInformation
    {
        /// <summary>
        /// Gets a value indicating whether [network available].
        /// </summary>
        /// <value><c>true</c> if [network available]; otherwise, <c>false</c>.</value>
        public bool IsTerminating { get; internal set; }

        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        public LoggableException Exception { get; internal set; }
    }

}