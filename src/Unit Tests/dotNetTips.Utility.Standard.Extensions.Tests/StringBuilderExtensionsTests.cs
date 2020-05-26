using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringBuilderExtensionsTests
    {
        [TestMethod]
        public void AppendBytesTest()
        {
            var sb = new StringBuilder();
            var byteArray = RandomData.GenerateByteArray(2);
            sb.AppendBytes(byteArray);

            Assert.IsTrue(sb.Length > 50);
        }
    }
}
