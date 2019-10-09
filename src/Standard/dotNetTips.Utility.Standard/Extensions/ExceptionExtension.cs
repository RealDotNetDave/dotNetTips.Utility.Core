// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-22-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2017
// ***********************************************************************
// <copyright file="ExceptionExtension.cs" company="dotNetTips.Utility.Standard">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ExceptionExtension.
    /// </summary>
    public static class ExceptionExtension
    {
        #region Public Methods

        /// <summary>
        /// Traverses Exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex">The ex.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">ex - Exception cannot be null.</exception>
        public static T TraverseFor<T>(this Exception ex) where T : class
        {
            if (ex == null)
            {
                throw new ArgumentNullException(nameof(ex), "Exception cannot be null.");
            }

            if (ReferenceEquals(ex.GetType(), typeof(T)))
            {
                return ex as T;
            }

            return ex.InnerException.TraverseFor<T>() as T;
        }

        #endregion Public Methods
    }
}