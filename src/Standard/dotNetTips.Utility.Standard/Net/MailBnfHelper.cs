// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-23-2020
// ***********************************************************************
// <copyright file="MailBnfHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Text;

namespace dotNetTips.Utility.Standard.Net
{
    /// <summary>
    /// Class MailBnfHelper.
    /// </summary>
    internal static class MailBnfHelper
    {

        /// <summary>
        /// The ascii7bit maximum value
        /// </summary>
        internal const int Ascii7bitMaxValue = 127;


        private static readonly string[] s_months = new string[] { null, "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        /// <summary>
        /// Gets the date time string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>System.String.</returns>
        internal static string GetDateTimeString(DateTime value, StringBuilder builder)
        {
            StringBuilder localBuilder = (builder != null ? builder : new StringBuilder());
            localBuilder.Append(value.Day);
            localBuilder.Append(' ');
            localBuilder.Append(s_months[value.Month]);
            localBuilder.Append(' ');
            localBuilder.Append(value.Year);
            localBuilder.Append(' ');
            if (value.Hour <= 9)
            {
                localBuilder.Append('0');
            }
            localBuilder.Append(value.Hour);
            localBuilder.Append(':');
            if (value.Minute <= 9)
            {
                localBuilder.Append('0');
            }
            localBuilder.Append(value.Minute);
            localBuilder.Append(':');
            if (value.Second <= 9)
            {
                localBuilder.Append('0');
            }
            localBuilder.Append(value.Second);

            string offset = TimeZoneInfo.Local.GetUtcOffset(value).ToString();
            if (offset[0] != '-')
            {
                localBuilder.Append(" +");
            }
            else
            {
                localBuilder.Append(' ');
            }

            string[] offsetFields = offset.Split(':');
            localBuilder.Append(offsetFields[0]);
            localBuilder.Append(offsetFields[1]);
            return (builder != null ? null : localBuilder.ToString());
        }

        /// <summary>
        /// Gets the token or quoted string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="allowUnicode">if set to <c>true</c> [allow unicode].</param>
        internal static void GetTokenOrQuotedString(string data, StringBuilder builder, bool allowUnicode)
        {
            int offset = 0, start = 0;
            for (; offset < data.Length; offset++)
            {
                if (CheckForUnicode(data[offset], allowUnicode))
                {
                    continue;
                }

                if (!Ttext[data[offset]] || data[offset] == ' ')
                {
                    builder.Append('"');
                    for (; offset < data.Length; offset++)
                    {
                        if (CheckForUnicode(data[offset], allowUnicode))
                        {
                            continue;
                        }
                        else if (IsFWSAt(data, offset)) // Allow FWS == "\r\n "
                        {
                            // No-op, skip these three chars
                            offset += 2;
                        }
                        else if (!Qtext[data[offset]])
                        {
                            builder.Append(data, start, offset - start);
                            builder.Append('\\');
                            start = offset;
                        }
                    }
                    builder.Append(data, start, offset - start);
                    builder.Append('"');
                    return;
                }
            }

            //always a quoted string if it was empty.
            if (data.Length == 0)
            {
                builder.Append("\"\"");
            }
            // Token, no quotes needed
            builder.Append(data);
        }

        /// <summary>
        /// Determines whether [has cr or lf] [the specified data].
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns><c>true</c> if [has cr or lf] [the specified data]; otherwise, <c>false</c>.</returns>
        internal static bool HasCROrLF(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '\r' || data[i] == '\n')
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is allowed white space] [the specified c].
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns><c>true</c> if [is allowed white space] [the specified c]; otherwise, <c>false</c>.</returns>
        internal static bool IsAllowedWhiteSpace(char c)
        {
            // all allowed whitespace characters
            return c == ControlChars.Tab || c == ControlChars.Space || c == ControlChars.CR || c == ControlChars.LF;
        }

        // Is there a FWS ("\r\n " or "\r\n\t") starting at the given index?
        /// <summary>
        /// Determines whether [is FWS at] [the specified data].
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="index">The index.</param>
        /// <returns><c>true</c> if [is FWS at] [the specified data]; otherwise, <c>false</c>.</returns>
        internal static bool IsFWSAt(string data, int index)
        {
            Debug.Assert(index >= 0);
            Debug.Assert(index < data.Length);

            return (data[index] == ControlChars.CR
                    && index + 2 < data.Length
                    && data[index + 1] == ControlChars.LF
                    && (data[index + 2] == ControlChars.Space
                        || data[index + 2] == ControlChars.Tab));
        }

        /// <summary>
        /// Reads the parameter attribute.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>System.String.</returns>
        internal static string ReadParameterAttribute(string data, ref int offset, StringBuilder builder)
        {
            if (!SkipCFWS(data, ref offset))
                return null; //

            return ReadToken(data, ref offset, null);
        }

        /// <summary>
        /// Reads the quoted string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>System.String.</returns>
        internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder)
        {
            return ReadQuotedString(data, ref offset, builder, false, false);
        }

