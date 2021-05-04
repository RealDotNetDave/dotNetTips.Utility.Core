// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-20-2018
//
// Last Modified By : David McCarter
// Last Modified On : 11-19-2020
// ***********************************************************************
// <copyright file="MessageNotQueuedException.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

namespace dotNetTips.Utility.Standard.Common
{
	/// <summary>
	/// Class MessageNotQueuedException.
	/// Implements the <see cref="dotNetTips.Utility.Standard.Common.LoggableException" />.
	/// </summary>
	/// <seealso cref="dotNetTips.Utility.Standard.Common.LoggableException" />
	/// <seealso cref="System.Exception" />
	[Serializable]
	public class MessageNotQueuedException : LoggableException
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		public MessageNotQueuedException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public MessageNotQueuedException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageId">The message identifier.</param>
		public MessageNotQueuedException(string message, string messageId)
			: base(message)
		{
			this.MessageId = messageId;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The inner exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
		public MessageNotQueuedException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="messageId">The message identifier.</param>
		/// <param name="innerException">The inner exception.</param>
		public MessageNotQueuedException(string message, string messageId, Exception innerException)
			: base(message, innerException)
		{
			this.MessageId = messageId;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MessageNotQueuedException" /> class.
		/// </summary>
		/// <param name="serializationInfo">The serialization information.</param>
		/// <param name="streamingContext">The streaming context.</param>
		/// <exception cref="System.NotImplementedException">The exception.</exception>
		/// <exception cref="System.NotImplementedException">The exception.</exception>
		protected MessageNotQueuedException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		/// <summary>
		/// Gets the message identifier.
		/// </summary>
		/// <value>The message identifier.</value>
		public string MessageId { get; private set; }
	}
}
