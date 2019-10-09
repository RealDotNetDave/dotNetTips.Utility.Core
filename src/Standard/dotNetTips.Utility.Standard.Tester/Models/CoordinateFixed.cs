// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-26-2019
// ***********************************************************************
// <copyright file="CoordinateFixed.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace dotNetTips.Utility.Standard.Tester.Models
{
    /// <summary>
    /// Struct CoordinateFixed
    /// Implements the <see cref="dotNetTips.Utility.Standard.Tester.Models.ICoordinate" />
    /// Implements the <see cref="System.IComparable" />
    /// </summary>
    /// <seealso cref="System.IComparable" />
    /// <seealso cref="dotNetTips.Utility.Standard.Tester.Models.ICoordinate" />
    [Serializable]
    public struct CoordinateFixed : ICoordinate, IEquatable<CoordinateFixed>, IComparable, IComparable<CoordinateFixed>
    {
        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="cord1">The first coordinate.</param>
        /// <param name="cord2">The second coordinate.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CoordinateFixed cord1, CoordinateFixed cord2)
        {
            return !(cord1 == cord2);
        }

        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="cord1">The first coordinate.</param>
        /// <param name="cord2">The second coordinate.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CoordinateFixed cord1, CoordinateFixed cord2)
        {
            return cord1.Equals(cord2);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return obj is CoordinateFixed && this.Equals((CoordinateFixed)obj);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <returns>True if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
        public bool Equals(CoordinateFixed other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            //TODO: CHANGE TO HashCode.Combine(Email, Id)
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + this.X.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Y.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Returns a <see cref="string" /> of the coordinates.
        /// </summary>
        /// <returns>A <see cref="string" /> of the coordinates.</returns>
        public override string ToString()
        {
            return $"{this.X}-{this.Y}";
        }

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
        /// Compares to.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentException">obj</exception>
        public int CompareTo(object obj)
        {
            if (!(obj is CoordinateFixed))
            {
                throw new ArgumentException(nameof(obj) + " is not a " + nameof(CoordinateFixed));
            }

            return CompareTo((CoordinateFixed)obj);
        }

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(CoordinateFixed other)
        {
            int result = 0;
            result = X.CompareTo(other.X);
            if (result != 0)
            {
                return result;
            }

            result = Y.CompareTo(other.Y);
            if (result != 0)
            {
                return result;
            }

            return result;
        }
    }
}
