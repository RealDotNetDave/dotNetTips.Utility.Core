using System;
using System.Runtime.InteropServices;
using dotNetTips.Utility.Core.Windows.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace dotNetTips.Utility.Core.Windows.Tests
{
    [TestClass]
    public class RegistryHelperTests
    {
        [TestMethod]
        public void GetRegistryKeyTest()
        {
            const string CurrentUserEnvironment = @"Environment";
            const string ClassesVisualStudio = @"Microsoft.VisualStudio.Setup.Configuration";
            const string CurrentConfigFonts = @"Software\Fonts";
            const string LocalMachineMicrosoft = @"SOFTWARE\Microsoft";
            const string UsersConsole = @"Console";

            //Test invalid platform
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
            {
                _ = Assert.ThrowsException<PlatformNotSupportedException>(() => RegistryHelper.GetRegistryKey(CurrentUserEnvironment,
                                                                                                              RegistryHive.CurrentUser));
            }

            Assert.IsNotNull(RegistryHelper.GetRegistryKey(ClassesVisualStudio, RegistryHive.ClassesRoot));

            Assert.IsNotNull(RegistryHelper.GetRegistryKey(CurrentConfigFonts, RegistryHive.CurrentConfig));

            Assert.IsNotNull(RegistryHelper.GetRegistryKey(CurrentUserEnvironment, RegistryHive.CurrentUser));

            Assert.IsNotNull(RegistryHelper.GetRegistryKey(LocalMachineMicrosoft, RegistryHive.LocalMachine));

            //Assert.IsNotNull(RegistryHelper.GetRegistryKey(LocalMachineMicrosoft, RegistryKeyType.PerformanceData));

            Assert.IsNotNull(RegistryHelper.GetRegistryKey(UsersConsole, RegistryHive.Users));
        }
    }
}
