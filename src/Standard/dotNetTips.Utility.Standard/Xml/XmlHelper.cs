// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2020
// ***********************************************************************
// <copyright file="XmlHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.OOP;

namespace dotNetTips.Utility.Standard.Xml
{
    /// <summary>
    /// XML Serialization helper methods.
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// Deserialize the specified XML.
        /// </summary>
        /// <typeparam name="TResult">Type</typeparam>
        /// <param name="xml">The XML.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">xml</exception>
        public static TResult Deserialize<TResult>(string xml)
        {
            Encapsulation.TryValidateParam(xml, nameof(xml));

            using (var sr = new StringReader(xml))
            {
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(TResult));
                return (TResult)xs.Deserialize(sr);
            }
        }

        /// <summary>
        /// De-serializes from XML file.
        /// </summary>
        /// <typeparam name="TResult">Type</typeparam>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>T.</returns>
        /// <exception cref="FileNotFoundException">File not found. Cannot deserialize from XML.</exception>
        public static TResult DeserializeFromXmlFile<TResult>(string fileName)
        {
            Encapsulation.TryValidateParam(fileName, nameof(fileName));

            if (File.Exists(fileName) == false)
            {
                throw new FileNotFoundException("File not found. Cannot deserialize from XML.", fileName);
            }

            return Deserialize<TResult>(File.ReadAllText(fileName));
        }

        /// <summary>
        /// Serializes the specified obj to xml.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">obj</exception>
        public static string Serialize(object obj)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));

            using (var writer = new StringWriter())
            {
                using (var xmlWriter = System.Xml.XmlWriter.Create(writer))
                {
                    var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                    serializer.Serialize(xmlWriter, obj);

                    return writer.ToString();
                }
            }
        }

        /// <summary>
        /// Serializes obj to XML file.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <param name="fileName">Name of the file.</param>
        public static void SerializeToXmlFile(object obj, string fileName)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
            Encapsulation.TryValidateParam(fileName, nameof(fileName));

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            File.WriteAllText(fileName, Serialize(obj));
        }

        /// <summary>
        /// Securely convert string to XDocument.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>XDocument.</returns>
        [Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.New, UnitTestCoverage = 100, BenchMarkStatus = 0)]
        public static XDocument StringToXDocument(string input)
        {
            return StringToXDocument(input, null);
        }

        /// <summary>
        /// Securely convert string to XDocument.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="resolver">The resolver.</param>
        /// <returns>XDocument.</returns>
        /// <remarks>Uses DtdProcessing.Prohibit</remarks>
        [Information(nameof(StringToXDocument), "David McCarter", "9/9/2020", "9/9/2020", Status = Status.New, UnitTestCoverage = 100, BenchMarkStatus = 0)]
        public static XDocument StringToXDocument(string input, XmlResolver resolver)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            var options = new System.Xml.XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver  };
        
            using (var reader = XmlReader.Create(new StringReader(input), options))
            {
                return XDocument.Load(reader);
            }
        }
    }
}
