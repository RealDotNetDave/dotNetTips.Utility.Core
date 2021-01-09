using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Utility.Standard.Common.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests.Logging
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class LoggingHelperTest
    {

        [TestMethod]
        public void LogApplicationInformationTest()
        {
            var logger = new LoggerFactory().CreateLogger<LoggingHelperTest>();

            dotNetTips.Utility.Standard.Logging.LoggingHelper.LogApplicationInformation(logger);
        }

        [TestMethod]
        public void LogComputerInformationTest()
        {
            var logger = new LoggerFactory().CreateLogger<LoggingHelperTest>();

            dotNetTips.Utility.Standard.Logging.LoggingHelper.LogComputerInformation(logger);
        }

        [TestMethod]
        public void RetrieveAllExceptionMessagesTest()
        {
            var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

            var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

            Assert.IsTrue(result.Count() == 2);
        }

        [TestMethod]
        public void RetrieveAllExceptionsTest()
        {
            var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

            var result = LoggingHelper.RetrieveAllExceptions(testException);

            Assert.IsTrue(result.Count() == 2);
        }
    }
}
