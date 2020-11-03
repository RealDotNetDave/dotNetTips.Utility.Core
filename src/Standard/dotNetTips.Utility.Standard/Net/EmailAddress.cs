// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 10-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2020
// ***********************************************************************
// <copyright file="EmailAddress.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Globalization;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// EmailAddress
    /// </summary>
    [Information(nameof(EmailAddress), "David McCarter", "10/15/2020", "10/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
    public struct EmailAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAddress" /> struct.
        /// </summary>
        /// <param name="address">The address.</param>
        public EmailAddress(string address) : this()
        {
            this.Address = address;
            this.EmailAddressType = EmailAddressType.SendTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAddress" /> struct.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="name">The name.</param>
        public EmailAddress(string address, string name) : this(address)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; private set; }

        /// <summary>
        /// Gets or sets the type of the email address.
        /// </summary>
        /// <value>The type of the email address.</value>
        public EmailAddressType EmailAddressType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Combines the name address.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <returns>System.String.</returns>
        public static string CombineNameAddress(string name, string address)
        {
            return name.IsNotEmpty() && address.IsNotEmpty() ? string.Format(CultureInfo.CurrentCulture, "{0} <{1}>", name, address) : address;
        }

        /// <summary>
        /// Determines whether [is address valid].
        /// </summary>
        /// <returns><c>true</c> if [is address valid]; otherwise, <c>false</c>.</returns>
        public bool IsAddressValid()
        {
            return this.Address.IsEmailAddress();
        }

        /// <summary>
        /// Determines whether [is name value].
        /// </summary>
        /// <returns><c>true</c> if [is name value]; otherwise, <c>false</c>.</returns>
        public bool IsNameValue()
        {
            return this.Name.IsString();
        }
    }
}
