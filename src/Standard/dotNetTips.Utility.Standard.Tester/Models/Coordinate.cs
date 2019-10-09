// ***********************************************************************
// Assembly         : dotNetTips.CodePerf.Example.App
// Author           : David McCarter
// Created          : 01-07-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-13-2019
// ***********************************************************************
// <copyright file="Coordinate.cs" company="dotNetTips.com - McCarter Consulting">
//     2019: David McCarter - McCarter Consulting
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.Tester.Models
{
    /// <summary>
    /// Struct Coordinate
    /// Implements the <see cref="dotNetTips.Utility.Standard.Tester.Models.ICoordinate" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Tester.Models.ICoordinate" />
    [Serializable]
    public struct Coordinate : ICoordinate
    {
        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        /// <value>The x.</value>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>
        /// <value>The y.</value>
        public int Y { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> of the coordinates.
        /// </summary>
        /// <returns>A <see cref="System.String" /> of the coordinates.</returns>
        public override string ToString()
        {
            return $"{this.X}-{this.Y}";
        }
    }
}
