// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="StringBuilderExtensionsTests.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using System.Text;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringBuilderExtensionsTests
    {

        [TestMethod]
        public void AppendBytesTest()
        {
            var sb = new StringBuilder();
            var byteArray = RandomData.GenerateByteArray(sizeInKb: 1);
            sb.AppendBytes(byteArray);

            Assert.IsTrue(sb.Length > 50);
        }

        [TestMethod]
        public void AppendJoinTest01()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

            sb.AppendValues(", ", values);

            Assert.IsTrue(sb.Length > 10);
        }


        [TestMethod]
        public void AppendJoinTest02()
        {
            var sb = new StringBuilder();
            var values = RandomData.GenerateCoordinateCollection<Coordinate>(count: 15);

            sb.AppendValues(", ", values, (person) =>
             {
                 sb.Append(person.X);
                 sb.Append(ControlChars.Colon);
                 sb.Append(person.Y);
             });

            Assert.IsTrue(sb.Length > 50);
        }

        [TestMethod]
        public void AppendKeyValueTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);

            var sb = new StringBuilder();

            foreach (var person in people)
            {
                sb.AppendKeyValue(person.Key, person.Value.Email);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
                sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);

                Assert.ThrowsException<ArgumentException>(() => sb.AppendKeyValue(person.Key, null));
                Assert.ThrowsException<ArgumentException>(() => sb.AppendKeyValue(null, person.Value.Email));
            }

            Assert.IsTrue(sb.ToString().Length > 50 * 4);
        }

    }
}
