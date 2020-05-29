using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void AsTest()
        {
            var personProper = RandomData.GeneratePerson<PersonFixed>();

            try
            {
                Assert.IsNotNull(personProper.As<IPerson>());
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Assert.Fail();
            }
        }
    }
}