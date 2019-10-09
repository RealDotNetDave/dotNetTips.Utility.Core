// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using dotNetTips.Utility.Standard.Extensions.Properties;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ExceptionExtension.
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Hierarchy.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="nextItem">The next item.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItem)
            where TSource : class => FromHierarchy(source, nextItem, s => s != null);

        /// <summary>
        /// Hierarchy.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="nextItem">The next item.</param>
        /// <param name="canContinue">The can continue.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">canContinue
        /// or
        /// nextItem</exception>
        /// <exception cref="System.ArgumentNullException">canContinue
        /// or
        /// nextItem</exception>
        public static IEnumerable<TSource> FromHierarchy<TSource>(this TSource source, Func<TSource, TSource> nextItem, Func<TSource, bool> canContinue)
        {
            if (canContinue == null)
            {
                throw new ArgumentNullException(nameof(canContinue), $"{nameof(canContinue)} is null.");
            }

            if (nextItem == null)
            {
                throw new ArgumentNullException(nameof(nextItem), $"{nameof(nextItem)} is null.");
            }

            for (var current = source; canContinue(current); current = nextItem(current))
            {
                yield return current;
            }
        }

        /// <summary>
        /// Gets all messages.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>System.String.</returns>
        public static string GetAllMessages(this Exception exception) => GetAllMessages(exception, Environment.NewLine);

        /// <summary>
        /// Gets all messages.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>System.String.</returns>
        public static string GetAllMessages(this Exception exception, string separator = " ")
        {
            var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

            return string.Join(separator, messages);
        }

        /// <summary>
        /// Traverses Exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex">The ex.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">ex - Exception cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">ex - Exception cannot be null.</exception>
        public static T TraverseFor<T>(this Exception ex)
            where T : class
        {
            if (ex is null)
            {
                throw new ArgumentNullException(nameof(ex), Resources.ExceptionCannotBeNull);
            }

            if (ReferenceEquals(ex.GetType(), typeof(T)))
            {
                return ex as T;
            }

            return ex.InnerException.TraverseFor<T>();
        }
    }
}