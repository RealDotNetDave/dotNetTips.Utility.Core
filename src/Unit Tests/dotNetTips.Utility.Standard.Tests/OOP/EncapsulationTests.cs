using dotNetTips.Utility.Standard.OOP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace dotNetTips.Tips.Utility.Standard.Tests.OOP
{
    [TestClass]
    public class EncapsulationTests
    {

        private const string _goodEmail = "fakeemail@google.com";
        private const string _goodUrl = "http://www.amazon.com";

        [TestMethod]
        public void TryValidateParamStringEmailTest()
        {
            try
            {
                Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 0, 100, "none");
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TryValidateParamStringUrlTest()
        {
            try
            {
                Encapsulation.TryValidateParam(_goodUrl, StringType.Url, 0, 100, "none");
            }
            catch
            {
                Assert.Fail();
            }

        }

    }
}