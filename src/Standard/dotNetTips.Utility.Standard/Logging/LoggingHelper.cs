// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-06-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace dotNetTips.Utility.Standard.Logging
{
    /// <summary>
    /// Class LoggingHelper.
    /// </summary>
    public static class LoggingHelper
    {
        /// <summary>
        /// Retrieves all exception messages.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        public static ImmutableList<string> RetrieveAllExceptionMessages(Exception ex)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(ex != null, nameof(ex));

            var exceptions = RetrieveAllExceptions(ex);
            var messages = new List<string>();

            exceptions.ForEach(exception => messages.Add(ex.Message));

            return messages.ToImmutableList();
        }

        /// <summary>
        /// Retrieves all exceptions (including inner exceptions).
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>IEnumerable&lt;Exception&gt;.</returns>
        public static ImmutableList<Exception> RetrieveAllExceptions(Exception ex)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(ex != null, nameof(ex));

            var collection = new List<Exception>();

            if (ex != null)
            {
                collection = new List<Exception> { ex };

                if (ex.InnerException.IsNotNull())
                {
                    collection.AddRange(RetrieveAllExceptions(ex.InnerException));
                }
            }

            return collection.ToImmutable();
        }
    }
}
