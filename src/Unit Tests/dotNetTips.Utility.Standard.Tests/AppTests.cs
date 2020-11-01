using System.Diagnostics;
using dotNetTips.Utility.Standard;
using dotNetTips.Utility.Standard.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Tips.Utility.Standard.Tests
{
    [TestClass]
    public class AppTests
    {

        [TestMethod]
        public void AppInfoTest()
        {
            var info = App.AppInfo;

            Assert.IsTrue(info.IsNotNull());
        }

        [TestMethod]
        public void ChangeCultureTest()
        {
            App.ChangeCulture("aa");

            Assert.AreEqual("aa", App.CurrentCulture.Name);

            App.ChangeUICulture("af");

            Assert.AreEqual("af", App.CurrentUICulture.Name);

            App.ChangeCulture("en-US");
            App.ChangeUICulture("en-US");
        }

        [TestMethod]
        public void ComputerInfoTest()
        {
            var ci = new ComputerInfo();

            Assert.IsNotNull(ci);

            var json = ci.ToJson();

            Debug.WriteLine(json);
        }

        [TestMethod]
        public void ExecutingFolderTest()
        {
            var result = App.ExecutingFolder();

            Assert.IsTrue(result.IsNotEmpty());
        }

        [TestMethod]
        public void FrameworkDescriptionTest()
        {
            var result = App.FrameworkDescription;

            Assert.IsTrue(result.IsNotEmpty());
        }

        [TestMethod]
        public void GetCultureTest()
        {
            var result = App.CurrentCulture;

            Assert.IsNotNull(result);

            result = App.CurrentUICulture;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetEnvironmentVariablesTest()
        {
            var result = App.GetEnvironmentVariables();

            Assert.IsTrue(result.HasItems());

            foreach (var info in result)
            {
                Debug.WriteLine("{0}:{1}", info.Key, info.Value);
            }
        }

        [TestMethod]
        public void IsProcessRunningTest()
        {
            var result = App.IsProcessRunning("devenv");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRunningFromAspNet()
        {
            var result = App.IsRunningFromAspNet();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRunningTest()
        {
            var result = App.IsRunning();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsUserAdministrator()
        {
            var result = App.IsUserAdministrator();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StackTraceTest()
        {
            var result = App.StackTrace;

            Assert.IsTrue(result.IsNotEmpty());
        }

        [TestMethod]
        public void WorkingSetTest()
        {
            var result = App.WorkingSet;

            Assert.IsTrue(result > 0);
        }

    }
}
