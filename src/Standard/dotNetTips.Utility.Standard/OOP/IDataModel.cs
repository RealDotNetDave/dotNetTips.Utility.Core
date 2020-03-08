// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-08-2020
// ***********************************************************************
// <copyright file="IDataModel.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace dotNetTips.Utility.Standard.OOP
{
    /// <summary>
    /// IDataModel Interface.
    /// Implements the <see cref="System.IComparable{TKey}" />
    /// Implements the <see cref="System.IEquatable{TKey}" />
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    /// <seealso cref="System.IComparable{TKey}" />
    /// <seealso cref="System.IEquatable{TKey}" />
    /// <remarks>For use with data models that require an Id (key).</remarks>
    public interface IDataModel<TKey> : IComparable<TKey>, IEquatable<TKey>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        TKey Id { get; set; }
    }
}
