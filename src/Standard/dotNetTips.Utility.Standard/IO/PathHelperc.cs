// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-11-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="PathHelperc.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Utility.Standard.IO
{
    /// <summary>
    /// Class PathHelper.
    /// </summary>
    public static class PathHelper
    {
        /// <summary>
        /// Checks to see if path contains any wild cards.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool PathContainsWildcard(string path) => ((path?.IndexOf('*') != -1) || (path?.IndexOf('?') != -1));
    }
}
