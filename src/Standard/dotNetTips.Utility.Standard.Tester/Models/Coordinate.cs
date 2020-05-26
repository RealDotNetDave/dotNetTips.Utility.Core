// ***********************************************************************
// Assembly         : dotNetTips.CodePerf.Example.App
// Author           : David McCarter
// Created          : 01-07-2019
//
// Last Modified By : David McCarter
// Last Modified On : 03-09-2020
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
    public struct Coordinate : ICoordinate, IEquatable<Coordinate>
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
        /// Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Coordinate left, Coordinate right) => left.Equals(right);

        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Coordinate left, Coordinate right) => !(left == right);

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
        public bool Equals(Coordinate other) => this.X == other.X && this.Y == other.Y;

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + this.X.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Y.GetHashCode();
            return hashCode;
        }

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
