// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 09-05-2018
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2020
// ***********************************************************************
// <copyright file="EncryptionHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using System.IO;
using System.Security.Cryptography;

namespace dotNetTips.Utility.Standard.Security
{
    /// <summary>
    /// Class EncryptionHelper.
    /// </summary>
    public static class EncryptionHelper
    {

        /// <summary>
        /// Encrypts a string using Aes security.
        /// </summary>
        /// <param name="plainText">The input.</param>
        /// <param name="key">The secret key.</param>
        /// <param name="iv">The initialization vector.</param>
        /// <returns>System.Byte[].</returns>
        /// <remarks>Original code by: Mahesh Chand</remarks>
        public static byte[] AesEncrypt(string plainText, byte[] key, byte[] iv)
        {
            Encapsulation.TryValidateParam(plainText, nameof(plainText));
            Encapsulation.TryValidateParam(key, nameof(key));
            Encapsulation.TryValidateParam(key, nameof(iv));

            byte[] encrypted;
            // RijndaelManaged

            // Create a new AesManaged.    
            using (var aes = new AesManaged())
            {
                // Create encryptor    
                using (var encryptor = aes.CreateEncryptor(key, iv))
                {
                    // Create MemoryStream    
                    using (var ms = new MemoryStream())
                    {
                        // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                        // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                        // to encrypt    
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            // Create StreamWriter and write data to a stream    
                            using (var sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }

                            encrypted = ms.ToArray();
                        }
                    }
                }
            }

            return encrypted;
        }


        /// <summary>
        /// Encrypts a string using Rijndael security.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <param name="key">The secret key.</param>
        /// <param name="iv">The initialization vector.</param>
        /// <returns>System.Byte[].</returns>
        public static byte[] RijndaelEncrypt(string plainText, byte[] key, byte[] iv)
        {
            Encapsulation.TryValidateParam(plainText, nameof(plainText));
            Encapsulation.TryValidateParam(key, nameof(key));
            Encapsulation.TryValidateParam(key, nameof(iv));

            byte[] encrypted;

            // Create a new RijndaelManaged.    
            using (var aes = new RijndaelManaged())
            {
                // Create encryptor    
                using (var encryptor = aes.CreateEncryptor(key, iv))
                {
                    // Create MemoryStream    
                    using (var ms = new MemoryStream())
                    {
                        // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                        // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                        // to encrypt    
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            // Create StreamWriter and write data to a stream    
                            using (var sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }

                            encrypted = ms.ToArray();
                        }
                    }
                }
            }

            return encrypted;
        }
        /// <summary>
        /// Decrypts array to string using AES security.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="key">The secret key.</param>
        /// <param name="iv">The initialization vector.</param>
        /// <returns>System.String.</returns>
        /// <remarks>Original code by: Mahesh Chand</remarks>
        public static string AesDecrypt(byte[] cipherText, byte[] key, byte[] iv)
        {
            Encapsulation.TryValidateParam(cipherText, nameof(cipherText));
            Encapsulation.TryValidateParam(key, nameof(key));
            Encapsulation.TryValidateParam(key, nameof(iv));

            string text = null;

            // Create AesManaged    
            using (var aes = new AesManaged())
            {
                // Create a decryptor    
                using (var decryptor = aes.CreateDecryptor(key, iv))
                {
                    // Create the streams used for decryption.    
                    using (var ms = new MemoryStream(cipherText))
                    {
                        // Create crypto stream    
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            // Read crypto stream    
                            using (var reader = new StreamReader(cs))
                            {
                                text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            return text;
        }

        /// <summary>
        /// Decrypts array to string using Rijndael security.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="key">The secret key.</param>
        /// <param name="iv">The initialization vector.</param>
        /// <returns>System.String.</returns>
        public static string RijndaelDecrypt(byte[] cipherText, byte[] key, byte[] iv)
        {
            Encapsulation.TryValidateParam(cipherText, nameof(cipherText));
            Encapsulation.TryValidateParam(key, nameof(key));
            Encapsulation.TryValidateParam(key, nameof(iv));

            string text = null;

            // Create RijndaelManaged    
            using (var aes = new RijndaelManaged())
            {
                // Create a decryptor    
                using (var decryptor = aes.CreateDecryptor(key, iv))
                {
                    // Create the streams used for decryption.    
                    using (var ms = new MemoryStream(cipherText))
                    {
                        // Create crypto stream    
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            // Read crypto stream    
                            using (var reader = new StreamReader(cs))
                            {
                                text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            return text;
        }
    }
}
