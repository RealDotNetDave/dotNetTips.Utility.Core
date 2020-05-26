// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-26-2020
// ***********************************************************************
// <copyright file="StringType.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace dotNetTips.Utility.Standard.OOP
{
    /// <summary>
    /// Enum for StringType
    /// </summary>

    public enum StringType
    {
        /// <summary>
        /// The not set
        /// </summary>
        NotSet,

        /// <summary>
        /// Validates that string is a email address.
        /// </summary>
        Email,

        /// <summary>
        /// Validates that the string is a Url.
        /// </summary>
        Url
    }
}