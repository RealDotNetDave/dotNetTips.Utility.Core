// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Common
// Author           : David McCarter
// Created          : 07-30-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-21-2020
// ***********************************************************************
// <copyright file="ExceptionThrower.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace dotNetTips.Utility.Standard.Common
{
    /// <summary>
    /// Exception Thrower.
    /// </summary>
    public static class ExceptionThrower
    {
        /// <summary>
        /// Throws the ArgumentException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowArgumentException(string message, string paramName)
        {
            throw new ArgumentException(paramName, message.DefaultIfNull(Resources.ExMessageInvalidArgument));
        }

        /// <summary>
        /// Throws the ArgumentException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="ArgumentException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowArgumentException(string message, Exception innerException)
        {
            throw new ArgumentException(message.DefaultIfNull(Resources.ExMessageInvalidArgument), innerException);
        }

        /// <summary>
        /// Throws the ArgumentInvalidException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
        public static void ThrowArgumentInvalidException(string message, string paramName)
        {
            throw new ArgumentInvalidException(paramName, message.DefaultIfNull(Resources.ExMessageInvalidArgument));
        }

        /// <summary>
        /// Throws the ArgumentInvalidException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowArgumentInvalidException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
        public static void ThrowArgumentInvalidException(string message, Exception innerException)
        {
            throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ExMessageInvalidArgument), innerException);
        }

        /// <summary>
        /// Throws the argument null exception.
        /// </summary>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "8/12/2020", Status = Status.Available)]
        public static void ThrowArgumentNullException(string paramName)
        {
            throw new ArgumentNullException(paramName, Resources.ExMessageArgumentNull);
        }

        /// <summary>
        /// Throws the ArgumentNullException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowArgumentNullException(string message, string paramName)
        {
            throw new ArgumentNullException(paramName, message.DefaultIfNull(Resources.ExMessageArgumentNull));
        }

        /// <summary>
        /// Throws the ArgumentNullException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowArgumentNullException(string message, Exception innerException)
        {
            throw new ArgumentNullException(message.DefaultIfNull(Resources.ExMessageArgumentNull), innerException);
        }

        /// <summary>
        /// Throws the argument out of range exception.
        /// </summary>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
        public static void ThrowArgumentOutOfRangeException(string paramName)
        {
            throw new ArgumentOutOfRangeException(paramName, Resources.ExArgumentOutOfRange);
        }

        /// <summary>
        /// Throws the argument out of range exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
        public static void ThrowArgumentOutOfRangeException(string message, string paramName)
        {
            throw new ArgumentOutOfRangeException(paramName, message.DefaultIfNull(Resources.ExArgumentOutOfRange));
        }

        /// <summary>
        /// Throws the argument out of range exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowArgumentOutOfRangeException), author: "David McCarter", createdOn: "9/5/2020", modifiedOn: "9/5/2020", Status = Status.Available)]
        public static void ThrowArgumentOutOfRangeException(string message, Exception innerException)
        {
            throw new ArgumentOutOfRangeException(message.DefaultIfNull(Resources.ExArgumentOutOfRange), innerException);
        }

        /// <summary>
        /// Throws the ArgumentReadOnlyException.
        /// </summary>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentReadOnlyException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowArgumentReadOnlyCollectionException(string paramName)
        {
            throw new ArgumentReadOnlyException(Resources.ExMessageReadOnlyCollection, paramName);
        }

        /// <summary>
        /// Throws the ArgumentInvalidException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="directory">The directory.</param>
        /// <exception cref="DirectoryNotFoundException">Directory not found.</exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
        public static void ThrowDirectoryNotFoundException(string message, string directory)
        {
            throw new DirectoryNotFoundException(directory, message.DefaultIfNull(Resources.ExMessageDirectoryNotFound));
        }

        /// <summary>
        /// Throws the ArgumentInvalidException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information(nameof(ThrowDirectoryNotFoundException), author: "David McCarter", createdOn: "8/13/2020", modifiedOn: "8/13/2020", Status = Status.Available)]
        public static void ThrowDirectoryNotFoundException(string message, Exception innerException)
        {
            throw new ArgumentInvalidException(message.DefaultIfNull(Resources.ExMessageDirectoryNotFound), innerException);
        }

        /// <summary>
        /// Throws a InvalidOperationException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <exception cref="InvalidOperationException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowInvalidOperationException(string message)
        {
            throw new InvalidOperationException(message.DefaultIfNull(Resources.ExMessageInvalidOperation));
        }

        /// <summary>
        /// Throws a InvalidOperationException.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        /// <exception cref="InvalidOperationException"></exception>
        [MethodImpl(MethodImplOptions.NoInlining)]
        [ExcludeFromCodeCoverage]
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", Status = Status.Available)]
        public static void ThrowInvalidOperationException(string message, Exception innerException)
        {
            throw new InvalidOperationException(message.DefaultIfNull(Resources.ExMessageInvalidOperation), innerException);
        }

        private static string DefaultIfNull(this string value, string defaultValue)
        {
            return value ?? defaultValue ?? string.Empty;
        }
    }
}
