// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 01-19-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-30-2019
// ***********************************************************************
// <copyright file="RandomData.cs" company="dotNetTips.Utility.Standard.Tester">
//     Copyright (c) dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Standard.Tester
{
    /// <summary>
    /// Methods to randomally generate data for testing.
    /// </summary>
    /// <remarks>Original code from: https://github.com/andrewseward/Any-.Net</remarks>
    public static class RandomData
    {
        /// <summary>
        /// The default maximum character for creating words.
        /// </summary>
        public const char DefaultMaxCharacter = 'z';

        /// <summary>
        /// The default minimum character for creating words.
        /// </summary>
        public const char DefaultMinCharacter = 'A';

        public const char DefaultMinCharacterRandomFile = 'A';
        public const char DefaultMaxCharacterRandomFile = 'Z';

        /// <summary>
        /// Long test string for testing.
        /// </summary>
        public const string LongTestString = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

        /// <summary>
        /// The domain extensions used to create random Url's.
        /// </summary>
        private static readonly string[] _domainExtensions = new string[] { ".com", ".co.uk", ".org", ".org.uk", ".net", ".us", ".com.au", ".es", ".fr", ".de", ".ly", ".gov", ".gov.uk", ".ac.uk" };

        /// <summary>
        /// The synchronize lock
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// The object used for retrieving a random number.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Picks a radom string from an array.
        /// </summary>
        /// <param name="words">The words.</param>
        /// <returns>System.String.</returns>
        private static string Of(params string[] words) => words[GenerateInteger(0, words.Length - 1)];

        /// <summary>
        /// Creates a random character.
        /// </summary>
        /// <returns>System.Char.</returns>
        public static char GenerateCharacter() => GenerateCharacter(DefaultMinCharacter, DefaultMaxCharacter);

        /// <summary>
        /// Creates a random character.
        /// </summary>
        /// <param name="minValue">The minimum character value.</param>
        /// <param name="maxValue">The maximum character value.</param>
        /// <returns>System.Char.</returns>
        public static char GenerateCharacter(char minValue, char maxValue) => (char)GenerateInteger(minValue, maxValue);

        /// <summary>
        /// Creates a Coordinate with random values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        public static T GenerateCoordinate<T>() where T : ICoordinate, new()
        {
            var coordinates = new T
            {
                X = RandomData.GenerateInteger(int.MinValue, int.MaxValue),
                Y = RandomData.GenerateInteger(int.MinValue, int.MaxValue)
            };

            return coordinates;
        }

        /// <summary>
        /// Creates collection of coordinates.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionCount">The collection count.</param>
        /// <returns>List&lt;T&gt;.</returns>
        public static List<T> GenerateCoordinateCollection<T>(int collectionCount) where T : ICoordinate, new()
        {
            var coordinates = new List<T>(collectionCount);

            for (var personCount = 0; personCount < collectionCount; personCount++)
            {
                coordinates.Add(GenerateCoordinate<T>());
            }

            return coordinates;
        }

        /// <summary>
        /// Creates a random decimal value.
        /// </summary>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <param name="decimalPlaces">The decimal places.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal GenerateDecimal(decimal minValue, decimal maxValue, int decimalPlaces)
        {
            var multiplier = ((decimal)decimalPlaces) * 10;

            var result = GenerateInteger((int)(minValue * multiplier), (int)(maxValue * multiplier)) / multiplier;

            return result;
        }

        /// <summary>
        /// Returns a random domain extension.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateDomainExtension() => Of(_domainExtensions);

        /// <summary>
        /// Creates a random email address.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateEmailAddress()
        {
            return $"{GenerateWord(5, 25, 'a', 'z')}@{GenerateWord(5, 25, 'a', 'z')}{GenerateDomainExtension()}";
        }

        /// <summary>
        /// Creates a random integer value.
        /// </summary>
        /// <param name="min">The minimum int.</param>
        /// <param name="max">The maximum int.</param>
        /// <returns>System.Int32.</returns>
        public static int GenerateInteger(int min = int.MinValue, int max = int.MaxValue)
        {
            lock (_lock)
            {
                return _random.Next(min, max);
            }
        }

        /// <summary>
        /// Creates a random key.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateKey()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty);
        }

        /// <summary>
        /// Creates a random string of number.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string GenerateNumber(int length)
        {
            var sb = new StringBuilder(length);

            for (int count = 0; count < length; count++)
            {
                sb.Append(_random.Next(0, 9));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Creates a IPerson type with random values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="addressLength">Length of the address.</param>
        /// <param name="cityLength">Length of the city.</param>
        /// <param name="countryLength">Length of the country.</param>
        /// <param name="firstNameLength">First length of the name.</param>
        /// <param name="lastNameLength">Last length of the name.</param>
        /// <param name="postalCodeLength">Length of the postal code.</param>
        /// <returns>T.</returns>
        public static T GeneratePerson<T>(int addressLength = 25, int cityLength = 15, int countryLength = 15, int firstNameLength = 15, int lastNameLength = 25, int postalCodeLength = 8) where T : IPerson, new()
        {
            var person = new T
            {
                Id = RandomData.GenerateKey(),
                Address1 = RandomData.GenerateWord(addressLength),
                Address2 = RandomData.GenerateWord(addressLength),
                BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
                CellPhone = GeneratePhoneNumberUSA(),
                City = RandomData.GenerateWord(cityLength),
                Country = RandomData.GenerateWord(countryLength),
                Email = RandomData.GenerateEmailAddress(),
                FirstName = RandomData.GenerateWord(firstNameLength),
                HomePhone = GeneratePhoneNumberUSA(),
                LastName = RandomData.GenerateWord(lastNameLength),
                PostalCode = RandomData.GenerateNumber(postalCodeLength)
            };

            return person;
        }

        /// <summary>
        /// Creates an IPerson collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collectionCount">The collection count.</param>
        /// <returns>List&lt;PersonFixed&gt;.</returns>
        public static PersonCollection<T> GeneratePersonCollection<T>(int collectionCount) where T : IPerson, new()
        {
            var people = new PersonCollection<T>(collectionCount);

            Parallel.For(0, collectionCount, index =>
            {
                people.Add(RandomData.GeneratePerson<T>());
            });

            return people;
        }

        /// <summary>
        /// Creates a US phone number.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GeneratePhoneNumberUSA()
        {
            return $"{RandomData.GenerateNumber(3)}-{RandomData.GenerateNumber(3)}-{RandomData.GenerateNumber(4)}";
        }

        /// <summary>
        /// Creates a random relative url.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateRelativeUrl()
        {
            var url = new StringBuilder();

            for (var i = 0; i < GenerateInteger(1, 10); i++)
            {
                url.Append(GenerateUrlPart());
            }

            url.Append("/");

            return url.ToString();
        }

        /// <summary>
        /// Creates a random Url.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateUrl()
        {
            return $"{GenerateUrlHostName()}{GenerateRelativeUrl()}";
        }

        /// <summary>
        /// Creates a randome url host name.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateUrlHostName()
        {
            return $"https://{GenerateUrlHostnameNoProtocol()}";
        }

        /// <summary>
        /// Creates a url without a protocol.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateUrlHostnameNoProtocol()
        {
            return $"www.{GenerateWord(1, 25, 'a', 'z')}.{GenerateUrlHostnameNoSubdomain()}";
        }

        /// <summary>
        /// Creates host name without a subdomain.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateUrlHostnameNoSubdomain()
        {
            return $"{GenerateWord(3, 25, 'a', 'z')}{GenerateDomainExtension()}";
        }

        /// <summary>
        /// Create a random url part.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateUrlPart()
        {
            return $"/{GenerateWord(1, 25, 'a', 'z')}";
        }

        /// <summary>
        /// Creates a random word.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        public static string GenerateWord(int length) => GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);

        /// <summary>
        /// Creates a random word.
        /// </summary>
        /// <param name="minLength">The minimum length.</param>
        /// <param name="maxLength">The maximum length.</param>
        /// <returns>System.String.</returns>
        public static string GenerateWord(int minLength, int maxLength) => GenerateWord(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);

        /// <summary>
        /// Creates a random word.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="minCharacter">The minimum character.</param>
        /// <param name="maxCharacter">The maximum character.</param>
        /// <returns>System.String.</returns>
        public static string GenerateWord(int length, char minCharacter, char maxCharacter)
        {
            var word = new StringBuilder(length);

            for (var wordCount = 0; wordCount < length; wordCount++)
            {
                word.Append(GenerateCharacter(minCharacter, maxCharacter));
            }

            return word.ToString();
        }

        /// <summary>
        /// Creates a random word.
        /// </summary>
        /// <param name="minLength">The minimum length.</param>
        /// <param name="maxLength">The maximum length.</param>
        /// <param name="minCharacter">The minimum character.</param>
        /// <param name="maxCharacter">The maximum character.</param>
        /// <returns>System.String.</returns>
        public static string GenerateWord(int minLength, int maxLength, char minCharacter, char maxCharacter) => GenerateWord(GenerateInteger(minLength, maxLength), minCharacter, maxCharacter);

        /// <summary>
        /// Generates the random file name with path (users temp folder).
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GenerateRandomFileName() => Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

        /// <summary>
        /// Generates the random name of the file.
        /// </summary>
        /// <param name="fileNameLength">Length of the file name.</param>
        /// <param name="extension">The extension.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GenerateRandomFileName
        public static string GenerateRandomFileName(int fileNameLength = 10, string extension = "tester.temp")
        {
            var fileName = GenerateWord(fileNameLength, DefaultMinCharacterRandomFile, DefaultMaxCharacterRandomFile) + "." + extension;
            var fullName = Path.Combine(Path.GetTempPath(), fileName);

            return fullName;
        }

        /// <summary>
        /// Generates the file.
        /// </summary>
        /// <param name="fileLength">The length.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GenerateFile
        public static string GenerateTempFile(int fileLength = 1000)
        {
            var fileName = GenerateRandomFileName();
            var fakeText = GenerateWord(fileLength);

            File.WriteAllText(fileName, fakeText);

            return fileName;
        }

        /// <summary>
        /// Generates the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="fileLength">Length of the file.</param>
        /// <returns>System.String.</returns>
        /// TODO Edit XML Comment Template for GenerateFile
        public static string GenerateFile(string fileName, int fileLength = 1000)
        {
            var fakeText = GenerateWord(fileLength  );

            File.WriteAllText(fileName, fakeText);

            return fileName;
        }

        /// <summary>
        /// Generates files.
        /// </summary>
        /// <param name="count">The file count.</param>
        /// <param name="fileLength">Length of the file.</param>
        /// <returns>System.ValueTuple&lt;System.String, IEnumerable&lt;System.String&gt;&gt;.</returns>
        public static (string Path, IEnumerable<string> Files) GenerateFiles(int count = 100, int fileLength = 1000)
        {
            var files = new List<string>(count);

            for (int fileCount = 0; fileCount < count; fileCount++)
            {
                files.Add(GenerateTempFile(fileLength));
            }


            return (Path.GetTempPath(), files.AsEnumerable());
        }

        /// <summary>
        /// Generates the files.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="fileLength">Length of the file.</param>
        /// <param name="fileExtension">The file extension.</param>
        /// <returns>System.ValueTuple&lt;System.String, IEnumerable&lt;System.String&gt;&gt;.</returns>
        /// TODO Edit XML Comment Template for GenerateFiles
        public static (string Path, IEnumerable<string> Files) GenerateFiles(int count = 100, int fileLength = 1000, string fileExtension="temp")
        {
            var files = new List<string>(count);

            for (int fileCount = 0; fileCount < count; fileCount++)
            {
                var fileName = GenerateRandomFileName(25, fileExtension);
                files.Add(GenerateFile(fileName, fileLength));
            }


            return (Path.GetTempPath(), files.AsEnumerable());
        }
    }
}
