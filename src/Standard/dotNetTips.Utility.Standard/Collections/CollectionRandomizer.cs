// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2020
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Orginal code written by David McCarter & Kristine Tran</summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Collections
{
    /// <summary>
    /// Class CollectionRandomizer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>The CollectionRandomizer is designed to shuffle a collection and allow retrieving items by using GetNext().</remarks>
    [Information(nameof(CollectionRandomizer<T>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", modifiedOn: "8/27/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
    public sealed class CollectionRandomizer<T>
    {
        private ImmutableArray<T> _collection;
        private ImmutableArray<T>.Enumerator _collectionEnumerator;

        private bool _initialized;

        private readonly bool _repeat;
        private readonly object _threadLock = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionRandomizer{T}" /> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="repeat">If set to <c>true</c> and when using GetNext() the collection
        /// will repeat over and over and each time re-shuffled. Becareful of getting into an
        /// endless loop, it could cause your app to crash.</param>
        /// <remarks>The collection cannot be changed after initialization.</remarks>
        public CollectionRandomizer(IEnumerable<T> collection, bool repeat = false)
        {
            this._collection = collection.ToImmutableArray();
            this._repeat = repeat;
        }

        private void Init()
        {
            //Ignore if initalized unless repeat is true.
            if ((_initialized == true & HasRemainingItems) || (_initialized == true & HasRemainingItems == true & _repeat == false))
            {
                return;
            }

            //Validate Collection
            if (_collection.HasItems() == false)
            {
                throw new NullReferenceException("Underlying collection is null.");
            }

            //Shuffle Collection
            this._collection = this._collection.Shuffle();

            //Setup enumerator
            _collectionEnumerator = this._collection.GetEnumerator();

            //Move to first item
            this.HasRemainingItems = this._collectionEnumerator.MoveNext();

            this._initialized = true;

        }

        /// <summary>
        /// Gets the next item in the collection.
        /// </summary>
        /// <returns>T.</returns>
        public T GetNext()
        {
            lock (_threadLock)
            {
                this.Init();

                var collectionItem = this._collectionEnumerator.Current;

                this.HasRemainingItems = this._collectionEnumerator.MoveNext();

                return collectionItem;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has remaining items.
        /// </summary>
        /// <value><c>true</c> if this instance has remaining items; otherwise, <c>false</c>.
        /// This value will be <c>false</c> until the first time GetNext() is called and the shuffle is initalized.</value>
        public bool HasRemainingItems { get; private set; }

    }
}
