// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 11-28-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2018
// ***********************************************************************
// <copyright file="ConcurrentHashSet.cs" company="dotNetTips.com - David McCarter">
//     dotNetTips.com - David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using dotNetTips.Utility.Standard.Extensions;

namespace dotNetTips.Utility.Standard.Collections.Generic.Concurrent
{
    /// <summary>
    /// Thread safe distinct collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.ICollection{T}" />
    /// <seealso cref="dotNetTips.Utility.Standard.ICloneable{T}" />
    /// <seealso cref="System.IDisposable" />
    [DebuggerDisplay("Count = {Count}")]
    public class ConcurrentHashSet<T> : IDisposable, ICollection<T>, ICloneable<T>
    {
        /// <summary>
        /// The disposed
        /// </summary>
        protected bool disposed;

        /// <summary>
        /// The collection count
        /// </summary>
        private int _count;

        /// <summary>
        /// The hash set
        /// </summary>
        private readonly HashSet<T> _hashSet = new HashSet<T>();

        /// <summary>
        /// The lock
        /// </summary>
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
        /// </summary>
        public ConcurrentHashSet()
        {
            this._hashSet = new HashSet<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
        /// </summary>
        /// <param name="comparer">The comparer.</param>
        public ConcurrentHashSet(IEqualityComparer<T> comparer)
        {
            this._hashSet = new HashSet<T>(comparer);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        public ConcurrentHashSet(IEnumerable<T> collection)
        {
            this._hashSet = new HashSet<T>(collection);
            this._count += collection.Count();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentHashSet{T}" /> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="comparer">The comparer.</param>
        public ConcurrentHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            this._hashSet = new HashSet<T>(collection, comparer);
            this._count += collection.Count();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="ConcurrentHashSet{T}" /> class.
        /// </summary>
        ~ConcurrentHashSet()
        {
            Dispose(false);
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get
            {
                this._lock.EnterReadLock();

                try
                {
                    return this._count;
                }
                finally
                {
                    if (this._lock.IsReadLockHeld) this._lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"></see> is read-only.
        /// </summary>
        /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
        public bool IsReadOnly => ((ICollection<T>)this._hashSet).IsReadOnly;

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Add(T item)
        {
            this._lock.EnterWriteLock();

            try
            {
                var returnValue = this._hashSet.Add(item);
                this._count++;
                return returnValue;
            }
            finally
            {
                if (this._lock.IsWriteLockHeld)
                {
                    this._lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this._lock.EnterWriteLock();

            try
            {
                this._hashSet.Clear();
                this._count = 0;
            }
            finally
            {
                if (this._lock.IsWriteLockHeld)
                {
                    this._lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Cones this instance.
        /// </summary>
        /// <returns>T.</returns>
        public T Cone()
        {
            this._lock.EnterReadLock();

            try
            {
                return this.Clone<T>();
            }
            finally
            {
                if (this._lock.IsReadLockHeld)
                {
                    this._lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if [contains] [the specified item]; otherwise, <c>false</c>.</returns>
        public bool Contains(T item)
        {
            this._lock.EnterReadLock();

            try
            {
                return this._hashSet.Contains(item);
            }
            finally
            {
                if (this._lock.IsReadLockHeld)
                {
                    this._lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"></see> to an <see cref="T:System.Array"></see>, starting at a particular <see cref="T:System.Array"></see> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array"></see> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1"></see>. The <see cref="T:System.Array"></see> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            this._hashSet.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)this._hashSet).GetEnumerator();
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Remove(T item)
        {
            this._lock.EnterWriteLock();

            try
            {
                var returnValue = this._hashSet.Remove(item);
                this._count--;
                return returnValue;
            }
            finally
            {
                if (this._lock.IsWriteLockHeld)
                {
                    this._lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            lock (this)
            {
                if (this.disposed)
                {
                    return;
                }

                if (disposing)
                {
                    this.DisposeFields();
                }

                this.disposed = true;
            }
        }

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.</param>
        void ICollection<T>.Add(T item)
        {
            this.Add(item);
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator"></see> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)this._hashSet).GetEnumerator();
        }
    }
}
