using System;
using System.Data.Services.Client;
using System.Diagnostics;
using System.Security;
using System.ServiceModel.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class ExceptionExtensionsTest
    {
        [TestMethod]
        public void IsCriticalTest()
        {
            var exGood = new NullReferenceException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsCritical());
            Assert.IsFalse(exBad.IsCritical());
        }

        [TestMethod]
        public void IsSecurityOrCriticalTest()
        {
            var exGood = new SecurityException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsSecurityOrCritical());
            Assert.IsFalse(exBad.IsSecurityOrCritical());
        }

        [TestMethod]
        public void IsFatalTest()
        {
            var exGood = new OutOfMemoryException();
            var exBad = new ArgumentNullException();

            Assert.IsTrue(exGood.IsFatal());
            Assert.IsFalse(exBad.IsFatal());
        }

        [TestMethod]
        public void GetAllMessagesTest()
        {
            var innerEx = new SecurityException("Messsage from SecurityException", new DataServiceClientException("Cannot access service!"));

            var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

            var messages = ex.GetAllMessages();

            Assert.IsTrue(messages.IsNotEmpty());
        }

        [TestMethod]
        public void GetAllMessagesWithStackTraceTest()
        {
            var innerEx = new SecurityException("Messsage from SecurityException", new DataServiceClientException("Cannot access service!"));

            var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

            var messages = ex.GetAllMessagesWithStackTrace(",");

            Assert.IsTrue(messages.HasItems());
        }
    }
}
