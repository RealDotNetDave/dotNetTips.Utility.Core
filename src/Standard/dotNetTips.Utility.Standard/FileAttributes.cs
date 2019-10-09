// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-11-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="FileAttributes.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard
{
    using System;

    /// <summary>
    /// Enum FileAttributes
    /// </summary>
    [Flags]
    public enum FileAttributes
    {
        /// <summary>
        /// Archive
        /// </summary>
        Archive = 0x20,

        /// <summary>
        /// Directory
        /// </summary>
        Directory = 0x10,

        /// <summary>
        /// Hidden
        /// </summary>
        Hidden = 2,

        /// <summary>
        /// Normal
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Read only
        /// </summary>
        ReadOnly = 1,

        /// <summary>
        /// System
        /// </summary>
        System = 4,

        /// <summary>
        /// Volume
        /// </summary>
        Volume = 8
    }
}