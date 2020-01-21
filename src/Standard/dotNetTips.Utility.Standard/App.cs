// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2019
// ***********************************************************************
// <copyright file="App.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ApplicationHelper.
    /// </summary>
    public static class App
    {

        /// <summary>
        /// The temporary ASP files location
        /// </summary>
        private const string _tempAspFiles = "\\Temporary ASP.NET Files\\";

        /// <summary>
        /// The application information
        /// </summary>
        private static AppInfo _appInfo;

        /// <summary>
        /// Gets the assembly information.
        /// </summary>
        /// <value>The assembly information.</value>
        public static AppInfo AppInfo => Info();

        /// <summary>
        /// Gets the culture.
        /// </summary>
        /// <value>The culture.</value>
        public static CultureInfo CurrentCulture => CultureInfo.CurrentCulture;

        /// <summary>
        /// Gets the UI culture.
        /// </summary>
        /// <value>The UI culture.</value>
        public static CultureInfo CurrentUICulture => CultureInfo.CurrentUICulture;

        /// <summary>
        /// Returns a string that indicates the name of the .NET installation on which an app is running.
        /// </summary>
        /// <value>The framework description.</value>
        public static string FrameworkDescription => RuntimeInformation.FrameworkDescription;

        /// <summary>
        /// Gets the installed UI culture.
        /// </summary>
        /// <value>The installed UI culture.</value>
        public static CultureInfo InstalledUICulture => CultureInfo.InstalledUICulture;

        /// <summary>
        /// Gets the platform architecture on which the current app is running.
        /// </summary>
        /// <value>The operating system platform.</value>
        public static Architecture OSArchitecture => RuntimeInformation.OSArchitecture;

        /// <summary>
        /// Gets a string that describes the operating system on which the app is running.
        /// </summary>
        /// <value>The operating system description.</value>
        public static string OSDescription => RuntimeInformation.OSDescription;

        /// <summary>
        /// Gets the process architecture of the currently running app.
        /// </summary>
        /// <value>The process architecture.</value>
        public static Architecture ProcessArchitecture => RuntimeInformation.ProcessArchitecture;

        /// <summary>
        /// Gets the stack trace.
        /// </summary>
        /// <value>The stack trace.</value>
        public static string StackTrace => Environment.StackTrace;

        /// <summary>
        /// Gets the working set.
        /// </summary>
        /// <value>The working set.</value>
        public static long WorkingSet => Environment.WorkingSet;

        /// <summary>
        /// Changes the culture.
        /// </summary>
        /// <param name="cultureName">Name of the culture.</param>
        public static void ChangeCulture(string cultureName)
        {
            CultureInfo.CurrentCulture = new CultureInfo(cultureName);
        }

        /// <summary>
        /// Changes the UI culture.
        /// </summary>
        /// <param name="cultureName">Name of the culture.</param>
        public static void ChangeUICulture(string cultureName)
        {
            CultureInfo.CurrentUICulture = new CultureInfo(cultureName);
        }

        /// <summary>
        /// Returns the folder path for the entry assembly.
        /// </summary>
        /// <returns>System.String.</returns>
        public static string ExecutingFolder()
        {
            return new FileInfo(Assembly.GetEntryAssembly().Location).Directory.ToString();
        }

        /// <summary>
        /// Gets the environment variables.
        /// </summary>
        /// <returns>IImmutableDictionary&lt;System.String, System.String&gt;.</returns>
        public static IImmutableDictionary<string, string> GetEnvironmentVariables()
        {
            var variables = Environment.GetEnvironmentVariables();

            var builder = ImmutableDictionary.CreateBuilder<string, string>();

            foreach (DictionaryEntry variable in variables)
            {
                builder.Add(variable.Key.ToString(), variable.Value.ToString());
            }

            return builder.ToImmutable();
        }

        /// <summary>
        /// Determines whether [is application already running] [the specified process name].
        /// </summary>
        /// <param name="processName">Name of the process.</param>
        /// <returns><c>true</c> if [is application already running] [the specified process name]; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">processName - Process name is required.</exception>
        public static bool IsProcessRunning(string processName)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(string.IsNullOrEmpty(processName) == false, "Process name is required.");

            return Process.GetProcessesByName(processName).HasItems();
        }

        /// <summary>
        /// Check to see if the current app is already running.
        /// </summary>
        /// <returns><c>true</c> if app is not running, <c>false</c> otherwise.</returns>
        public static bool IsRunning() => Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).HasItems();

        /// <summary>
        /// Checks to see if the current application is ASP.NET
        /// </summary>
        /// <returns>True if running ASP.NET</returns>
        public static bool IsRunningFromAspNet() => !string.IsNullOrEmpty(AppDomain.CurrentDomain.DynamicDirectory)
            ? AppDomain.CurrentDomain.DynamicDirectory.Contains(_tempAspFiles, StringComparison.InvariantCultureIgnoreCase)
            : false;

        /// <summary>
        /// Kills the current process.
        /// </summary>
        public static void Kill() => KillProcess(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location));

        /// <summary>
        /// Kills the process.
        /// </summary>
        /// <param name="processName">Name of the process.</param>
        /// <exception cref="ArgumentNullException">processName - Process name is nothing or empty.</exception>
        public static void KillProcess(string processName)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(string.IsNullOrEmpty(processName), "Process name is required.");

            var app = Process.GetProcessesByName(processName).FirstOrDefault();

            if (app != null)
            {
                app.Kill();
                app.WaitForExit(6000);
            }
        }

        /// <summary>
        /// Loads a list of the running assembly referenced assemblies.
        /// </summary>
        /// <returns>IEnumerable(Of System.String).</returns>
        public static ImmutableList<string> ReferencedAssemblies()
        {
            var referencedAssemblies = new List<string>();

            for (int assemblyCount = 0; assemblyCount < Assembly.GetEntryAssembly().GetReferencedAssemblies().Length; assemblyCount++)
            {
                referencedAssemblies.Add(Assembly.GetEntryAssembly().GetReferencedAssemblies()[assemblyCount].ToString());
            }

            return referencedAssemblies.ToImmutable();
        }

        /// <summary>
        /// Restarts an app as administrator.
        /// </summary>
        public static void RunAsAdministrator()
        {
            var processInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase)
            {
                UseShellExecute = true,
            };

            Process.Start(processInfo);

            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// App information.
        /// </summary>
        /// <returns>Returns <seealso cref="AppInfo" /></returns>
        private static AppInfo Info()
        {
            if (_appInfo == null)
            {
                _appInfo = new AppInfo();

                var assembly = Assembly.GetEntryAssembly();

                _appInfo.Company = assembly.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company;

                _appInfo.Configuration = assembly.GetCustomAttributes<AssemblyConfigurationAttribute>().FirstOrDefault()?.Configuration;

                _appInfo.Copyright = assembly.GetCustomAttributes<AssemblyCopyrightAttribute>().FirstOrDefault()?.Copyright;

                _appInfo.Description = assembly.GetCustomAttributes<AssemblyDescriptionAttribute>().FirstOrDefault()?.Description;

                _appInfo.FileVersion = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>().FirstOrDefault()?.Version;

                _appInfo.Version = assembly.GetCustomAttributes<AssemblyInformationalVersionAttribute>().FirstOrDefault()?.InformationalVersion;

                _appInfo.Product = assembly.GetCustomAttributes<AssemblyProductAttribute>().FirstOrDefault()?.Product;

                _appInfo.Title = assembly.GetCustomAttributes<AssemblyTitleAttribute>().FirstOrDefault()?.Title;
            }

            return _appInfo;
        }

    }
}
