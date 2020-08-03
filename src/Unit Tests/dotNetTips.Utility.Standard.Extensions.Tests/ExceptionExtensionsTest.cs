using System;
using System.Security;
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
    }
}
