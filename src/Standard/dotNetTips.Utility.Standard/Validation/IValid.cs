// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="IValid.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Validation;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Interface IValid
    /// </summary>
    public interface IValid
    {
        /// <summary>
        /// Returns true if type is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        IsValidResult IsValid
        {
            get;
        }
    }
}
