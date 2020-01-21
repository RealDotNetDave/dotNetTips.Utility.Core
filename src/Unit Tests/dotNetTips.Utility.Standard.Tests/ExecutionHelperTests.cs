using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetTips.Tips.Utility.Standard.Tests
{
    [TestClass]
    public class ExecutionHelperTests
    {
        [TestMethod]
        public void ProgressiveRetryTest()
        {
            var tries = 0;

            try
            {
                tries = ExecutionHelper.ProgressiveRetry(() =>
                  {
                      var drives = DriveHelper.GetRemovableDrives();
                  }, 3, 10);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Progressive retry failed: {ex.Message}.");
            }

            Assert.IsTrue(tries > 0);
        }
    }
}
