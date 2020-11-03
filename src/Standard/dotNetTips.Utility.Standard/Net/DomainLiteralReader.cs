// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="DomainLiteralReader.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;

namespace dotNetTips.Utility.Standard.Net
{
    //
    // RFC 2822 Section 3.4.1 - Addr-Spec, Domain-Literals
    // A domain literal is a domain identifier that does not conform to the dot-atom format (Section 3.2.4) and must be
    // enclosed in brackets '[' ']'.  Domain literals may contain quoted-pairs.
    //
    /// <summary>
    /// Class DomainLiteralReader.
    /// </summary>
    internal static class DomainLiteralReader
    {

        //
        // Reads a domain literal in reverse
        //
        // Preconditions:
        //  - Index must be within the bounds of the data string.
        //  - The char at the given index is the initial bracket. (data[index] == EndSquareBracket)
        //
        // Return value:
        // - The next index past the terminating bracket (data[index + 1] == StartSquareBracket).
        //   e.g. In (user@[domain]), starting at index=12 (]) returns index=4 (@).
        //
        // A FormatException will be thrown or false is returned if:
        // - A non-escaped character is encountered that is not valid in a domain literal, including Unicode.
        // - The final bracket is not found.
        //
        /// <summary>
        /// Tries the read reverse.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="outIndex">Index of the out.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid character: { data[index]}.
        /// or
        /// Invalid character: { MailBnfHelper.EndSquareBracket}.</exception>
        internal static bool TryReadReverse(string data, int index, out int outIndex, bool throwExceptionIfFail)
        {
            Debug.Assert(0 <= index && index < data.Length, "index was outside the bounds of the string: " + index);
            Debug.Assert(data[index] == dotNetTips.Utility.Standard.Common.ControlChars.EndSquareBracket, "data did not end with a square bracket");

            // Skip the end bracket
            index--;

            do
            {
                // Check for valid whitespace
                if (!WhitespaceReader.TryReadFwsReverse(data, index, out index, throwExceptionIfFail))
                {
                    outIndex = default;
                    return false;
                }

                if (index < 0)
                {
                    break;
                }

                // Check for escaped characters
                if (!QuotedPairReader.TryCountQuotedChars(data, index, false, out int quotedCharCount, throwExceptionIfFail))
                {
                    outIndex = default;
                    return false;
                }

                if (quotedCharCount > 0)
                {
                    // Skip quoted pairs
                    index -= quotedCharCount;
                }
                // Check for the terminating bracket
                else if (data[index] == dotNetTips.Utility.Standard.Common.ControlChars.StartSquareBracket)
                {
                    // We're done parsing
                    outIndex = index - 1;
                    return true;
                }
                // Check for invalid characters
                else if (data[index] > MailBnfHelper.Ascii7bitMaxValue || !MailBnfHelper.Dtext[data[index]])
                {
                    if (throwExceptionIfFail)
                    {
                        throw new FormatException($"Invalid character: { data[index]}.");
                    }
                    else
                    {
                        outIndex = default;
                        return false;
                    }
                }
                // Valid char
                else
                {
                    index--;
                }
            }
            while (index >= 0);

            if (throwExceptionIfFail)
            {
                // We didn't find a matching '[', throw.
                throw new FormatException($"Invalid character: { dotNetTips.Utility.Standard.Common.ControlChars.EndSquareBracket}.");
            }
            else
            {
                outIndex = default;
                return false;
            }
        }

    }
}
