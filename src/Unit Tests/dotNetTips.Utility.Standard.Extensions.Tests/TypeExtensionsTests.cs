using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class TypeExtensionsTests
    {
        [TestMethod]
        public void GetAllFieldsTest()
        {
            var result = typeof(TestType).GetAllFields();

            Assert.IsTrue(result.Count() == 2);

            result = typeof(PersonProper).GetAllFields();

            Assert.IsTrue(result.Count() == 12);
        }

        [TestMethod]
        public void GetAllMethodsTest()
        {
            var result = typeof(TestType).GetAllMethods();

            Assert.IsTrue(result.Count() == 13);

            result = typeof(PersonProper).GetAllMethods();

            Assert.IsTrue(result.Count() == 45);
        }

        [TestMethod]
        public void GetAbstractMethodsTest()
        {
            var result = typeof(AbstractTestType).GetAllAbstractMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetPropertiesTest()
        {
            var result = typeof(PersonProper).GetAllProperties();

            Assert.IsTrue(result.Count() == 13);
        }

        [TestMethod]
        public void GetGenericMethodsTest()
        {
            var result = typeof(TestType).GetAllGenericMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetPublicMethodsTest()
        {
            var result = typeof(PersonProper).GetAllPublicMethods();

            Assert.IsTrue(result.Count() == 37);
        }

        [TestMethod]
        public void GetStaticMethodsTest()
        {
            var result = typeof(TestType).GetAllStaticMethods();

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void GetTypeMembersWithGivenAttributeTest()
        {
            //var result = GetFieldsAndProperties(typeof(TestType), BindingFlags.Default);

            var result = typeof(TestType).GetTypeMembersWithAttribute<XmlIgnoreAttribute>();

            Assert.IsTrue(result.Count() == 1);
        }
    }

    public class TestType
    {
        [XmlIgnore]
        private readonly string _test = "Test";

        /// <summary>
        /// Invokes the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public string Invoke(string input)
        {
            return input;
        }

        public void Run<T>() where T : class
        {
            //Do Nothing
        }

        [XmlIgnore]
        public string UserName { get; set; }


        public static string GetName()
        {
            return "GetName";
        }
    }

    public abstract class AbstractTestType
    {
        public abstract string Name();
    }
}
