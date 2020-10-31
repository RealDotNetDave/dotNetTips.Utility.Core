// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-07-2020
// ***********************************************************************
// <copyright file="QuotedPairReader.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;

namespace dotNetTips.Utility.Standard.Net
{
    // RFC 2822 Section 3.2.2 - Quoted Characters
    // As in C# strings, characters that would otherwise have special meaning should be ignored when quoted/escaped
    // by a backslash "\". Quoted characters (quoted-pair) are only allowed in the following contexts: Comments,
    // quoted-string, domain-literal, and message-id.
    //
    // Example: A quoted-string ("hello there") cannot contain a double quote, as it must be surrounded by them.
    //  However, the double quote can be included as a quoted-pair: ("hello\"there") means (hello"there).
    //
    // Because backslashes themselves can be quoted-pairs (\\), this class's primary function is to verify what
    // character is being quoted. In "hi\\\\a", 'a' is not quoted because all of the backslashes are paired together.
    // In "hi\\\a", 'a' is quoted.
    /// <summary>
    /// Class QuotedPairReader.
    /// </summary>
    internal static class QuotedPairReader
    {

        //
        // Counts the number of consecutive quoted chars, including multiple preceding quoted backslashes
        //
        // Preconditions: Index should be within the bounds of the data string.
        //
        // Return value:
        // - 0 if the char at data[index] was not quoted
        //   e.g. (\\a) given index=2 returns 0 because 'a' is not quoted
        // - The number of consecutive quoted chars, including multiple preceding quoted backslashes
        //   e.g. (a\\\b) given index=4 returns 4, as 'b' is quoted, and so are the previous backslashes
        //
        // Throws a FormatException or false is returned if the an escaped Unicode character is found but was not permitted.
        /// <summary>
        /// Tries the count quoted chars.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="permitUnicodeEscaping">if set to <c>true</c> [permit unicode escaping].</param>
        /// <param name="outIndex">Index of the out.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid character: {data[index]}.</exception>
        internal static bool TryCountQuotedChars(string data, int index, bool permitUnicodeEscaping, out int outIndex, bool throwExceptionIfFail)
        {
            Debug.Assert(0 <= index && index < data.Length, "Index out of range: " + index + ", " + data.Length);

            if (index <= 0 || data[index - 1] != dotNetTips.Utility.Standard.Common.ControlChars.Backslash)
            {
                outIndex = 0;
                return true;
            }

            // Count the preceding backslashes
            var backslashCount = CountBackslashes(data, index - 1);

            // For an even number of backslashes, the original character was NOT escaped/quoted
            if (backslashCount % 2 == 0)
            {
                outIndex = 0; // No quoted pair to skip
                return true;
            }
            else
            {
                if (!permitUnicodeEscaping && data[index] > MailBnfHelper.Ascii7bitMaxValue)
                {
                    if (throwExceptionIfFail)
                    {
                        // Cannot accept quoted Unicode
                        throw new FormatException($"Invalid character: {data[index]}.");
                    }
                    else
                    {
                        outIndex = default;
                        return false;
                    }
                }
                // Skip the quoted char, and the odd number of backslashes preceding it
                outIndex = backslashCount + 1;
                return true;
            }
        }

        //
        // Counts the number of consecutive backslashes
        //
        // Preconditions:
        // - Index should be within the bounds of the data string.
        // - The initial data[index] must be a backslash.
        //
        // Return value: The number of consecutive backslashes, including the initial one at data[index].
        private static int CountBackslashes(string data, int index)
        {
            Debug.Assert(index >= 0 && data[index] == dotNetTips.Utility.Standard.Common.ControlChars.Backslash, "index was not a backslash: " + index);

            // Find all the backslashes. It's possible that there are multiple escaped/quoted backslashes.
            var backslashCount = 0;
            do
            {
                backslashCount++;
                index--;
            } while (index >= 0 && data[index] == dotNetTips.Utility.Standard.Common.ControlChars.Backslash);

            // At this point data[index] should not be a backslash
            Debug.Assert(index < 0 || data[index] != dotNetTips.Utility.Standard.Common.ControlChars.Backslash, "index was a backslash: " + index);

            return backslashCount;
        }

    }
}
