// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 09-16-2017
// ***********************************************************************
// <copyright file="IDataEntity.cs" company="dotNetTips.com - David McCarter">
//      McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using dotNetTips.Utility.Standard;

namespace dotNetTips.Utility.Core.EntityFramework.Model
{
    /// <summary>
    /// Interface IDataEntity
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.IValid" />
    public interface IDataEntity : IValid
    {
        /// <summary>
        /// Gets or sets the created at date.
        /// </summary>
        /// <value>The created at.</value>
        DateTimeOffset CreatedAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DataEntity" /> is deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        bool Deleted
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        /// <value>The public key.</value>
        Guid PublicKey
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        DateTimeOffset? UpdatedAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        byte[] Version
        {
            get; set;
        }
    }
}
