// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 10-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-15-2020
// ***********************************************************************
// <copyright file="EmailAddressType.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Enum EmailAddressType
    /// </summary>
    [Information(nameof(EmailAddress), "David McCarter", "10/15/2020")]
    public enum EmailAddressType
    {
        /// <summary>
        /// The send to address
        /// </summary>
        SendTo,

        /// <summary>
        /// The send from address
        /// </summary>
        SendFrom,

        /// <summary>
        /// The send cc address
        /// </summary>
        SendCC,

        /// <summary>
        /// The send BCC address
        /// </summary>
        SendBcc
    }
}
