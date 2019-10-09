// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 10-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2019
// ***********************************************************************
// <copyright file="ComputerInfo.cs" company="dotNetTips.com - McCarter Consulting">
//     dotNetTips.com - McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ComputerInfo.
    /// </summary>
    public class ComputerInfo
    {
        /// <summary>
        /// Gets the current managed tread identifier.
        /// </summary>
        /// <value>The current managed tread identifier.</value>
        public int CurrentManagedTreadId { get; } = Environment.CurrentManagedThreadId;

        /// <summary>
        /// Gets the current stack trace information.
        /// </summary>
        /// <value>The current stack trace.</value>
        public string CurrentStackTrace { get; } = Environment.StackTrace;

        /// <summary>
        /// Gets the current system tick count.
        /// </summary>
        /// <value>The current system tick count.</value>
        public int CurrentSystemTickCount { get; } = Environment.TickCount;
        /// <summary>
        /// Gets the current working directory.
        /// </summary>
        /// <value>The current directory.</value>
        public string CurrentWorkingDirectory { get; } = Environment.CurrentDirectory;

        /// <summary>
        /// Gets the framework description.
        /// </summary>
        /// <value>The framework description.</value>
        public string FrameworkDescription { get; } = RuntimeInformation.FrameworkDescription;

        /// <summary>
        /// Gets the framework version.
        /// </summary>
        /// <value>The framework version.</value>
        public Version FrameworkVersion { get; } = Environment.Version;

        /// <summary>
        /// Gets a value indicating whether this instance has shutdown started.
        /// </summary>
        /// <value><c>true</c> if this instance has shutdown started; otherwise, <c>false</c>.</value>
        public bool HasShutdownStarted { get; } = Environment.HasShutdownStarted;

        /// <summary>
        /// Gets the ip addresses.
        /// </summary>
        /// <value>The ip address.</value>
        public string IPAddress { get; } = Dns.GetHostAddresses(Dns.GetHostName()).Where(p => p.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList().ToDelimitedString(char.Parse(","));

        /// <summary>
        /// Gets a value indicating whether [is64 bit operating system].
        /// </summary>
        /// <value><c>true</c> if [is64 bit operating system]; otherwise, <c>false</c>.</value>
        public bool Is64BitOperatingSystem { get; } = Environment.Is64BitOperatingSystem;

        /// <summary>
        /// Gets a value indicating whether [is64 bit process].
        /// </summary>
        /// <value><c>true</c> if [is64 bit process]; otherwise, <c>false</c>.</value>
        public bool Is64BitProcess { get; } = Environment.Is64BitProcess;

        /// <summary>
        /// Gets a value indicating whether the user is interactive.
        /// </summary>
        /// <value><c>true</c> if this instance is user interactive; otherwise, <c>false</c>.</value>
        public bool IsUserInteractive { get; } = Environment.UserInteractive;

        /// <summary>
        /// Gets the logical drives.
        /// </summary>
        /// <value>The logical drives.</value>
        public ImmutableList<string> LogicalDrives { get; } = Environment.GetLogicalDrives().ToImmutable();

        /// <summary>
        /// Gets the name of the machine.
        /// </summary>
        /// <value>The name of the machine.</value>
        public string MachineName { get; } = Environment.MachineName;

        /// <summary>
        /// Gets the os architecture.
        /// </summary>
        /// <value>The os architecture.</value>
        public Architecture OSArchitecture { get; } = RuntimeInformation.OSArchitecture;

        /// <summary>
        /// Gets the os version.
        /// </summary>
        /// <value>The os version.</value>
        public string OSDescription { get; } = RuntimeInformation.OSDescription;


        /// <summary>
        /// Gets the size of the os memory page.
        /// </summary>
        /// <value>The size of the os memory page.</value>
        public int OsMemoryPageSize { get; } = Environment.SystemPageSize;

        /// <summary>
        /// Gets the physical memory in use.
        /// </summary>
        /// <value>The physical memory in use.</value>
        public long PhysicalMemoryInUse { get; } = Environment.WorkingSet;

        /// <summary>
        /// Gets the process architecture.
        /// </summary>
        /// <value>The process architecture.</value>
        public Architecture ProcessArchitecture { get; } = RuntimeInformation.ProcessArchitecture;

        /// <summary>
        /// Gets the processor count.
        /// </summary>
        /// <value>The processor count.</value>
        public int ProcessorCount { get; } = Environment.ProcessorCount;

        /// <summary>
        /// Gets the system directory.
        /// </summary>
        /// <value>The system directory.</value>
        public string SystemDirectory { get; } = Environment.SystemDirectory;

        /// <summary>
        /// Gets the name of the user domain.
        /// </summary>
        /// <value>The name of the user domain.</value>
        public string UserDomainName { get; } = Environment.UserDomainName;

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; } = Environment.UserName;
    }
}
