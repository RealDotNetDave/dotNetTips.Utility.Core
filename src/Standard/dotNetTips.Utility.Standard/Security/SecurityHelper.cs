// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 10-07-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-19-2020
// ***********************************************************************
// <copyright file="SecurityHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.InteropServices;
using System.Security;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Security
{
    /// <summary>
    /// SecurityHelper.
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Compares two secure strings.
        /// </summary>
        /// <param name="value1">The value.</param>
        /// <param name="value2">The compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information(nameof(CompareSecureStrings), author: "David McCarter", createdOn: "10/7/2020", modifiedOn: "10/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool CompareSecureStrings(SecureString value1, SecureString value2)
        {
            Encapsulation.TryValidateParam(value1, nameof(value1));
            Encapsulation.TryValidateParam(value2, nameof(value2));

            var valid = false;
            var inputIntPtr = new IntPtr();
            var compareIntPtr = new IntPtr();

            try
            {
                inputIntPtr = Marshal.SecureStringToBSTR(value1);
                compareIntPtr = Marshal.SecureStringToBSTR(value2);

                valid = ( Marshal.PtrToStringUni(inputIntPtr) == Marshal.PtrToStringUni(compareIntPtr) );
            }
            finally
            {
                Marshal.ZeroFreeBSTR(inputIntPtr);
                Marshal.ZeroFreeBSTR(compareIntPtr);
            }

            return valid;
        }

        /// <summary>
        /// Converts a String to a SecureString.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>SecureString.</returns>
        [Information(nameof(LoadSecureString), author: "David McCarter", createdOn: "10/7/2020", modifiedOn: "10/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static SecureString LoadSecureString(string input)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            return LoadSecureString(input, false);
        }

        /// <summary>
        /// Converts a String to a SecureString.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="makeReadOnly">if set to <c>true</c> [make read only].</param>
        /// <returns>SecureString.</returns>
        [Information(nameof(LoadSecureString), author: "David McCarter", createdOn: "10/7/2020", modifiedOn: "10/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static SecureString LoadSecureString(string input, bool makeReadOnly)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            SecureString secureString = null;

            if (!string.IsNullOrEmpty(input))
            {
                secureString = new SecureString();
                var charArray = input.ToCharArray();

                for (var i = 0; i < charArray.Length; i++)
                {
                    secureString.AppendChar(charArray[i]);
                }

                if (makeReadOnly)
                {
                    secureString.MakeReadOnly();
                }
            }

            return secureString;
        }

        /// <summary>
        /// Converts a SecureString to a String.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(ReadSecureString), author: "David McCarter", createdOn: "10/7/2020", modifiedOn: "10/19/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static string ReadSecureString(SecureString input)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            var result = string.Empty;
            var inputIntPtr = new IntPtr();

            try
            {
                inputIntPtr = Marshal.SecureStringToBSTR(input);

                result = Marshal.PtrToStringUni(inputIntPtr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(inputIntPtr);
            }

            return result;
        }
    }
}
