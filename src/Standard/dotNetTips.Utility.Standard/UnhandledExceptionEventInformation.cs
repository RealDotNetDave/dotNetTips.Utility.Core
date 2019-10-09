// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-09-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class SystemEvents.
    /// </summary>
    public static partial class SystemEvents
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
}