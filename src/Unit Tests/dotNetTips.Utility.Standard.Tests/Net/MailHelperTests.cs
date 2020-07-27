using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace dotNetTips.Tips.Utility.Standard.Tests.Net
{
    [TestClass]
    public class MailHelperTests
    {
        [TestMethod]
        public void TryParseAddressSingleTest()
        {
            var address = "David McCarter <dotnetdave@live.com>";

            var result = MailHelper.TryParseAddress(address, out ParseAddressInfo parsedAddress, true);

            Assert.IsTrue(result);
            Assert.IsTrue(parsedAddress.IsNotNull());
            Assert.IsTrue(parsedAddress.ToString().HasValue());
        }

        [TestMethod]
        public void TryParseAddressMultiTest()
        {
            var address = "dotNetDave <dotnetdave@live.com>, David McCarter <davidmccarter@live.com>";

            var result = MailHelper.TryParseAddresses(address, out ParseAddressInfo[] parsedAddress, true);

            Assert.IsTrue(result);
            Assert.IsTrue(parsedAddress.Count() == 2);
        }
    }
}
