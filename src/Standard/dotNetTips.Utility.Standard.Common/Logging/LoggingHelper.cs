// ***********************************************************************
// Assembly         : dotNetTip.Utility.Standard.Common
// Author           : David McCarter
// Created          : 07-30-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2020
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;

namespace dotNetTips.Utility.Standard.Common.Logging
{
	/// <summary>
	/// Logging Helper.
	/// </summary>
	public static class LoggingHelper
	{
		/// <summary>
		/// Retrieves all exception messages.
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		public static string[] RetrieveAllExceptionMessages(Exception ex)
		{
			if (ex == null)
			{
				ExceptionThrower.ThrowArgumentNullException(Resources.ExMessageNullException, nameof(ex));
			}

#pragma warning disable CS8604 // Possible null reference argument.
			var exceptions = RetrieveAllExceptions(ex);
#pragma warning restore CS8604 // Possible null reference argument.

			var messages = new string[exceptions.Length];

			for (var i = 0; i < exceptions.Length; i++)
			{
				messages[i] = exceptions[i].Message;
			}

			return messages;
		}

		/// <summary>
		/// Retrieves all exceptions (including inner exceptions).
		/// </summary>
		/// <param name="ex">The ex.</param>
		/// <returns>IEnumerable&lt;Exception&gt;.</returns>
		public static Exception[] RetrieveAllExceptions(Exception ex)
		{
			if (ex == null)
			{
				ExceptionThrower.ThrowArgumentNullException(Resources.ExMessageNullException, nameof(ex));
			}

			var collection = new List<Exception>();

			if (ex != null)
			{
				collection = new List<Exception> { ex };

				if (ex.InnerException is null == false)
				{
					collection.AddRange(RetrieveAllExceptions(ex.InnerException));
				}
			}

			return collection.ToArray();
		}
	}
}
