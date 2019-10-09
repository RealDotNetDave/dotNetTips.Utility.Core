// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-07-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2019
// ***********************************************************************
// <copyright file="FileProgressState.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Enum ProgressState
    /// </summary>
    public enum FileProgressState
    {
        /// <summary>
        /// The error
        /// </summary>
        Error = 0,

        /// <summary>
        /// The deleted
        /// </summary>
        Deleted = 1,

        /// <summary>
        /// The moved
        /// </summary>
        Moved = 2,

        /// <summary>
        /// The copied
        /// </summary>
        Copied = 3
    }
}
