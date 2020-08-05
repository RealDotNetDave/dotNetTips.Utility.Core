// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="MailHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Class MailHelper.
    /// </summary>
    public static class MailHelper
    {

        /// <summary>
        /// Tries the parse email address.
        /// </summary>
        /// <param name="email">The data.</param>
        /// <param name="parsedAddress">The parsed address.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool TryParseEmailAddress(string email, out ParseAddressInfo parsedAddress, bool throwExceptionIfFail)
        {
            Encapsulation.TryValidateParam(email, nameof(email));

            return TryParseEmailAddress(email, false, email.Length - 1, out parsedAddress, throwExceptionIfFail);
        }

        /// <summary>
        /// Tries the parse email addresses.
        /// </summary>
        /// <param name="email">The data.</param>
        /// <param name="info">The information.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <param name="separator">The separator.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.New)]
        public static bool TryParseEmailAddresses(string email, out ParseAddressInfo[] info, bool throwExceptionIfFail, char separator = ',')
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException($"{nameof(email)} is null or empty.", nameof(email));
            }

            var result = new List<ParseAddressInfo>();

            var addresses = email.Split(separator);

            for (var i = 0; i < addresses.Length; i++)
            {
                var success = TryParseEmailAddress(addresses[i], out ParseAddressInfo parsedInfo, throwExceptionIfFail);

                if (success && parsedInfo.IsNotNull())
                {
                    result.Add(parsedInfo);
                }
            }

            if (result.HasItems())
            {
                info = result.ToArray();

                return true;
            }
            else
            {
                info = null;
                return false;
            }
        }

        /// <summary>
        /// Tries the normalize or throw.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="normalizedString">The normalized string.</param>
        /// <param name="throwException">if set to <c>true</c> [throw exception].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid email format.</exception>
        internal static bool TryNormalizeOrThrow(string input, out string normalizedString, bool throwException)
        {
            try
            {
                normalizedString = input.Normalize(System.Text.NormalizationForm.FormC);
                return true;
            }
            catch (ArgumentException e)
            {
                if (throwException)
                {
                    throw new FormatException("Invalid email format.", e);
                }
                else
                {
                    normalizedString = default;
                    return false;
                }
            }
        }

        //
        // Parse a single MailAddress, potentially from a list.
        //
        // Preconditions:
        //  - Index must be within the bounds of the data string.
        //  - The data string must not be null or empty
        //
        // Postconditions:
        // - Returns a valid MailAddress object parsed from the string
        // - For a single MailAddress index is set to -1
        // - For a list data[index] is the comma separator or -1 if the end of the data string was reached.
        //
        // Throws a FormatException or false is returned if any part of the MailAddress is invalid.
        /// <summary>
        /// Tries the parse address.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="expectMultipleAddresses">if set to <c>true</c> [expect multiple addresses].</param>
        /// <param name="index">The index.</param>
        /// <param name="parseAddressInfo">The parse address information.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid email address.
        /// or
        /// Invalid character: {(index &gt;= 0 ? data[index] : MailBnfHelper.EndAngleBracket)}.</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 64.06, Status = Status.New)]
        private static bool TryParseEmailAddress(string data, bool expectMultipleAddresses, int index, out ParseAddressInfo parseAddressInfo, bool throwExceptionIfFail)
        {
            Debug.Assert(!string.IsNullOrEmpty(data));
            Debug.Assert(index >= 0 && index < data.Length, "Index out of range: " + index + ", " + data.Length);

            // Parsed components to be assembled as a MailAddress later
            string displayName;

            // Skip comments and whitespace
            if (!TryReadCfwsAndThrowIfIncomplete(data, index, out index, throwExceptionIfFail))
            {
                parseAddressInfo = default;
                return false;
            }

            // Do we expect angle brackets around the address?
            // e.g. ("display name" <user@domain>)
            bool expectAngleBracket = false;

            if (data[index] == ControlChars.EndAngleBracket)
            {
                expectAngleBracket = true;
                index--;
            }

            if (!TryParseDomain(data, ref index, out string domain, throwExceptionIfFail))
            {
                parseAddressInfo = default;
                return false;
            }

            // The next character after the domain must be the '@' symbol
            if (data[index] != ControlChars.At)
            {
                if (throwExceptionIfFail)
                {
                    throw new FormatException("Invalid email address.");
                }
                else
                {
                    parseAddressInfo = default;
                    return false;
                }
            }

            // Skip the '@' symbol
            index--;

            if (!TryParseLocalPart(data, ref index, expectAngleBracket, expectMultipleAddresses, out string localPart, throwExceptionIfFail))
            {
                parseAddressInfo = default;
                return false;
            }

            // Check for a matching angle bracket around the address
            if (expectAngleBracket)
            {
                if (index >= 0 && data[index] == ControlChars.StartAngleBracket)
                {
                    index--; // Skip the angle bracket
                    // Skip whitespace, but leave comments, as they may be part of the display name.
                    if (!WhitespaceReader.TryReadFwsReverse(data, index, out index, throwExceptionIfFail))
                    {
                        parseAddressInfo = default;
                        return false;
                    }
                }
                else
                {
                    // Mismatched angle brackets
                    if (throwExceptionIfFail)
                    {
                        throw new FormatException($"Invalid character: {(index >= 0 ? data[index] : ControlChars.EndAngleBracket)}.");
                    }
                    else
                    {
                        parseAddressInfo = default;
                        return false;
                    }
                }
            }

            // Is there anything left to parse?
            // There could still be a display name or another address
            if (index >= 0 && !(expectMultipleAddresses && data[index] == ControlChars.Comma))
            {
                if (!TryParseDisplayName(data, ref index, expectMultipleAddresses, out displayName, throwExceptionIfFail))
                {
                    parseAddressInfo = default;
                    return false;
                }
            }
            else
            {
                displayName = string.Empty;
            }

            parseAddressInfo = new ParseAddressInfo(displayName, localPart, domain);
            return true;
        }

        // Parses the display-name section of an address.  In departure from the RFC, we attempt to read data in the
        // quoted-string format even if the bounding quotes are omitted.  We also permit Unicode, which the RFC does
        // not allow for.
        // e.g. ("display name" <user@domain>) or (display name <user@domain>)
        //
        // Preconditions:
        //
        // Postconditions:
        // - data[index] should refer to the comma ',' separator, if any
        // - index == -1 if the beginning of the data string has been reached.
        // - returns the parsed display-name, excluding any bounding quotes around quoted-strings
        //
        // Throws a FormatException or false is returned:
        // - For invalid un-escaped chars, except Unicode
        // - If the postconditions cannot be met.
        private static bool TryParseDisplayName(string data, ref int index, bool expectMultipleAddresses, out string displayName, bool throwExceptionIfFail)
        {
            // Whatever is left over must be the display name. The display name should be a single word/atom or a
            // quoted string, but for robustness we allow the quotes to be omitted, so long as we can find the comma
            // separator before the next address.

            // Read the comment (if any).  If the display name is contained in quotes, the surrounding comments are
            // omitted. Otherwise, mark this end of the comment so we can include it as part of the display name.
            if (!WhitespaceReader.TryReadCfwsReverse(data, index, out int firstNonCommentIndex, throwExceptionIfFail))
            {
                displayName = default;
                return false;
            }

            // Check to see if there's a quoted-string display name
            if (firstNonCommentIndex >= 0 && data[firstNonCommentIndex] == ControlChars.Quote)
            {
                // The preceding comment was not part of the display name.  Read just the quoted string.
                if (!QuotedStringFormatReader.TryReadReverseQuoted(data, firstNonCommentIndex, true, out index, throwExceptionIfFail))
                {
                    displayName = default;
                    return false;
                }

                Debug.Assert(data[index + 1] == ControlChars.Quote, "Mis-aligned index: " + index);

                // Do not include the bounding quotes on the display name
                int leftIndex = index + 2;
                displayName = data.Substring(leftIndex, firstNonCommentIndex - leftIndex);

                // Skip any CFWS after the display name
                if (!WhitespaceReader.TryReadCfwsReverse(data, index, out index, throwExceptionIfFail))
                {
                    return false;
                }

                // Check for completion. We are valid if we hit the end of the data string or if the rest of the data
                // belongs to another address.
                if (index >= 0 && !(expectMultipleAddresses && data[index] == ControlChars.Comma))
                {
                    // If there was still data, only a comma could have been the next valid character
                    if (throwExceptionIfFail)
                    {
                        throw new FormatException($"Invalid character: {data[index]}.");
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                // The comment (if any) should be part of the display name.
                int startingIndex = index;

                // Read until the dividing comma or the end of the line.
                if (!QuotedStringFormatReader.TryReadReverseUnQuoted(data, index, true, expectMultipleAddresses, out index, throwExceptionIfFail))
                {
                    displayName = default;
                    return false;
                }

                Debug.Assert(index < 0 || data[index] == ControlChars.Comma, "Mis-aligned index: " + index);

                // Do not include the Comma (if any), and because there were no bounding quotes,
                // trim extra whitespace.
                displayName = data.SubstringTrim(index + 1, startingIndex - index);
            }

            if (!TryNormalizeOrThrow(displayName, out displayName, throwExceptionIfFail))
            {
                return false;
            }

            return true;
        }

        // Parses the domain section of an address.  The domain may be in dot-atom format or surrounded by square
        // brackets in domain-literal format.
        // e.g. <user@domain.com> or <user@[whatever I want]>
        //
        // Preconditions:
        // - data[index] is just inside of the angle brackets (if any).
        //
        // Postconditions:
        // - data[index] should refer to the '@' symbol
        // - returns the parsed domain, including any square brackets for domain-literals
        //
        // Throws a FormatException or returns false:
        // - For invalid un-escaped chars, including Unicode
        // - If the start of the data string is reached
        private static bool TryParseDomain(string data, ref int index, out string domain, bool throwExceptionIfFail)
        {
            // Skip comments and whitespace
            if (!TryReadCfwsAndThrowIfIncomplete(data, index, out index, throwExceptionIfFail))
            {
                domain = default;
                return false;
            }

            // Mark one end of the domain component
            int startingIndex = index;

            // Is the domain component in domain-literal format or dot-atom format?
            if (data[index] == ControlChars.EndSquareBracket)
            {
                if (!DomainLiteralReader.TryReadReverse(data, index, out index, throwExceptionIfFail))
                {
                    domain = default;
                    return false;
                }
            }
            else
            {
                if (!DotAtomReader.TryReadReverse(data, index, out index, throwExceptionIfFail))
                {
                    domain = default;
                    return false;
                }
            }

            domain = data.Substring(index + 1, startingIndex - index);

            // Skip comments and whitespace
            if (!TryReadCfwsAndThrowIfIncomplete(data, index, out index, throwExceptionIfFail))
            {
                return false;
            }

            if (!TryNormalizeOrThrow(domain, out domain, throwExceptionIfFail))
            {
                return false;
            }

            return true;
        }

        // Parses the local-part section of an address.  The local-part may be in dot-atom format or
        // quoted-string format. e.g. <user.name@domain> or <"user name"@domain>
        // We do not support the obsolete formats of user."name"@domain, "user".name@domain, or "user"."name"@domain.
        //
        // Preconditions:
        // - data[index + 1] is the '@' symbol
        //
        // Postconditions:
        // - data[index] should refer to the '<', if any, otherwise the next non-CFWS char.
        // - index == -1 if the beginning of the data string has been reached.
        // - returns the parsed local-part, including any bounding quotes around quoted-strings
        //
        // Throws a FormatException or false is returned:
        // - For invalid un-escaped chars, including Unicode
        // - If the final value of data[index] is not a valid character to precede the local-part
        private static bool TryParseLocalPart(string data, ref int index, bool expectAngleBracket,
            bool expectMultipleAddresses, out string localPart, bool throwExceptionIfFail)
        {
            // Skip comments and whitespace
            if (!TryReadCfwsAndThrowIfIncomplete(data, index, out index, throwExceptionIfFail))
            {
                localPart = default;
                return false;
            }

            // Mark the start of the local-part
            int startingIndex = index;

            // Is the local-part component in quoted-string format or dot-atom format?
            if (data[index] == ControlChars.Quote)
            {
                if (!QuotedStringFormatReader.TryReadReverseQuoted(data, index, true, out index, throwExceptionIfFail))
                {
                    localPart = default;
                    return false;
                }
            }
            else
            {
                if (!DotAtomReader.TryReadReverse(data, index, out index, throwExceptionIfFail))
                {
                    localPart = default;
                    return false;
                }

                // Check that the local-part is properly separated from the next component. It may be separated by a
                // comment, whitespace, an expected angle bracket, a quote for the display-name, or an expected comma
                // before the next address.
                if (index >= 0 &&
                        !(
                            MailBnfHelper.IsAllowedWhiteSpace(data[index]) // < local@domain >
                            || data[index] == ControlChars.EndComment // <(comment)local@domain>
                            || (expectAngleBracket && data[index] == ControlChars.StartAngleBracket) // <local@domain>
                            || (expectMultipleAddresses && data[index] == ControlChars.Comma) // local@dom,local@dom
                                                                                              // Note: The following condition is more lax than the RFC.  This is done so we could support
                                                                                              // a common invalid formats as shown below.
                            || data[index] == ControlChars.Quote // "display"local@domain
                        )
                    )
                {
                    if (throwExceptionIfFail)
                    {
                        throw new FormatException($"Invalid character: {data[index]}.");
                    }
                    else
                    {
                        localPart = default;
                        return false;
                    }
                }
            }

            localPart = data.Substring(index + 1, startingIndex - index);

            if (!WhitespaceReader.TryReadCfwsReverse(data, index, out index, throwExceptionIfFail))
            {
                return false;
            }

            if (!TryNormalizeOrThrow(localPart, out localPart, throwExceptionIfFail))
            {
                return false;
            }

            return true;
        }

        // Read through a section of CFWS.  If we reach the end of the data string then throw because not enough of the
        // MailAddress components were found.
        private static bool TryReadCfwsAndThrowIfIncomplete(string data, int index, out int outIndex, bool throwExceptionIfFail)
        {
            if (!WhitespaceReader.TryReadCfwsReverse(data, index, out index, throwExceptionIfFail))
            {
                outIndex = default;
                return false;
            }

            if (index < 0)
            {
                // More components were expected.  Incomplete address, invalid
                if (throwExceptionIfFail)
                {
                    throw new FormatException("Invalid email address format.");
                }
                else
                {
                    outIndex = default;
                    return false;
                }
            }

            outIndex = index;
            return true;
        }

    }
}
