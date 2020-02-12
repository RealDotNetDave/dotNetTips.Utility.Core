// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-05-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-05-2020
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
    /// IDataModel interface.
    /// Implements the <see cref="System.IComparable{T}" />
    /// Implements the <see cref="System.IEquatable{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.IComparable{T}" />
    /// <seealso cref="System.IEquatable{T}" />
    public interface IDataModel<T> : IComparable<T>, IEquatable<T> where T : new()
    {

    }
}