        /// <summary>
        /// Reads the quoted string.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="builder">The builder.</param>
        /// <param name="doesntRequireQuotes">if set to <c>true</c> [doesnt require quotes].</param>
        /// <param name="permitUnicodeInDisplayName">if set to <c>true</c> [permit unicode in display name].</param>
        /// <returns>System.String.</returns>
        /// <exception cref="FormatException">Invalid character: {data[offset]}.
        /// or
        /// Invalid character: {data[offset]}.
        /// or
        /// Malformed header.</exception>
        internal static string ReadQuotedString(string data, ref int offset, StringBuilder builder, bool doesntRequireQuotes, bool permitUnicodeInDisplayName)
        {
            // assume first char is the opening quote
            if (!doesntRequireQuotes)
            {
                ++offset;
            }
            int start = offset;
            StringBuilder localBuilder = (builder != null ? builder : new StringBuilder());
            for (; offset < data.Length; offset++)
            {
                if (data[offset] == '\\')
                {
                    localBuilder.Append(data, start, offset - start);
                    start = ++offset;
                }
                else if (data[offset] == '"')
                {
                    localBuilder.Append(data, start, offset - start);
                    offset++;
                    return (builder != null ? null : localBuilder.ToString());
                }
                else if (data[offset] == '=' &&
                    data.Length > offset + 3 &&
                    data[offset + 1] == '\r' &&
                    data[offset + 2] == '\n' &&
                    (data[offset + 3] == ' ' || data[offset + 3] == '\t'))
                {
                    //it's a soft crlf so it's ok
                    offset += 3;
                }
                else if (permitUnicodeInDisplayName)
                {
                    //if data contains Unicode and Unicode is permitted, then
                    //it is valid in a quoted string in a header.
                    if (data[offset] <= Ascii7bitMaxValue && !Qtext[data[offset]])
                        throw new FormatException($"Invalid character: {data[offset]}.");
                }
                //not permitting Unicode, in which case Unicode is a formatting error
                else if (data[offset] > Ascii7bitMaxValue || !Qtext[data[offset]])
                {
                    throw new FormatException($"Invalid character: {data[offset]}.");
                }
            }
            if (doesntRequireQuotes)
            {
                localBuilder.Append(data, start, offset - start);
                return (builder != null ? null : localBuilder.ToString());
            }
            throw new FormatException("Malformed header.");
        }

        /// <summary>
        /// Reads the token.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="builder">The builder.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="FormatException">Invalid character: {data[offset]}.
        /// or
        /// Invalid character: {data[offset]}.</exception>
        internal static string ReadToken(string data, ref int offset, StringBuilder builder)
        {
            int start = offset;
            for (; offset < data.Length; offset++)
            {
                if (data[offset] > Ascii7bitMaxValue)
                {
                    throw new FormatException($"Invalid character: {data[offset]}.");
                }
                else if (!Ttext[data[offset]])
                {
                    break;
                }
            }

            if (start == offset)
            {
                throw new FormatException($"Invalid character: {data[offset]}.");
            }

            return data.Substring(start, offset - start);
        }

        /// <summary>
        /// Skips the CFWS.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="FormatException">Invalid character: {data[offset]}.
        /// or
        /// Invalid character: {data[offset]}.</exception>
        internal static bool SkipCFWS(string data, ref int offset)
        {
            int comments = 0;
            for (; offset < data.Length; offset++)
            {
                if (data[offset] > 127)
                    throw new FormatException($"Invalid character: {data[offset]}.");
                else if (data[offset] == '\\' && comments > 0)
                    offset += 2;
                else if (data[offset] == '(')
                    comments++;
                else if (data[offset] == ')')
                    comments--;
                else if (data[offset] != ' ' && data[offset] != '\t' && comments == 0)
                    return true;

                if (comments < 0)
                {
                    throw new FormatException($"Invalid character: {data[offset]}.");
                }
            }

            //returns false if end of string
            return false;
        }

        /// <summary>
        /// Validates the name of the header.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <exception cref="FormatException">Invalid header name.
        /// or
        /// Invalid header name.</exception>
        internal static void ValidateHeaderName(string data)
        {
            int offset = 0;
            
            for (; offset < data.Length; offset++)
            {
                if (data[offset] > Ftext.Length || !Ftext[data[offset]])
                {
                    throw new FormatException("Invalid header name.");
                }
            }

            if (offset == 0)
            {
                throw new FormatException("Invalid header name.");
            }
        }

        private static bool CheckForUnicode(char ch, bool allowUnicode)
        {
            if (ch < Ascii7bitMaxValue)
            {
                return false;
            }

            if (!allowUnicode)
            {
                throw new FormatException($"Invalid character: {ch}.");
            }
            return true;
        }

        // NOTE: See RFC 2822 for more detail.  By default, every value in the array is false and only
        // those values which are allowed in that particular set are then set to true.  The numbers
        // annotating each definition below are the range of ASCII values which are allowed in that definition.

