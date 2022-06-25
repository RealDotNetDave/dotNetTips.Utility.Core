// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 08-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-04-2020
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Original code written by David McCarter & Kristine Tran</summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Collections
{
	/// <summary>
	/// Class CollectionRandomizer.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <remarks>The CollectionRandomizer is designed to shuffle a collection and allow retrieving items by using GetNext().</remarks>
	[Information(nameof(CollectionRandomizer<T>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", modifiedOn: "8/27/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public sealed class CollectionRandomizer<T> : IEnumerator<T>, IEnumerable<T>
	{
		/// <summary>
		/// The repeat.
		/// </summary>
		private int _repeat;

		/// <summary>
		/// The thread lock.
		/// </summary>
		private readonly object _threadLock = new object();

		/// <summary>
		/// The collection.
		/// </summary>
		private ImmutableArray<T> _collection;

		/// <summary>
		/// The collection enumerator.
		/// </summary>
		private ImmutableArray<T>.Enumerator _collectionEnumerator;

		/// <summary>
		/// The initialized.
		/// </summary>
		private bool _initialized;

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionRandomizer{T}" /> class.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="repeat">set to <c>true</c> and when using GetNext() the collection will repeat over and over and each time re-
		/// shuffled. Be careful of getting into an endless loop, it could cause your app to crash.</param>
		/// <remarks>The collection cannot be changed after initialization.</remarks>
		/// <exception cref="ArgumentInvalidException">Underlying collection is null.</exception>
		public CollectionRandomizer(IEnumerable<T> collection, bool repeat) : this(collection, repeat ? -1 : 1)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionRandomizer{T}" /> class.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="repeatCount">set to the number of times to repeat and when using MoveNext() the collection will repeat over and over and each time re-
		/// shuffled. Defaults to 1. use -1 to repeat forever. Be careful of getting into an endless loop, it could cause your app to crash.</param>
		/// <remarks>The collection cannot be changed after initialization.</remarks>
		/// <exception cref="ArgumentInvalidException">Underlying collection is null.</exception>
		public CollectionRandomizer(IEnumerable<T> collection, int repeatCount = 1)
		{
			this._collection = collection.ToImmutableArray();
			this._repeat = repeatCount;
			
			// Validate Collection
			if (this._collection.HasItems() == false)
			{
				throw new ArgumentInvalidException("Underlying collection is null.");
			}
		}


		/// <summary>
		/// Gets a value indicating whether this instance has remaining items.
		/// </summary>
		/// <value><c>true</c> if this instance has remaining items; otherwise, <c>false</c>. This value will be <c>false</c>
		/// until the first time GetNext() is called and the shuffle is initialized.</value>
		public bool HasRemainingItems { get; private set; }

		/// <inheritdoc/>
		public T Current => this._collectionEnumerator.Current;


		/// <inheritdoc/>
		object? IEnumerator.Current => this.Current;

		/// <inheritdoc/>
		public void Dispose()
		{
		}

		/// <summary>
		/// Gets the next item in the collection.
		/// </summary>
		/// <returns>T.</returns>
		public bool MoveNext()
		{
				this.HasRemainingItems = this._initialized && this._collectionEnumerator.MoveNext();
				if (!this.HasRemainingItems && this._repeat !=0)
					this.Reset();
				return this.HasRemainingItems || this._repeat !=0;
		}

		/// <inheritdoc/>
		public void Reset()
		{
			lock (this._threadLock)
			{
				// Shuffle Collection
				this._collection = this._collection.Shuffle();

				// Setup enumerator
				this._collectionEnumerator = this._collection.GetEnumerator();
				this._initialized = true;
				--this._repeat;
				this.HasRemainingItems = this._collectionEnumerator.MoveNext();
			}
		}

		public IEnumerator<T> GetEnumerator() => this;
		IEnumerator IEnumerable.GetEnumerator() => this;
	}
}
