using dotNetTips.Utility.Standard.IO;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace dotNetTips.Utility.Standard.Tester.Tests
{
    [TestClass]
    public class RandomDataTests
    {
        private const int _fileLength = 5000;

        [TestMethod]
        public void GenerateCharacterTest()
        {
            var character = RandomData.GenerateCharacter();

            Assert.IsNotNull(character);
        }

        [TestMethod]
        public void GenerateCharacterTestWithMinMaxCharTest()
        {
            var character = RandomData.GenerateCharacter('A', 'A');

            Assert.IsNotNull(character);

            Assert.IsTrue(character == 'A');
        }

        [TestMethod]
        public void GenerateCoordinateCollectionTest()
        {
            const int count = 100;

            var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(count);

            Assert.IsNotNull(coordinates);

            Assert.IsTrue(coordinates.Count() == count);

        }

        [TestMethod]
        public void GenerateCoordinateFixedTest()
        {
            var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

            Assert.IsNotNull(coordinate);

            Assert.IsNotNull(coordinate.ToString());

        }

        [TestMethod]
        public void GenerateCoordinateTest()
        {
            var coordinate = RandomData.GenerateCoordinate<Coordinate>();

            Assert.IsNotNull(coordinate);

            Assert.IsNotNull(coordinate.ToString());

        }

        [TestMethod]
        public void GenerateDecimalTest()
        {
            var decimalValue = RandomData.GenerateDecimal(0, 100, 2);

            Assert.IsTrue(decimalValue >= 0);
            Assert.IsTrue(decimalValue <= 100);
        }

        [TestMethod]
        public void GenerateDomainExtensionTest()
        {
            var stringValue = RandomData.GenerateDomainExtension();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateEmailAddressTest()
        {
            var stringValue = RandomData.GenerateEmailAddress();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateFilesTest()
        {
            const int length = 500;
            const int count = 100;

            var files = RandomData.GenerateFiles(count, length);

            Assert.IsNotNull(files);

            Assert.IsNotNull(files.Path);

            Assert.IsTrue(files.Files.Count() == count);

            FileHelper.DeleteFiles(files.Files);
        }

        [TestMethod]
        public void GenerateFilesWithExtTest()
        {
            const int length = 500;
            const int count = 100;

            var files = RandomData.GenerateFiles(count, length, "test");

            Assert.IsNotNull(files);

            Assert.IsNotNull(files.Path);

            Assert.IsTrue(files.Files.Count() == count);

            FileHelper.DeleteFiles(files.Files);
        }

        [TestMethod]
        public void GenerateFilesWithPathTest()
        {
            const int length = 500;
            const int count = 100;

            var files = RandomData.GenerateFiles(@"c:\temp", count, length);

            Assert.IsNotNull(files);

            Assert.IsTrue(files.Count() == count);

            FileHelper.DeleteFiles(files);
        }

        [TestMethod]
        public void GenerateFileTest()
        {
            const int length = _fileLength;
            var fileName = RandomData.GenerateFile(@"c:\temp\UnitTest.test", fileLength: length);

            Assert.IsNotNull(fileName);

            var testFile = new FileInfo(fileName);

            Assert.IsTrue(testFile.Exists);

            Assert.IsTrue(length == testFile.Length);

            testFile.Delete();
        }

        [TestMethod]
        public void GenerateGenerateUrlHostNameTest()
        {
            var stringValue = RandomData.GenerateUrlHostName();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateIntegerTest()
        {
            var intValue = RandomData.GenerateInteger(0, 1000);

            Assert.IsTrue(intValue >= 0);
            Assert.IsTrue(intValue <= 1000);
        }

        [TestMethod]
        public void GenerateKeyTest()
        {
            var stringValue = RandomData.GenerateKey();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateNumberTest()
        {
            var stringValue = RandomData.GenerateNumber(15);

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(stringValue.Length == 15);
        }

        [TestMethod]
        public void GeneratePersonCollectionTest()
        {
            const int count = 100;

            var people = RandomData.GeneratePersonCollection<PersonProper>(count);

            Assert.IsNotNull(people);

            Assert.IsTrue(people.Count == count);

        }

        [TestMethod]
        public void GeneratePersonFixedTest()
        {
            var person = RandomData.GeneratePerson<PersonFixed>();

            Assert.IsNotNull(person);

            Assert.IsNotNull(person.Address1);

            Assert.IsNotNull(person.Address2);

            Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

            Assert.IsNotNull(person.CellPhone);

            Assert.IsNotNull(person.City);

            Assert.IsNotNull(person.Country);

            Assert.IsNotNull(person.Email);

            Assert.IsNotNull(person.FirstName);

            Assert.IsNotNull(person.HomePhone);

            Assert.IsNotNull(person.Id);

            Assert.IsNotNull(person.LastName);

            Assert.IsNotNull(person.PostalCode);

            Assert.IsTrue(person.Age.TotalMinutes > 0);

            Assert.IsNotNull(person.ToString());
        }


        [TestMethod]
        public void GeneratePersonProperTest()
        {
            var person = RandomData.GeneratePerson<PersonProper>();

            Assert.IsNotNull(person);

            Assert.IsNotNull(person.Address1);

            Assert.IsNotNull(person.Address2);

            Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

            Assert.IsNotNull(person.CellPhone);

            Assert.IsNotNull(person.City);

            Assert.IsNotNull(person.Country);

            Assert.IsNotNull(person.Email);

            Assert.IsNotNull(person.FirstName);

            Assert.IsNotNull(person.HomePhone);

            Assert.IsNotNull(person.Id);

            Assert.IsNotNull(person.LastName);

            Assert.IsNotNull(person.PostalCode);

            Assert.IsTrue(person.Age.TotalMinutes > 0);

            Assert.IsNotNull(person.ToString());
        }

        [TestMethod]
        public void GeneratePersonTest()
        {
            var person = RandomData.GeneratePerson<Person>();

            Assert.IsNotNull(person);

            Assert.IsNotNull(person.Address1);

            Assert.IsNotNull(person.Address2);

            Assert.IsTrue(person.BornOn > DateTimeOffset.Parse("1/1/1800"));

            Assert.IsNotNull(person.CellPhone);

            Assert.IsNotNull(person.City);

            Assert.IsNotNull(person.Country);

            Assert.IsNotNull(person.Email);

            Assert.IsNotNull(person.FirstName);

            Assert.IsNotNull(person.HomePhone);

            Assert.IsNotNull(person.Id);

            Assert.IsNotNull(person.LastName);

            Assert.IsNotNull(person.PostalCode);

            Assert.IsNotNull(person.ToString());
        }

        [TestMethod]
        public void GeneratePhoneNumberUSATest()
        {
            var stringValue = RandomData.GeneratePhoneNumberUSA();

            Assert.IsNotNull(stringValue);
        }


        [TestMethod]
        public void GenerateRandomFileNameAllParamsTest()
        {
            const string extension = "dotnettips";

            var stringValue = RandomData.GenerateRandomFileName(@"c:\temp", fileNameLength: 10, extension: extension);

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + extension.Length + 1);

            Assert.IsTrue(stringValue.EndsWith(extension));
        }

        [TestMethod]
        public void GenerateRandomFileNameWithExtTest()
        {
            const string extension = "dotnettips";

            var stringValue = RandomData.GenerateRandomFileName(fileNameLength: 10, extension: extension);

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(new FileInfo(stringValue).Name.Length == 10 + extension.Length + 1);

            Assert.IsTrue(stringValue.EndsWith(extension));
        }

        [TestMethod]
        public void GenerateRandomFileNameTest()
        {
            var stringValue = RandomData.GenerateRandomFileName();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateRandomFileNameWithPathTest()
        {
            var stringValue = RandomData.GenerateRandomFileName(@"c:\temp");

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateRelativeUrlTest()
        {
            var stringValue = RandomData.GenerateRelativeUrl();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateTempFileTest()
        {
            var stringValue = RandomData.GenerateTempFile(_fileLength);

            Assert.IsNotNull(stringValue);

            var tempFile = new FileInfo(stringValue);

            Assert.IsTrue(tempFile.Exists);

            Assert.IsTrue(tempFile.Length == _fileLength);

            tempFile.Delete();
        }

        [TestMethod]
        public void GenerateUrlHostnameNoProtocolTest()
        {
            var stringValue = RandomData.GenerateUrlHostnameNoProtocol();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateUrlHostnameNoSubdomainTest()
        {
            var stringValue = RandomData.GenerateUrlHostnameNoSubdomain();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateUrlPartTest()
        {
            var stringValue = RandomData.GenerateUrlPart();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateUrlTest()
        {
            var stringValue = RandomData.GenerateUrl();

            Assert.IsNotNull(stringValue);
        }

        [TestMethod]
        public void GenerateWordLengthWithCharactersTest()
        {
            var stringValue = RandomData.GenerateWord(length: 10, minCharacter: 'A', maxCharacter: 'Z');

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(stringValue.Length == 10);
        }

        [TestMethod]
        public void GenerateWordMinMaxLengthTest()
        {
            var stringValue = RandomData.GenerateWord(minLength: 10, maxLength: 25);

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(stringValue.Length >= 10);

            Assert.IsTrue(stringValue.Length <= 25);
        }

        [TestMethod]
        public void GenerateWordMinMaxLengthWithCharactersTest()
        {
            var stringValue = RandomData.GenerateWord(minLength: 5, maxLength: 25, minCharacter: 'A', maxCharacter: 'Z');

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(stringValue.Length >= 5);

            Assert.IsTrue(stringValue.Length <= 25);
        }

        [TestMethod]
        public void GenerateWordTest()
        {
            var stringValue = RandomData.GenerateWord(25);

            Assert.IsNotNull(stringValue);

            Assert.IsTrue(stringValue.Length == 25);
        }

        [TestMethod]
        public void GenerateWordsTest()
        {
            const int wordCount = 10;

            var words = RandomData.GenerateWords(wordCount, 10, 25);

            Assert.IsTrue(words.Count == wordCount);
        }

        [TestMethod]
        public void GenerateByteArrayTest()
        {
            var byteArray = RandomData.GenerateByteArray(10);

            Assert.IsTrue(byteArray.Count() > 0);
        }
    }
}
