// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class ColorExtensions.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Averages the specified colors in the collection.
        /// </summary>
        /// <param name="colors">The colors.</param>
        /// <returns>Color.</returns>
        /// <exception cref="ArgumentOutOfRangeException">colors - colors.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">colors - colors.</exception>
        /// <exception cref="ArgumentNullException">colors - colors.</exception>
        public static Color Average(this IEnumerable<Color> colors)
        {
            if (colors.HasItems() == false)
            {
                throw new ArgumentOutOfRangeException(nameof(colors), $"{nameof(colors)} does not contain items.");
            }

            var r = colors.Average(c => c.R).Round();
            var g = colors.Average(c => c.G).Round();
            var b = colors.Average(c => c.B).Round();

            return Color.FromArgb(r, g, b);
        }
    }
}
