// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 11-03-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2020
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="David McCarter -  dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using Microsoft.Extensions.Logging;

namespace dotNetTips.Utility.Standard.Logging
{
    /// <summary>
    /// Class LoggingHelper.
    /// </summary>
    [Information("Logging helper methods.", "David McCarter", "11/3/2020")]
    public static class LoggingHelper
    {
        /// <summary>
        /// Logs application information.
        /// </summary>
        /// <param name="logger">The ILogger.</param>
        /// <example>Output:
        /// AppInfo:Company - Microsoft Corporation
        /// AppInfo:Version - 16.8.0
        /// AppInfo:Copyright - © Microsoft Corporation.All rights reserved.
        /// AppInfo:Product - dotNetTips.Spargine
        /// AppInfo:FileVersion - 15.0.0
        /// AppInfo:Title - dotNetTips.Spargine.
        /// </example>
        /// <exception cref="ArgumentNullException">Logger cannot be null. </exception>
        [Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", modifiedOn: "1/03/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static void LogApplicationInformation(ILogger logger)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(logger.IsNotNull(), nameof(logger));

            var appInfo = App.AppInfo;

            var values = TypeHelper.GetPropertyValues<AppInfo>(appInfo);

            if (values.HasItems())
            {
                foreach (var item in values.OrderBy(p => p.Key))
                {
                    logger.LogDebug($"{nameof(AppInfo)}:{item.Key} - {item.Value}");
                }
            }
        }

        /// <summary>
        /// Logs computer information.
        /// </summary>
        /// <param name="logger">The ILogger.</param>
        /// <example>OUTPUT:
        /// AppInfo:Is64BitProcess - True
        /// AppInfo:ProcessArchitecture - X64
        /// AppInfo:CurrentStackTrace - at System.Environment.get_StackTrace()\r\n at dotNetTips.Utility.Standard.ComputerInfo..ctor() in...
        /// AppInfo:ComputerCulture - eng
        /// AppInfo:UserName - david
        /// AppInfo:IsUserInteractive - True
        /// AppInfo:OsMemoryPageSize - 4096
        /// AppInfo:FrameworkVersion - 3.1.10
        /// AppInfo:IPAddress - 192.168.0.7
        /// AppInfo:Is64BitOperatingSystem - True
        /// AppInfo:CurrentSystemTickCount - 185990421
        /// AppInfo:ComputerUICulture - eng
        /// AppInfo:ProcessorCount - 4
        /// AppInfo:FrameworkDescription - .NET Core 3.1.10
        /// AppInfo:PhysicalMemoryInUse - 49123328
        /// AppInfo:OSArchitecture - X64
        /// AppInfo:CurrentManagedTreadId - 6
        /// AppInfo:CurrentWorkingDirectory - C:\\src\\GitHub\\dotNetTips.Utility.Core\\src\\Unit Tests\\dotNetTips.Utility.Standard.Tests\\bin\\Debug\\netcoreapp3.1
        /// AppInfo:MachineName - DOTNETTIPS
        /// AppInfo:OSDescription - Microsoft Windows 10.0.19042
        /// AppInfo:UserDomainName - DOTNETTIPS
        /// AppInfo:SystemDirectory - C:\\WINDOWS\\system32
        /// AppInfo:HasShutdownStarted - False.
        /// </example>
        /// <exception cref="ArgumentNullException">Logger cannot be null. </exception>
        [Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", modifiedOn: "1/04/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static void LogComputerInformation(ILogger logger)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(logger.IsNotNull(), nameof(logger));

            var computerInfo = new ComputerInfo();

            var values = TypeHelper.GetPropertyValues<ComputerInfo>(computerInfo);

            if (values.HasItems())
            {
                foreach (var item in values.OrderBy(p => p.Key))
                {
                    logger.LogDebug($"{nameof(ComputerInfo)}:{item.Key} - {item.Value}");
                }
            }
        }
    }
}
