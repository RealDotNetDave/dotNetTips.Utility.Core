// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 05-04-2018
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="GlobalSuppressions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "CC0022:Should dispose object", Justification = "<Pending>", Scope = "member", Target = "~P:dotNetTips.Utility.Standard.AppLogging.LoggerFactory")]

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CC0033:Dispose Fields Properly", Justification = "<Pending>", Scope = "member", Target = "~F:dotNetTips.Utility.Standard.Cache.InMemoryCache._cache")]

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "DE0006:API is deprecated", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.App.GetEnvironmentVariables~System.Collections.Immutable.IImmutableDictionary{System.String,System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "PC001:API not supported on all platforms", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.DirectoryHelper.LoadOneDriveFolders~System.Collections.Generic.IEnumerable{dotNetTips.Utility.Standard.IO.OneDriveFolder}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "PC001:API not supported on all platforms", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.Win32.RegistryHelper.GetCurrentUserRegistryKey(System.String)~Microsoft.Win32.RegistryKey")]

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "CC0006:Use foreach", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.DirectoryHelper.CopyDirectory(System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0007:Use implicit type", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.DirectoryHelper.CopyDirectory(System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CC0004:Catch block cannot be empty", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.FileHelper.MoveFile(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CC0004:Catch block cannot be empty", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.FileHelper.MoveDirectory(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CC0004:Catch block cannot be empty", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.DirectoryHelper.MoveDirectory(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CC0004:Catch block cannot be empty", Justification = "<Pending>", Scope = "member", Target = "~M:dotNetTips.Utility.Standard.IO.DirectoryHelper.DeleteDirectory(System.String)")]