using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotNetTips.Utility.Standard.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetTips.Utility.Standard.IO.Tests
{
    [TestClass()]
    public class PathHelperTests
    {
        [TestMethod()]
        public void PathContainsWildcardTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result= PathHelper.PathContainsWildcard(path);

            Assert.IsFalse(result);
        }
    }
}