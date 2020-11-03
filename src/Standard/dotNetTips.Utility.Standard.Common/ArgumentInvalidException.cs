﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-26-2019
// ***********************************************************************
// <copyright file="ArgumentInvalidException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

namespace dotNetTips.Utility.Standard.Common
{
    /// <summary>
    /// Class ArgumentIsInvalidException.
    /// </summary>
    /// <seealso cref="System.ArgumentException" />
    [Serializable]
    public sealed class ArgumentInvalidException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
        /// </summary>
        public ArgumentInvalidException() : base(Resources.GoToDotNetTipsComForHelp)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ArgumentInvalidException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class that accepts a message an inner exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public ArgumentInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="paramName">The name of the parameter that caused the current exception.</param>
        public ArgumentInvalidException(string message, string paramName) : base(message, paramName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentInvalidException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="paramName">The name of the parameter that caused the current exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public ArgumentInvalidException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentInvalidException"></see> class with serialized data.</summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        private ArgumentInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}