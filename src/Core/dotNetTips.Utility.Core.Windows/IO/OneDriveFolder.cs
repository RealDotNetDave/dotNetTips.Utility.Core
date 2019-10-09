// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-15-2018
//
// Last Modified By : David McCarter
// Last Modified On : 09-25-2019
// ***********************************************************************
// <copyright file="OneDriveFolder.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Core.Windows.IO
{
    /// <summary>
    /// Class OneDriveFolder.
    /// </summary>
    public class OneDriveFolder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneDriveFolder" /> class.
        /// </summary>
        public OneDriveFolder()
        {
            this.InitializeFields();
        }

        /// <summary>
        /// Gets the directory information.
        /// </summary>
        /// <value>The directory information.</value>
        public System.IO.DirectoryInfo DirectoryInfo { get; internal set; }

        /// <summary>
        /// Gets the type of the account.
        /// </summary>
        /// <value>The type of the account.</value>
        public OneDriveAccountType AccountType { get; internal set; } = OneDriveAccountType.Personal;

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        public string AccountName { get; internal set; }

        /// <summary>
        /// Gets the account email.
        /// </summary>
        /// <value>The account email.</value>
        public string UserEmail { get; internal set; }
    }
}
