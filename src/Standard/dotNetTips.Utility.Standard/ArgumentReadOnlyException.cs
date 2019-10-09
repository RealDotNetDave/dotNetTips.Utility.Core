// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-23-2019
// ***********************************************************************
// <copyright file="ArgumentReadOnlyException.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ArgumentIsReadOnlyException.
    /// </summary>
    /// <seealso cref="System.ArgumentException" />
    /// <seealso cref="System.Exception" />
    [Serializable]
    public sealed class ArgumentReadOnlyException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        public ArgumentReadOnlyException() : base("Go to dotNetTips.com!")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ArgumentReadOnlyException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        public ArgumentReadOnlyException(string paramName, string message) : base(paramName, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in
        /// Visual Basic) if no inner exception is specified.</param>
        public ArgumentReadOnlyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentReadOnlyException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="paramName">The name of the parameter that caused the current exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
        public ArgumentReadOnlyException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }
    }
}