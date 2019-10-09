// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 06-04-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-14-2019
// ***********************************************************************
// <copyright file="PersonCollection.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using dotNetTips.Utility.Standard.Tester.Models;
using System;
using System.Collections.Generic;

namespace dotNetTips.Utility.Standard.Tester.Collections
{

    /// <summary>
    /// Class PersonCollection.
    /// Implements the <see cref="System.Collections.Generic.List{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.List{T}" />
    [Serializable]
    // [CollectionDataContract(ItemName = "person", KeyName = "Id", Name = "people", Namespace = "http://dotnettips.com")]
    public class PersonCollection<T> : List<T> where T : IPerson, new()
    {

        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        public PersonCollection()
        {
        }
        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public PersonCollection(IEnumerable<T> collection) : base(collection)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public PersonCollection(int capacity) : base(capacity)
        {
        }

    }
}
