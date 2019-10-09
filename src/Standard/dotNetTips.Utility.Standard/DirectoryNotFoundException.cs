// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-06-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="DirectoryNotFoundException.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class DirectoryNotFoundException.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.LoggableException" />
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class DirectoryNotFoundException : LoggableException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class.
        /// </summary>
        public DirectoryNotFoundException()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="info">info</paramref> parameter is null.</exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">The class name is null or <see cref="System.Exception.HResult"></see> is zero (0).</exception>
        protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="directory">The directory.</param>
        public DirectoryNotFoundException(string message, string directory) : base(message)
        {
            this.Directory = directory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNotFoundException"></see> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="directory">The directory.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public DirectoryNotFoundException(string message, string directory, Exception innerException) : base(message, innerException)
        {
            this.Directory = directory;
        }

        /// <summary>
        /// Gets the directory.
        /// </summary>
        /// <value>The directory.</value>
        public string Directory { get; private set; }
    }
}
