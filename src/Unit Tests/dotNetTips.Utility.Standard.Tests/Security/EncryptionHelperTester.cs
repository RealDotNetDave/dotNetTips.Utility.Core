// ***********************************************************************
// Assembly         : dotNetTips.Tips.Utility.Standard.Tests
// Author           : David McCarter
// Created          : 09-05-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="EncryptionHelperTester.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace dotNetTips.Tips.Utility.Standard.Tests.Security
{
    /// <summary>
    /// Class EncryptionHelperTester.
    /// </summary>
    [TestClass]
    public class EncryptionHelperTester
    {

        private const string _testString = "12345678901234567890";
        /// <summary>
        /// Encrypts the decrypt string test.
        /// </summary>
        [TestMethod]
        public void AesEncryptDecryptStringTest()
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).  
                // Same key must be used in encryption and decryption  
                using var aes = new AesManaged();

                // Encrypt string  
                var encrypted = EncryptionHelper.AesEncrypt(_testString, aes.Key, aes.IV);

                // Decrypt the bytes to a string.  
                var decrypted = EncryptionHelper.AesDecrypt(encrypted, aes.Key, aes.IV);

                Assert.AreEqual(_testString, decrypted);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Encryption/ Description test failed. {ex.Message}");
            }
        }

        [TestMethod]
        public void ComputeSha256HashTest()
        {
            var result = _testString.ComputeSha256Hash();

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }

        [TestMethod]
        public void GenerateAesKeyTest()
        {
            var result = EncryptionHelper.GenerateAesKey();

            Assert.IsTrue(result.HasItems());
        }

        [TestMethod]
        public void GenerateAesIVTest()
        {
            var result = EncryptionHelper.GenerateAesIV();

            Assert.IsTrue(result.HasItems());
        }

        [TestMethod]
        public void RijndaelEncryptDecryptStringTest()
        {
            try
            {
                // Create Rijndael that generates a new key and initialization vector (IV).  
                // Same key must be used in encryption and decryption  
                using var aes = new RijndaelManaged();

                // Encrypt string  
                var encrypted = EncryptionHelper.RijndaelEncrypt(_testString, aes.Key, aes.IV);

                // Decrypt the bytes to a string.  
                var decrypted = EncryptionHelper.RijndaelDecrypt(encrypted, aes.Key, aes.IV);

                Assert.AreEqual(_testString, decrypted);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Encryption/ Description test failed. {ex.Message}");
            }
        }
    }
}
