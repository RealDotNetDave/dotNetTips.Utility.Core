using System;
using System.Collections.Generic;
using System.Text;
using dotNetTips.Tips.Utility.Standard.Tests.Properties;
using dotNetTips.Utility.Standard.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Serialization
{
    [TestClass]
   public class XmlHelperTests
    {
        [TestMethod]
        public void StringToXDocumentTest()
        {
            var result = XmlHelper.StringToXDocument(Resources.XmlTestData);

            Assert.IsNotNull(result);
        }
    }
}
