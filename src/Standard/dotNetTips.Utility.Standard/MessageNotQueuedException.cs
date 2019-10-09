// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-20-2018
//
// Last Modified By : David McCarter
// Last Modified On : 09-23-2019
// ***********************************************************************
// <copyright file="MessageNotQueuedException.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class MessageNotQueuedException.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.LoggableException" />
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class MessageNotQueuedException : LoggableException
    {
        /// <summary>
        /// Gets the message identifier.
        /// </summary>
        /// <value>The message identifier.</value>
        public string MessageId { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
        /// </summary>
        public MessageNotQueuedException()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="messageId">The message identifier.</param>
        public MessageNotQueuedException(string message, string messageId) : base(message)
        {
            this.MessageId = messageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="messageId">The message identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public MessageNotQueuedException(string message, string messageId, Exception innerException) : base(message, innerException)
        {
            this.MessageId = messageId;
        }
    }
}
