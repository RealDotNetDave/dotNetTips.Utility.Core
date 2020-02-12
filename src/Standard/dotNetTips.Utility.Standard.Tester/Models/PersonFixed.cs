// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2020
// ***********************************************************************
// <copyright file="PersonFixed.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace dotNetTips.Utility.Standard.Tester.Models
{
    /// <summary>
    /// Class PersonFixed.
    /// Implements the <see cref="dotNetTips.Utility.Standard.Tester.Models.Person" />
    /// Implements the <see cref="System.IComparable" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Tester.Models.Person" />
    /// <seealso cref="System.IComparable" />
    [DebuggerDisplay("{Email}")]
    public sealed class PersonFixed : Person, IDataModel<PersonFixed>
    {

        /// <summary>
        /// Initializes a new instance of <see cref="PersonFixed" />.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PersonFixed()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PersonFixed" />.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="email">The email address.</param>
        public PersonFixed(string id, string email)
        {
            this.Id = id;
            this.Email = email;
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <value>The age.</value>
        public TimeSpan Age => this.CalculateAge();

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(PersonFixed other)
        {
            if (other is null)
            {
                return 1;
            }

            var result = this.Email.CompareTo(other.Email);
            if (result != 0)
            {
                return result;
            }

            result = this.Id.CompareTo(other.Id);

            if (result != 0)
            {
                return result;
            }

            result = this.Address1.CompareTo(other.Address1);

            if (result != 0)
            {
                return result;
            }

            result = this.Address2.CompareTo(other.Address2);

            if (result != 0)
            {
                return result;
            }

            result = this.BornOn.CompareTo(other.BornOn);
            if (result != 0)
            {
                return result;
            }

            result = this.CellPhone.CompareTo(other.CellPhone);

            if (result != 0)
            {
                return result;
            }

            result = this.City.CompareTo(other.City);
            if (result != 0)
            {
                return result;
            }

            result = this.Country.CompareTo(other.Country);

            if (result != 0)
            {
                return result;
            }

            result = this.FirstName.CompareTo(other.FirstName);

            if (result != 0)
            {
                return result;
            }

            result = this.HomePhone.CompareTo(other.HomePhone);

            if (result != 0)
            {
                return result;
            }

            result = this.LastName.CompareTo(other.LastName);

            if (result != 0)
            {
                return result;
            }

            result = this.PostalCode.CompareTo(other.PostalCode);

            if (result != 0)
            {
                return result;
            }

            return result;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            //TODO: CHANGE TO HashCode.Combine(Email, Id)
            var hashCode = -1058553241;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
            return hashCode;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that returns the person's id.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that returns the person's id.</returns>
        public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

        /// <summary>
        /// Calculates the person's current age.
        /// </summary>
        /// <returns>TimeSpan.</returns>
        private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
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
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        /// TODO Edit XML Comment Template for Equals
        public bool Equals(PersonFixed other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other is null)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(PersonFixed left, PersonFixed right) => left is null ? right is null : left.Equals(right);

        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(PersonFixed left, PersonFixed right) => !(left == right);

        /// <summary>
        /// Implements the &lt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(PersonFixed left, PersonFixed right) => left is null ? right is object : left.CompareTo(right) < 0;

        /// <summary>
        /// Implements the &lt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(PersonFixed left, PersonFixed right) => left is null || left.CompareTo(right) <= 0;

        /// <summary>
        /// Implements the &gt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(PersonFixed left, PersonFixed right) => left is object && left.CompareTo(right) > 0;

        /// <summary>
        /// Implements the &gt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(PersonFixed left, PersonFixed right) => left is null ? right is null : left.CompareTo(right) >= 0;
    }
}
