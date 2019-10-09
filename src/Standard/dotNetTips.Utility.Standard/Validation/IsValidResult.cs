// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="IsValidResult.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace dotNetTips.Utility.Standard.Validation
{
    /// <summary>
    /// Class IsValidResult.
    /// </summary>
    public sealed class IsValidResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsValidResult" /> class.
        /// </summary>
        /// <param name="valid">if set to <c>true</c> [valid].</param>
        /// <param name="errors">The errors.</param>
        public IsValidResult(bool valid, params string[] errors)
        {
            this.IsValid = valid;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets the errors.
        /// </summary>
        /// <value>The errors.</value>
        public IEnumerable<string> Errors
        {
            get; private set;
        }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public bool IsValid
        {
            get; private set;
        }
    }
}
