// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-04-2019
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using dotNetTips.Utility.Core.Windows.Win32;
using dotNetTips.Utility.Standard.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Runtime.InteropServices;

namespace dotNetTips.Utility.Core.Windows.IO
{
    /// <summary>
    /// Class DirectoryHelper.
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Loads the one drive folders.
        /// </summary>
        /// <returns>IEnumerable&lt;OneDriveFolder&gt;.</returns>
        /// <exception cref="PlatformNotSupportedException">The method only supports Windows.</exception>
        public static ImmutableArray<OneDriveFolder> LoadOneDriveFolders()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
            {
                throw new PlatformNotSupportedException();
            }

            const string DisplayNameKey = "DisplayName";
            const string UserFolderKey = "UserFolder";
            const string AccountsKey = "Accounts";
            const string EmailKey = "UserEmail";

            var folders = new List<OneDriveFolder>();

            var oneDriveKey = RegistryHelper.GetCurrentUserRegistryKey(RegistryHelper.KeyCurrentUserOneDrive);

            if (oneDriveKey.IsNotNull())
            {
                // Get Accounts
                var accountKey = oneDriveKey.GetSubKey(AccountsKey);

                if (accountKey.IsNotNull() && accountKey.SubKeyCount > 0)
                {
                    for (var subKeyCount = 0; subKeyCount < accountKey.GetSubKeyNames().Length; subKeyCount++)
                    {
                        var key = accountKey.GetSubKey(accountKey.GetSubKeyNames()[subKeyCount]);

                        var folder = new OneDriveFolder();
                        var directoryValue = key.GetValue<string>(UserFolderKey);

                        if (directoryValue.HasValue())
                        {
                            folder.DirectoryInfo = new DirectoryInfo(directoryValue);

                            var emailValue = key.GetValue<string>(EmailKey);

                            if (emailValue.IsNotNull())
                            {
                                folder.UserEmail = emailValue;
                            }

                            // Figure out account type                           
                            var name = key.GetValue<string>(DisplayNameKey);

                            if (name.HasValue())
                            {
                                folder.AccountType = OneDriveAccountType.Business;
                                folder.AccountName = name;
                            }
                            else
                            {
                                folder.AccountName = key.GetValue<string>(string.Empty);
                            }

                            if (folder.AccountName.HasValue() && folder.DirectoryInfo.IsNotNull())
                            {
                                folders.Add(folder);
                            }
                        }
                    }
                }
            }

            return folders.ToImmutableArray();
        }
    }
}