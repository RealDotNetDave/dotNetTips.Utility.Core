// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 05-28-2018
//
// Last Modified By : David McCarter
// Last Modified On : 07-05-2018
// ***********************************************************************
// <copyright file="DataEntity.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using dotNetTips.Utility.Standard.Validation;

namespace dotNetTips.Utility.Core.EntityFramework.Model
{
    /// <summary>
    /// Base Class for Data Entities.
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Core.EntityFramework.Model.IDataEntity" />
    public abstract class DataEntity : IDataEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntity" /> class.
        /// </summary>
        protected DataEntity()
        {
        }

        /// <summary>
        /// Determines whether [is entity valid].
        /// </summary>
        /// <returns><c>true</c> if [is entity valid]; otherwise, <c>false</c>.</returns>
        private IsValidResult IsEntityValid()
        {
            var returnValue = false;

            if (this.UpdatedAt.HasValue)
            {
                if (this.CreatedAt > this.UpdatedAt)
                {
                    returnValue = false;
                }
            }

            return new IsValidResult(returnValue);
        }

        /// <summary>
        /// Gets or sets the created at date.
        /// </summary>
        /// <value>The created at.</value>
        public DateTimeOffset CreatedAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:dotNetTips.Utility.Core.EntityFramework.Model.DataEntity" /> is deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        public bool Deleted
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id
        {
            get; set;
        }

        /// <summary>
        /// Checks to make sure entity is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public virtual IsValidResult IsValid => this.IsEntityValid();

        /// <summary>
        /// Gets or sets the public key.
        /// </summary>
        /// <value>The public key.</value>
        public Guid PublicKey
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>The updated at.</value>
        public DateTimeOffset? UpdatedAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        public byte[] Version
        {
            get; set;
        }
    }
}
