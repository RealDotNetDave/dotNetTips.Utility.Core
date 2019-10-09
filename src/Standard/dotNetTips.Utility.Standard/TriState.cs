// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-11-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="TriState.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Enum TriState
    /// </summary>
    public enum Tristate
    {
        /// <summary>
        /// False
        /// </summary>
        False = 0,

        /// <summary>
        /// True
        /// </summary>
        True = -1,

        /// <summary>
        /// Use default
        /// </summary>
        UseDefault = -2
    }
}