// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 11-03-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-04-2020
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="David McCarter -  dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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
        /// Logs the application information.
        /// </summary>
        /// <param name="logger">The ILogger.</param>
        [Information(nameof(LogApplicationInformation), author: "David McCarter", createdOn: "11/03/2020", modifiedOn: "1/03/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static void LogApplicationInformation(ILogger logger)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(logger.IsNotNull(), nameof(logger));

            var appInfo = App.AppInfo;

            var values = TypeHelper.GetPropertyValues<AppInfo>(appInfo);

            if (values.HasItems())
            {
                foreach (var item in values)
                {
                    logger.LogDebug($"{nameof(AppInfo)}:{item.Key} - {item.Value}");
                }
            }
        }

        /// <summary>
        /// Logs the application information.
        /// </summary>
        /// <param name="logger">The ILogger.</param>
        [Information(nameof(LogComputerInformation), author: "David McCarter", createdOn: "11/04/2020", modifiedOn: "1/04/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public static void LogComputerInformation(ILogger logger)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(logger.IsNotNull(), nameof(logger));

            var computerInfo = new ComputerInfo();

            var values = TypeHelper.GetPropertyValues<ComputerInfo>(computerInfo);

            if (values.HasItems())
            {
                foreach (var item in values)
                {
                    logger.LogDebug($"{nameof(ComputerInfo)}:{item.Key} - {item.Value}");
                }
            }
        }
    }
}
