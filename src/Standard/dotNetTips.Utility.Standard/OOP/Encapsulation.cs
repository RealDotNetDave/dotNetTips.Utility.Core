// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-23-2019
// ***********************************************************************
// <copyright file="Encapsulation.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Properties;

namespace dotNetTips.Utility.Standard.OOP
{
    /// <summary>
    /// Class Encapsulation.
    /// </summary>
    public static class Encapsulation
    {

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <typeparam name="TException">The type of the t exception.</typeparam>
        /// <param name="condition">The condition.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="System.InvalidCastException"></exception>
        public static void TryValidateParam<TException>(bool condition, string paramName = "", string message = "") where TException : ArgumentException, new()
        {
            var t = typeof(TException);

            if (t.Name == nameof(Exception))
            {
                throw new InvalidCastException(string.Format(CultureInfo.CurrentUICulture, Resources.CannotBeOfTypeException, nameof(TException)));
            }

            var defaultMessage = Resources.ParameterIsInvalid;

            if (string.IsNullOrEmpty(message) == false)
            {
                defaultMessage = message;
            }

            if (condition == false)
            {
                var ex = Activator.CreateInstance(typeof(TException), paramName, defaultMessage).As<TException>();
                throw ex;
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static void TryValidateParam(IEnumerable collection, string paramName, string message = "")
        {
            if (collection.HasItems() == false)
            {
                if (message.IsNull())
                {
                    message = Resources.CollectionIsNullOrHasNoItems;
                }

                throw new ArgumentNullException(paramName, message);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static void TryValidateParam(FileInfo file, string paramName, string message = "")
        {
            if (file == null)
            {
                if (message.IsNull())
                {
                    message = Resources.FileCannotBeNull;
                }

                throw new ArgumentNullException(paramName, message);
            }
            else if (file.Exists == false)
            {
                if (message.IsNull())
                {
                    message = Resources.FileNotFound;
                }

                throw new FileNotFoundException(message, file.FullName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException">Argument cannot be null.</exception>
        /// <exception cref="DirectoryNotFoundException">Directory not found.</exception>
        /// <exception cref="System.ArgumentNullException">Argument cannot be null.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Directory not found.</exception>
        public static void TryValidateParam(DirectoryInfo directory, string paramName, string message = "")
        {
            if (directory == null)
            {
                if (message.IsNull())
                {
                    message = Resources.DirectoryCannotBeNull;
                }

                throw new ArgumentNullException(paramName, message);
            }
            else if (directory.Exists == false)
            {
                if (message.IsNull())
                {
                    message = Resources.DirectoryDoesNotExist;
                }

                throw new DirectoryNotFoundException(message, directory.FullName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(Enum value, string paramName, string message = "")
        {
            TryValidateParam(paramName, nameof(paramName));

            if (Enum.IsDefined(value.GetType(), value) == false)
            {
                if (message.IsNull())
                {
                    message = Resources.TheValueIsNotDefinedInTheEnumeration;
                }

                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(Guid value, string paramName, string message = "")
        {
            if (value.Equals(Guid.Empty))
            {
                if (message.IsNull())
                {
                    message = Resources.GuidIsEmpty;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries the validate parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException"></exception>
        /// TODO Edit XML Comment Template for TryValidateParam
        public static void TryValidateParam(Uri value, string paramName, string message = "")
        {
            if (value is null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    message = Resources.UriCannotBeNull;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        public static void TryValidateParam(string value, string paramName = "", string message = "")
        {
            if (value.IsNull())
            {
                if (message.IsNull())
                {
                    message = Resources.StringIsEmpty;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="size">The size.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(IEnumerable collection, int size, string paramName, string message = "")
        {
            TryValidateParam(collection, paramName, message);

            if (collection.Count() != size)
            {
                if (message.IsNull())
                {
                    message = Resources.CollectionSizeIsNotValid;
                }

                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="match">The match.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="ArgumentNullException">match</exception>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException">match</exception>
        /// <exception cref="ArgumentInvalidException">match</exception>
        /// <exception cref="System.ArgumentNullException">match</exception>
        /// <exception cref="System.ArgumentException">match</exception>
        public static void TryValidateParam(string value, Regex match, string paramName, string message = "")
        {
            if (match.IsNull())
            {
                throw new ArgumentNullException(nameof(match));
            }

            TryValidateParam(value, paramName, message);

            if (match.IsMatch(value) == false)
            {
                if (message.IsNull())
                {
                    message = Resources.StringIsNotValid;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="expected">The expected.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(string value, string expected, string paramName, string message = "")
        {
            TryValidateParam(value, paramName, message);

            if (value.Equals(expected, StringComparison.CurrentCultureIgnoreCase) == false)
            {
                if (message.IsNull())
                {
                    message = Resources.StringDoesNotMatch;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="expectedType">The expected type.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException"></exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(Type value, Type expectedType, string paramName, string message = "")
        {
            if (value != expectedType)
            {
                if (message.IsNull())
                {
                    message = Resources.InvalidType;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

        /// <summary>
        /// Tries to validate a method parameter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minimumLength">The minimum length.</param>
        /// <param name="maximumLength">The maximum length.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="dotNetTips.Utility.Standard.ArgumentInvalidException">
        /// </exception>
        /// <exception cref="ArgumentInvalidException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        public static void TryValidateParam(string value, int minimumLength, int maximumLength, string paramName, string message = "")
        {
            TryValidateParam(value, paramName, message);

            if (value.Length < minimumLength)
            {
                if (message.IsNull())
                {
                    message = Resources.StringDoesNotMatchMinimumLength;
                }

                throw new ArgumentInvalidException(message, paramName);
            }

            if (value.Length > maximumLength)
            {
                if (message.IsNull())
                {
                    message = Resources.StringDoesNotMatchMaximumLength;
                }

                throw new ArgumentInvalidException(message, paramName);
            }
        }

    }
}