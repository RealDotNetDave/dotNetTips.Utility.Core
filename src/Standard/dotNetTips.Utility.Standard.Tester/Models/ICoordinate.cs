// ***********************************************************************
// Assembly         : dotNetTips.CodePerf.Example.App
// Author           : David McCarter
// Created          : 01-07-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-14-2019
// ***********************************************************************
// <copyright file="ICoordinate.cs" company="dotNetTips.com - McCarter Consulting">
//     2019: David McCarter - McCarter Consulting
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard.Tester.Models
{
    /// <summary>
    /// Interface ICoordinate used to create Coordinate.
    /// </summary>
    public interface ICoordinate
    {
        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        /// <value>The x value.</value>
        int X { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>
        /// <value>The y value.</value>
        int Y { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> of the coordinates.
        /// </summary>
        /// <returns>A <see cref="System.String" /> of the coordinates.</returns>
        string ToString();

    }
}
