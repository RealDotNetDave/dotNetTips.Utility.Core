// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="WhitespaceReader.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Class WhitespaceReader.
    /// </summary>
    internal static class WhitespaceReader
    {


        // This method functions similarly to ReadFwsReverse but will also skip any comments.
        //
        // Comments are text within '(' and ')' and may be nested. There may also be consecutive comments.  Unicode is
        // allowed, as the comments are not transmitted.
        //
        // This method was explicitly written in a non-recursive fashion to avoid malicious or accidental
        // stack-overflows from user input.
        //
        // Preconditions:
        // - The data string must not be null or empty
        // - The index must be within the upper bounds of the data string.
        //
        // Return value:
        // - The given index if it data[index] was not a ')' or whitespace
        // - The index of the next non comment or whitespace character
        //   e.g. " d ( ( c o mment) )" returns index 1
        // - -1 if skipping the comments and/or whitespace moves you to the beginning of the data string.
        //   e.g. " (comment) " returns -1
        //
        // Throws a FormatException or false is returned for mismatched '(' and ')', or for unescaped characters not allowed in comments.
        /// <summary>
        /// Tries the read CFWS reverse.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="outIndex">Index of the out.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid character: {ControlChars.StartComment}.
        /// or
        /// Invalid character: {data[index]}.
        /// or
        /// Invalid character.</exception>
        internal static bool TryReadCfwsReverse(string data, int index, out int outIndex, bool throwExceptionIfFail)
        {
            Debug.Assert(!string.IsNullOrEmpty(data), "data was null or empty");
            Debug.Assert(index < data.Length, "index was outside the bounds of the string");

            int commentDepth = 0;

            // Check for valid whitespace
            if (!TryReadFwsReverse(data, index, out index, throwExceptionIfFail))
            {
                outIndex = default;
                return false;
            }

            while (index >= 0)
            {
                // Check for escaped characters.  They must be within comments.
                if (!QuotedPairReader.TryCountQuotedChars(data, index, true, out int quotedCharCount, throwExceptionIfFail))
                {
                    outIndex = default;
                    return false;
                }

                if (commentDepth > 0 && quotedCharCount > 0)
                {
                    index -= quotedCharCount;
                }
                // Start a new comment
                else if (data[index] == ControlChars.EndComment)
                {
                    commentDepth++;
                    index--;
                }
                // Finish a comment
                else if (data[index] == ControlChars.StartComment)
                {
                    commentDepth--;
                    if (commentDepth < 0)
                    {
                        if (throwExceptionIfFail)
                        {
                            // Mismatched '('
                            throw new FormatException($"Invalid character: {ControlChars.StartComment}.");
                        }
                        else
                        {
                            outIndex = default;
                            return false;
                        }
                    }
                    index--;
                }
                // Check for valid characters within comments.  Allow Unicode, as we won't transmit any comments.
                else if (commentDepth > 0
                    && (data[index] > MailBnfHelper.Ascii7bitMaxValue || MailBnfHelper.Ctext[data[index]]))
                {
                    index--;
                }
                // If we're still in a comment, this must be an invalid char
                else if (commentDepth > 0)
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
                // We must no longer be in a comment, and this is not a whitespace char, return
                else
                {
                    break;
                }

                // Check for valid whitespace
                if (!TryReadFwsReverse(data, index, out index, throwExceptionIfFail))
                {
                    outIndex = default;
                    return false;
                }
            }

            if (commentDepth > 0)
            {
                if (throwExceptionIfFail)
                {
                    // Mismatched ')', throw
                    throw new FormatException("Invalid character.");
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
        //
        // This skips all folding and whitespace characters
        //
        // Preconditions:
        // - The data string must not be null or empty.
        // - The index must be within the upper bounds of the data string.
        //
        // Return value:
        // - The index of the next character that is NOT a whitespace character.
        // - -1 if the beginning of the data string is reached.
        //
        // A FormatException will be thrown or false is returned if a CR or LF is found NOT in the sequence CRLF.
        /// <summary>
        /// Tries the read FWS reverse.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="outIndex">Index of the out.</param>
        /// <param name="throwExceptionIfFail">if set to <c>true</c> [throw exception if fail].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid email address format.
        /// or
        /// Invalid email address format.</exception>
        internal static bool TryReadFwsReverse(string data, int index, out int outIndex, bool throwExceptionIfFail)
        {
            Debug.Assert(!string.IsNullOrEmpty(data), "data was null or empty");
            Debug.Assert(index < data.Length, "index was outside the bounds of the string");

            bool expectCR = false;

            for (; index >= 0; index--)
            {
                // Check for a valid CRLF pair
                if (data[index] == ControlChars.CR && expectCR)
                {
                    expectCR = false; // valid pair
                }
                // LF without CR, or CR without LF, invalid
                else if (data[index] == ControlChars.CR || expectCR)
                {
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
                // LF is only valid if preceded by a CR.
                // Skip both if they're found together.
                else if (data[index] == ControlChars.LF)
                {
                    expectCR = true;
                }
                // Skip whitespace
                else if (data[index] == ControlChars.Space || data[index] == ControlChars.Tab)
                {
                    // No-op
                }
                else
                {
                    // Neither check hit so we must be on something that is not whitespace
                    break;
                }
            }

            if (expectCR)
            {
                if (throwExceptionIfFail)
                {
                    // We found a LF without an immediately preceding CR, invalid.
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
