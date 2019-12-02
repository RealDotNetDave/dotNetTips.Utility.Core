// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-28-2019
// ***********************************************************************
// <copyright file="PersonFixed.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

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
    public class PersonFixed : Person, IComparable, IComparable<PersonFixed>
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

        /// <summary>Compares to.</summary>
        /// <param name="obj">The object.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentException">obj</exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            PersonFixed other = obj as PersonFixed;
            if (other == null)
            {
                throw new ArgumentException(nameof(obj) + " is not a " + nameof(PersonFixed));
            }

            return CompareTo(other);
        }

        /// <summary>Compares to.</summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(PersonFixed other)
        {
            if (other == null)
            {
                return 1;
            }

            int result = 0;

            result = Address1.CompareTo(other.Address1);

            if (result != 0)
            {
                return result;
            }

            result = Address2.CompareTo(other.Address2);

            if (result != 0)
            {
                return result;
            }

            result = BornOn.CompareTo(other.BornOn);
            if (result != 0)
            {
                return result;
            }

            result = CellPhone.CompareTo(other.CellPhone);

            if (result != 0)
            {
                return result;
            }

            result = City.CompareTo(other.City);
            if (result != 0)
            {
                return result;
            }

            result = Country.CompareTo(other.Country);

            if (result != 0)
            {
                return result;
            }

            result = Email.CompareTo(other.Email);
            if (result != 0)
            {
                return result;
            }

            result = FirstName.CompareTo(other.FirstName);

            if (result != 0)
            {
                return result;
            }

            result = HomePhone.CompareTo(other.HomePhone);

            if (result != 0)
            {
                return result;
            }

            result = Id.CompareTo(other.Id);

            if (result != 0)
            {
                return result;
            }

            result = LastName.CompareTo(other.LastName);

            if (result != 0)
            {
                return result;
            }

            result = PostalCode.CompareTo(other.PostalCode);

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
        public override string ToString()
        {
            return this.Id.ToString();
        }

        /// <summary>
        /// Calculates the person's current age.
        /// </summary>
        /// <returns>TimeSpan.</returns>
        private TimeSpan CalculateAge()
        {
            return DateTimeOffset.UtcNow.Subtract(this.BornOn);
        }

    }
}
