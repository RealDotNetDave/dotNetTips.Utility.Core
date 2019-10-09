// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2019
// ***********************************************************************
// <copyright file="FastSortedList.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Collections.Generic
{
    /// <summary>
    /// Class SortedList.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="dotNetTips.Utility.Standard.ICloneable{T}" />
    /// <seealso cref="System.Collections.Generic.List{T}" />
    [DebuggerDisplay("Count = {Count}"), Serializable]
    public class FastSortedList<T> : List<T>, ICloneable<T>
    {
        /// <summary>
        /// True or False if the list has been sorted.
        /// </summary>
        private bool _sorted;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortedList{TKey, TValue}" /> class.
        /// </summary>
        public FastSortedList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FastSortedList{T}"/> class.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        /// TODO Edit XML Comment Template for #ctor
        public FastSortedList(IEnumerable<T> collection) : base(collection)
        {
        }

        /// <summary>
        /// Adds an object to the end of the <see cref="T:System.Collections.Generic.List`1"></see>.
        /// </summary>
        /// <param name="item">The object to be added to the end of the <see cref="T:System.Collections.Generic.List`1"></see>. The value can be null for reference types.</param>
        /// TODO Edit XML Comment Template for Add
        public new void Add(T item)
        {
            base.Add(item);

            this._sorted = false;
        }

        /// <summary>
        /// Adds the range.
        /// </summary>
        /// <param name="items">The items.</param>
        /// TODO Edit XML Comment Template for AddRange
        public new void AddRange(IEnumerable<T> items)
        {
            base.AddRange(items);

            this._sorted = false;
        }

        /// <summary>
        /// Cones this instance.
        /// </summary>
        /// <returns>T.</returns>
        /// TODO Edit XML Comment Template for Cone
        public T Cone() => this.Clone<T>();

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.List`1"></see>.
        /// </summary>
        /// <returns>A <see cref="T:System.Collections.Generic.List`1.Enumerator"></see> for the <see cref="T:System.Collections.Generic.List`1"></see>.</returns>
        /// TODO Edit XML Comment Template for GetEnumerator
        public new Enumerator GetEnumerator()
        {
            this.SortCollection();
            return base.GetEnumerator();
        }


        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.List`1"></see> to a new array.
        /// </summary>
        /// <returns>An array containing copies of the elements of the <see cref="T:System.Collections.Generic.List`1"></see>.</returns>
        /// TODO Edit XML Comment Template for ToArray
        public new T[] ToArray()
        {
            this.SortCollection();
            return base.ToArray();
        }

        /// <summary>
        /// To the immutable list.
        /// </summary>
        /// <returns>System.Collections.Immutable.IImmutableList&lt;T&gt;.</returns>
        public IImmutableList<T> ToImmutableList()
        {
            this.SortCollection();
            return this.ToImmutable();
        }

        /// <summary>
        /// To the list.
        /// </summary>
        /// <returns>List&lt;T&gt;.</returns>
        public List<T> ToList()
        {
            this.SortCollection();
            return new List<T>(base.ToArray());
        }

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        /// TODO Edit XML Comment Template for SortCollection
        private void SortCollection()
        {
            if (this._sorted == false)
            {
                base.Sort();
                this._sorted = true;
            }
        }
    }
}