        private static bool[] CreateCharactersAllowedInAtoms()
        {
            // atext = ALPHA / DIGIT / "!" / "#" / "$" / "%" / "&" / "'" / "*" / "+" / "-" / "/" / "=" / "?" / "^" / "_" / "`" / "{" / "|" / "}" / "~"
            var atext = new bool[128];
            for (int i = '0'; i <= '9'; i++) { atext[i] = true; }
            for (int i = 'A'; i <= 'Z'; i++) { atext[i] = true; }
            for (int i = 'a'; i <= 'z'; i++) { atext[i] = true; }
            atext['!'] = true;
            atext['#'] = true;
            atext['$'] = true;
            atext['%'] = true;
            atext['&'] = true;
            atext['\''] = true;
            atext['*'] = true;
            atext['+'] = true;
            atext['-'] = true;
            atext['/'] = true;
            atext['='] = true;
            atext['?'] = true;
            atext['^'] = true;
            atext['_'] = true;
            atext['`'] = true;
            atext['{'] = true;
            atext['|'] = true;
            atext['}'] = true;
            atext['~'] = true;
            return atext;
        }

        private static bool[] CreateCharactersAllowedInComments()
        {
            // ctext- %d1-8 / %d11 / %d12 / %d14-31 / %33-39 / %42-91 / %93-127
            var ctext = new bool[128];
            for (int i = 1; i <= 8; i++) { ctext[i] = true; }
            ctext[11] = true;
            ctext[12] = true;
            for (int i = 14; i <= 31; i++) { ctext[i] = true; }
            for (int i = 33; i <= 39; i++) { ctext[i] = true; }
            for (int i = 42; i <= 91; i++) { ctext[i] = true; }
            for (int i = 93; i <= 127; i++) { ctext[i] = true; }
            return ctext;
        }

        private static bool[] CreateCharactersAllowedInDomainLiterals()
        {
            // fdtext = %d1-8 / %d11 / %d12 / %d14-31 / %d33-90 / %d94-127
            var dtext = new bool[128];
            for (int i = 1; i <= 8; i++) { dtext[i] = true; }
            dtext[11] = true;
            dtext[12] = true;
            for (int i = 14; i <= 31; i++) { dtext[i] = true; }
            for (int i = 33; i <= 90; i++) { dtext[i] = true; }
            for (int i = 94; i <= 127; i++) { dtext[i] = true; }
            return dtext;
        }

        private static bool[] CreateCharactersAllowedInHeaderNames()
        {
            // ftext = %d33-57 / %d59-126
            var ftext = new bool[128];
            for (int i = 33; i <= 57; i++) { ftext[i] = true; }
            for (int i = 59; i <= 126; i++) { ftext[i] = true; }
            return ftext;
        }

        private static bool[] CreateCharactersAllowedInQuotedStrings()
        {
            // fqtext = %d1-9 / %d11 / %d12 / %d14-33 / %d35-91 / %d93-127
            var qtext = new bool[128];
            for (int i = 1; i <= 9; i++) { qtext[i] = true; }
            qtext[11] = true;
            qtext[12] = true;
            for (int i = 14; i <= 33; i++) { qtext[i] = true; }
            for (int i = 35; i <= 91; i++) { qtext[i] = true; }
            for (int i = 93; i <= 127; i++) { qtext[i] = true; }
            return qtext;
        }

        private static bool[] CreateCharactersAllowedInTokens()
        {
            // ttext = %d33-126 except '()<>@,;:\"/[]?='
            var ttext = new bool[128];
            for (int i = 33; i <= 126; i++) { ttext[i] = true; }
            ttext['('] = false;
            ttext[')'] = false;
            ttext['<'] = false;
            ttext['>'] = false;
            ttext['@'] = false;
            ttext[','] = false;
            ttext[';'] = false;
            ttext[':'] = false;
            ttext['\\'] = false;
            ttext['"'] = false;
            ttext['/'] = false;
            ttext['['] = false;
            ttext[']'] = false;
            ttext['?'] = false;
            ttext['='] = false;
            return ttext;
        }

        // characters allowed in atoms
        /// <summary>
        /// The atext
        /// </summary>
        internal static readonly bool[] Atext = CreateCharactersAllowedInAtoms();

        // characters allowed in quoted strings (not including Unicode)
        /// <summary>
        /// The qtext
        /// </summary>
        internal static readonly bool[] Qtext = CreateCharactersAllowedInQuotedStrings();

        // characters allowed in domain literals
        /// <summary>
        /// The dtext
        /// </summary>
        internal static readonly bool[] Dtext = CreateCharactersAllowedInDomainLiterals();

        // characters allowed in header names
        /// <summary>
        /// The ftext
        /// </summary>
        internal static readonly bool[] Ftext = CreateCharactersAllowedInHeaderNames();

        // characters allowed in tokens
        /// <summary>
        /// The ttext
        /// </summary>
        internal static readonly bool[] Ttext = CreateCharactersAllowedInTokens();

        // characters allowed inside of comments
        /// <summary>
        /// The ctext
        /// </summary>
        internal static readonly bool[] Ctext = CreateCharactersAllowedInComments();

    }
}
