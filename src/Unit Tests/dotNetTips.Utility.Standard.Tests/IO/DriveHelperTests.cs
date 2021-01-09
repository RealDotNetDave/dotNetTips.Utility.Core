using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.IO
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DriveHelperTests
    {
        [TestMethod]
        public void GetDriveSerialNumberTest()
        {
            Assert.IsNotNull(DriveHelper.GetDriveSerialNumber(@"c:\"));
        }
    }
}
