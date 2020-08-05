// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-05-2020
// ***********************************************************************
// <copyright file="ParseAddressInfo.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Struct for ParseAddressInfo
    /// </summary>
    public readonly struct ParseAddressInfo
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseAddressInfo" /> struct.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="domain">The domain.</param>
        public ParseAddressInfo(string displayName, string userName, string domain) => (DisplayName, User, Host) = (displayName, userName, domain);

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName { get; }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        public string Host { get; }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <value>The user.</value>
        public string User { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var email = $"{this.User}@{this.Host}";

            return DisplayName.HasValue() ? $"{this.DisplayName} <{email}>" : email;
        }

    }
}
