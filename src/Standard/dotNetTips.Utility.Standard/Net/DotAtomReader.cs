// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="DotAtomReader.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Class DotAtomReader.
    /// </summary>
    internal static class DotAtomReader
    {

        // Reads a Dot Atom in reverse.
        //
        // Preconditions:
        //  - Index must be within the bounds of the data string.
        //
        // Return value:
        // - The first index of a character not valid in a dot-atom.  It is then up to the caller to
        //   determine if the next character is a valid delimiter.
        //   e.g. "user.name@domain.com", starting at index 19 (m) returns 9 (@).
        //   e.g. "user.name@dom in.com", starting at index 19 (m) returns 13 (space).
        // - -1 if the dot-atom section terminated at the start of the data string.
        //   e.g. "user.name@domain.com", starting at index 8 (e) returns -1.
        //
        // Throws FormatException or returns false if:
        // - The initial character at data[index] is invalid in a dot-atom.
        //   e.g. "a@b.com", starting at index 1 (@).
        // - The leading character is a dot.
        //   e.g. "a@.b.com", starting at index 7 (m), throws because the leading char (index 2) is a dot.
        //
        /// <summary>
        /// Tries the read reverse.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="outIndex">Index of the out.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid character: {data[index]}.
        /// or
        /// Invalid character: {MailBnfHelper.Dot}.</exception>
        internal static bool TryReadReverse(string data, int index, out int outIndex, bool throwExceptionIfFail)
        {
            Debug.Assert(0 <= index && index < data.Length, "index was outside the bounds of the string: " + index);

            int startIndex = index;

            // Scan for the first invalid chars (including whitespace)
            for (; 0 <= index; index--)
            {
                if (data[index] <= MailBnfHelper.Ascii7bitMaxValue // Any Unicode allowed
                 && (data[index] != dotNetTips.Utility.Standard.Common.ControlChars.Dot && !MailBnfHelper.Atext[data[index]])) // Invalid char
                {
                    break;
                }
            }

            // Check for empty/invalid dot-atom
            if (startIndex == index)
            {
                if (throwExceptionIfFail)
                {
                    throw new FormatException($"Invalid character: {data[index]}.");
                }
                else
                {
                    outIndex = default;
                    return false;
                }
            }
            // Check for leading dot
            else if (data[index + 1] == dotNetTips.Utility.Standard.Common.ControlChars.Dot)
            {
                if (throwExceptionIfFail)
                {
                    throw new FormatException($"Invalid character: {dotNetTips.Utility.Standard.Common.ControlChars.Dot}.");
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
