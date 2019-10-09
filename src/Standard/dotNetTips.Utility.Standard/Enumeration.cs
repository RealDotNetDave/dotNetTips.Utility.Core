// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-11-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-03-2019
// ***********************************************************************
// <copyright file="Enumeration.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class Enumeration.
    /// </summary>
    /// <example>
    /// public class EmployeeType : Enumeration { public static read only EmployeeType Manager
    /// = new EmployeeType(0, "Manager"); public static read only EmployeeType Servant
    /// = new EmployeeType(1, "Servant"); public static read only EmployeeType AssistantToTheRegionalManager
    /// = new EmployeeType(2, "Assistant to the Regional Manager"); private EmployeeType() { }
    /// private EmployeeType(int value, string displayName) : base(value, displayName) { } }
    /// </example>
    /// <seealso cref="System.IComparable" />
    public abstract class Enumeration : IComparable
    {
        /// <summary>
        /// Display name
        /// </summary>
        private readonly string _displayName;

        /// <summary>
        /// Value
        /// </summary>
        private readonly int _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumeration" /> class.
        /// </summary>
        protected Enumeration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumeration" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="displayName">The display name.</param>
        protected Enumeration(int value, string displayName)
        {
            this._value = value;
            this._displayName = displayName;
        }

        /// <summary>
        /// Absolutes the difference.
        /// </summary>
        /// <param name="firstValue">The first value.</param>
        /// <param name="secondValue">The second value.</param>
        /// <returns>System.Int32.</returns>
        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            var absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
            return absoluteDifference;
        }

        /// <summary>
        /// Compares value to enumeration.
        /// </summary>
        /// <param name="obj">The other.</param>
        /// <returns>T.</returns>
        public int CompareTo(object obj) => this.Value.CompareTo(((Enumeration)obj).Value);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
            {
                return false;
            }

            var typeMatches = this.GetType().Equals(obj.GetType());
            var valueMatches = this._value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures
        /// like a hash table.</returns>
        public override int GetHashCode() => this._value.GetHashCode();

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => this.DisplayName;

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName => this._displayName;

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value => this._value;
    }
}