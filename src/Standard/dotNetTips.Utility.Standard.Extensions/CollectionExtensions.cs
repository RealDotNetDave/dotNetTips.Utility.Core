// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 09-21-2020
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Extension methods for a collection.
    /// </summary>
    public static class CollectionExtensions
    {
        [ThreadStatic]
        private static Random _random;
        private static Random globalRandom = new Random();

        /// <summary>
        /// Processes the collection to dispose.
        /// </summary>
        /// <param name="items">The items.</param>
        private static void ProcessCollectionToDispose(IEnumerable items)
        {
            if (items.HasItems())
            {
                foreach (var item in items)
                {
                    if (item != null && item is IDisposable disposeItem)
                    {
                        disposeItem.TryDispose();
                    }
                }
            }
        }

        private static Random random
        {
            get
            {
                if (_random == null)
                {
                    int seed;

                    lock (globalRandom)
                    {
                        seed = globalRandom.Next();
                    }

                    _random = new Random(seed);
                }

                return _random;
            }
        }

        /// <summary>
        /// Disposes the collection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="items">The items.</param>
        internal static void DisposeCollection<T>(this IEnumerable<T> items) => ProcessCollectionToDispose(items);

        /// <summary>
        /// Tries to dispose collection items.
        /// </summary>
        /// <param name="items">The items.</param>
        internal static void DisposeCollection(this IEnumerable items) => ProcessCollectionToDispose(items);

        /// <summary>
        /// Adds the item as the first item in array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">list or item</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 76.92, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool AddFirst<T>(this IList<T> list, T item)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (item == null)
            {
                return false;
            }

            list.Insert(0, item);

            return true;
        }

        /// <summary>
        /// Adds the first.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">array or item</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 76.92, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static T[] AddFirst<T>(this T[] array, T item)
        {
            if (array.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(array));
            }

            if (array.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(array));
            }

            if (item == null)
            {
                return array;
            }

            var result = new T[array.Length + 1];
            result[0] = item;

            array.CopyTo(result, index: 1);

            return result;
        }

        /// <summary>
        /// Adds if not exists.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">list - List cannot be null. or value - Value cannot be null.</exception>
        /// <exception cref="ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">list - List cannot be read-only.</exception>
        /// <exception cref="System.ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
        public static bool AddIfNotExists<T>(this ICollection<T> list, T item)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (item == null || list.Contains(item))
            {
                return false;
            }

            list.Add(item);
            return true;
        }

        /// <summary>
        /// Adds items to an array if they do not exists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The items.</param>
        /// <returns>T[].</returns>
        [Information(nameof(AddIfNotExists), author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "8/12/2020", UnitTestCoverage = 82.61, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static T[] AddIfNotExists<T>(this T[] list, params T[] items)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (items.HasItems() == false)
            {
                return list;
            }

            var returnCollection = list.ToList();

            for (int itemCount = 0; itemCount < items.Count(); itemCount++)
            {
                var item = items[itemCount];

                if (list.Contains(item) == false)
                {
                    returnCollection.Add(item);
                }
            }

            return returnCollection.ToArray();
        }

        /// <summary>
        /// Adds and item if does not exists.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The values.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">list - List cannot be read-only.</exception>
        /// <exception cref="ArgumentNullException">list - List cannot be read-only.</exception>
        public static bool AddIfNotExists<T>(this ICollection<T> list, params T[] items)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (items.DoesNotHaveItems())
            {
                return false;
            }

            var returnValue = false;

            if (items.HasItems())
            {
                for (int index = 0; index < items.Length; index++)
                {
                    if (items[index].IsNotNull())
                    {
                        list.AddIfNotExists(items[index]);
                        returnValue = true;
                    }
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Adds item if it does not exists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">List cannot be read-only. - list</exception>
        /// <exception cref="ArgumentNullException">List cannot be read-only. - list</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 31.58, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool AddIfNotExists<T>(this ICollection<T> list, T item, IEqualityComparer<T> comparer)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (comparer == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(comparer));
            }

            if (item == null)
            {
                return false;
            }

            if (list.Contains(item, comparer))
            {
                return false;
            }
            else
            {
                list.Add(item);
                return true;
            }
        }

        /// <summary>
        /// Tries the add the item if it does not exist.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">key or value</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 77.27, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool AddIfNotExists<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(dictionary));
            }

            if (dictionary.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(dictionary));
            }

            if (key.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(key));
            }

            if (value.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(value));
            }

            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Adds item the last item in the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">list or item</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 57.14, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool AddLast<T>(this IList<T> list, T item)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (item == null)
            {
                return false;
            }

            list.Insert(list.Count, item);

            return true;
        }

        /// <summary>
        /// Adds the last.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">item - Item cannot be null.</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static T[] AddLast<T>(this T[] array, T item)
        {
            if (array.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(array));
            }

            if (array.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(array));
            }

            if (item == null)
            {
                return array;
            }

            var result = new T[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;

            return result;
        }

        /// <summary>
        /// Adds the items to the collection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The new items.</param>
        /// <param name="insureUnique">Set to true if items added to list are unique.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">items</exception>
        /// <exception cref="ArgumentNullException">items</exception>
        public static bool AddRange<T>(this ICollection<T> list, IEnumerable<T> items, bool insureUnique = false)
        {
            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (items.HasItems() == false)
            {
                return false;
            }

            var returnValue = false;

            if (items.HasItems())
            {
                items.ToList()
                    .ForEach(item =>
                    {
                        if (insureUnique)
                        {
                            list.AddIfNotExists(item);
                            returnValue = true;
                        }
                        else
                        {
                            list.Add(item);
                            returnValue = true;
                        }
                    });
            }

            return returnValue;
        }

        /// <summary>
        /// Adds the range.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The items.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">list - Dictionary cannot be null. or key - Key cannot be null.</exception>
        /// <exception cref="ArgumentException">list - Dictionary cannot be null. or key - Key cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">list - Dictionary cannot be null. or key - Key cannot be null.</exception>
        /// <remarks>Code by: Lucas</remarks>
        public static bool AddRange<T, TKey, TValue>(this IDictionary<TKey, TValue> list, IEnumerable<T> items, Func<T, TKey> key, Func<T, TValue> value)
        {
            if (items.DoesNotHaveItems())
            {
                return false;
            }

            if (list.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
            }

            if (key is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(key));
            }

            if (value is null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(value));
            }

            var returnValue = false;

            if (items.HasItems())
            {
                items.ToList().ForEach(item =>
                    {
                        list.Add(key(item), value(item));
                        returnValue = true;
                    });
            }

            return returnValue;
        }


        /// <summary>
        /// Ares the equal.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The input.</param>
        /// <param name="arrayToCheck">The array to check.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 52.94, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static bool AreEqual<T>(this T[] input, T[] arrayToCheck)
        {
            if (input == null && arrayToCheck == null)
            {
                return true;
            }

            if (input == null || arrayToCheck == null || input.Length != arrayToCheck.Length)
            {
                return false;
            }

            var areSame = true;

            for (var i = 0; i < input.Length; i++)
            {
                areSame &= (input[i].Equals(arrayToCheck[i]));
            }

            return areSame;
        }

        /// <summary>
        /// Ares the equal.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The input.</param>
        /// <param name="listToCheck">The list to check.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 90.91, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static bool AreEqual<T>(this IList<T> input, IList<T> listToCheck)
        {
            if (input == null && listToCheck == null)
            {
                return true;
            }

            if (input == null || listToCheck == null || input.Count != listToCheck.Count)
            {
                return false;
            }

            var areSame = true;

            for (var i = 0; i < input.Count; i++)
            {
                areSame &= (input[i].Equals(listToCheck[i]));
            }

            return areSame;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public static string BytesToString(this byte[] bytes)
        {
            var builder = new StringBuilder();

            for (var byteCount = 0; byteCount < bytes.Length; byteCount++)
            {
                builder.Append(bytes[byteCount].ToString("x2", CultureInfo.InvariantCulture));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Clears the null items from the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information(nameof(AddIfNotExists), author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "8/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool ClearNulls<T>(this List<T> source)
        {
            if (source.HasItems() == false)
            {
                return false;
            }
            else
            {
                return source.RemoveAll(p => p.IsNull()) > 0;
            }
        }

        /// <summary>
        /// Clones the specified array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>T[].</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 66.67, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static T[] Clone<T>(this T[] input)
        {
            if (input == null || input.Length == 0)
            {
                ExceptionThrower.ThrowArgumentNullException("Input cannot be null or has a length of 0.", nameof(input));
            }

            var copy = new T[input.Length];
            Array.Copy(sourceArray: input,
                       sourceIndex: 0,
                       destinationArray: copy,
                       destinationIndex: 0,
                       length: input.Length);

            return copy;
        }

        /// <summary>
        /// Determines whether the specified collection has items specified.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="items">The items.</param>
        /// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 91.67, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool ContainsAny<T>(this IEnumerable<T> source, params T[] items)
        {
            if (items.HasItems() == false)
            {
                return false;
            }
            else
            {
                var itemsList = items.ToReadOnlyCollection();

                return itemsList.HasItems() ? source.ToList().Any(p => itemsList.Contains(p)) : false;
            }
        }

        /// <summary>
        /// Determines whether the specified collection has items specified.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="items">The items.</param>
        /// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 91.67, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static bool ContainsAny<T>(this T[] source, params T[] items)
        {
            if (items.HasItems() == false)
            {
                return false;
            }
            else
            {
                var itemsList = items.ToReadOnlyCollection();

                return itemsList.HasItems() ? source.ToReadOnlyCollection().Any(p => itemsList.Contains(p)) : false;
            }
        }

        /// <summary>
        /// Copies the collection to a generic List.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>List&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">source</exception>
        public static List<T> CopyToList<T>(this List<T> source)
        {
            if (source.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(source), $"{nameof(source)} is null.");
            }

            return new List<T>(source);
        }

        /// <summary>
        /// Counts the specified list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">list</exception>
        public static int Count(this IEnumerable list)
        {
            if (list is ICollection collection)
            {
                return collection.Count;
            }

            var count = 0;

            var enumerator = list.GetEnumerator();

            while (enumerator.MoveNext())
            {
                count++;
            }

            return count;
        }

        /// <summary>
        /// Disposes the collection.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="items">The items.</param>
        public static void DisposeCollection<TKey, TValue>(this IDictionary<TKey, TValue> items)
        { ProcessCollectionToDispose(items.Select(p => p.Value)); }

        /// <summary>
        /// Returns distinct collection using the specified comparer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">comparer</exception>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> source, Func<T, T, bool> comparer)
            where T : class
        {
            if (comparer == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(comparer));
            }

            return source.Distinct(new DynamicEqualityComparer<T>(comparer));
        }

        /// <summary>
        /// Determines whether the specified source does not have items or is null.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool DoesNotHaveItems(this IEnumerable source) => source?.Count() <= 0;


        /// <summary>
        /// Determines whether the specified source does not have items or is null.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool DoesNotHaveItems(this ICollection source) => source?.Count <= 0;

        /// <summary>
        /// Determines whether the specified source does not have items or is null.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool DoesNotHaveItems<T>(this ObservableCollection<T> source) => source?.Count <= 0;

        /// <summary>
        /// Fasts any.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>System.Boolean.</returns>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="System.ArgumentNullException">predicate</exception>
        public static bool FastAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate), $"{nameof(predicate)} is null.");
            }

            return source.FirstOrDefault(predicate) != null;
        }

        /// <summary>
        /// Counts the the collection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="System.ArgumentNullException">predicate</exception>
        /// <exception cref="Exception">predicate</exception>
        public static int FastCount<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            if (source is List<T>)
            {
                var count = 0;
                var list = (List<T>)source;

                for (var listCount = 0; listCount < list.Count; listCount++)
                {
                    if (predicate(list[listCount]))
                    {
                        count++;
                    }
                }

                return count;
            }
            else
            {
                return source.Count(predicate);
            }
        }

        /// <summary>
        /// Returns first item in the collection or an alternate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="alternate">The alternate.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static T FirstOrDefault<T>(this IEnumerable<T> source, T alternate)
        {
            return source.DefaultIfEmpty(alternate).First();
        }

        /// <summary>
        /// Returns first item in the collection or an alternate using a predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="alternate">The alternate.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate, T alternate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate), $"{nameof(predicate)} is null.");
            }

            if (alternate == null)
            {
                throw new ArgumentNullException(nameof(alternate), $"{nameof(alternate)} is null.");
            }

            return source.Where(predicate).FirstOrDefault(alternate);
        }

        /// <summary>
        /// Finds first item or returns null.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="match">The match.</param>
        /// <returns>System.Nullable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">match</exception>
        /// <exception cref="System.ArgumentNullException">match</exception>
        public static T? FirstOrNull<T>(this IEnumerable<T> list, Func<T, bool> match)
            where T : struct
        {
            if (list.HasItems() == false)
            {
                return null;
            }

            if (match is null)
            {
                throw new ArgumentNullException(nameof(match), $"{nameof(match)} is null.");
            }

            var listToProcess = list.ToList();

            for (int listCount = 0; listCount < listToProcess.Count; listCount++)
            {
                T local = listToProcess[listCount];

                if (match?.Invoke(local) ?? default)
                {
                    return new T?(local);
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a value or adds it to the Dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="ArgumentNullException">key</exception>
        /// <exception cref="ArgumentNullException">value</exception>
        /// <exception cref="ArgumentNullException">key</exception>
        /// <exception cref="ArgumentNullException">value</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (dictionary.TryGetValue(key, out TValue item) == false)
            {
                dictionary.Add(key, value);
                item = value;
            }

            return item;
        }

        /// <summary>
        /// Determines whether the specified source has items or is null.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems(this IEnumerable source) => source?.Count() > 0;

        /// <summary>
        /// Determines whether the specified source has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems(this ICollection source) => source?.Count > 0;


        /// <summary>
        /// Determines whether the specified source has items.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems<T>(this ObservableCollection<T> source) => source?.Count > 0;

        /// <summary>
        /// Determines whether the specified count has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The specific count.</param>
        /// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems(this IEnumerable source, int count) => source?.Count() == count;


        /// <summary>
        /// Determines whether the specified count has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The specific count.</param>
        /// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems(this ICollection source, int count) => source?.Count == count;

        /// <summary>
        /// Determines whether the specified count has items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The specific count.</param>
        /// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
        public static bool HasItems<T>(this ObservableCollection<T> source, int count) => source?.Count == count;

        /// <summary>
        /// Determines whether the specified collection has items based on the Predicate.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
        /// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">action</exception>
        /// <exception cref="System.ArgumentNullException">action</exception>
        public static bool HasItems<T>(this List<T> source, Predicate<T> action)
        {
            if (action is null)
            {
                throw new ArgumentNullException(nameof(action), $"{nameof(action)} is null.");
            }

            return source.TrueForAll(action);
        }

        /// <summary>
        /// Returns index of item in the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="item">The item.</param>
        /// <returns>System.Int32.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static int IndexOf<T>(this IEnumerable<T> source, T item)
        { return IndexOf(source, item, EqualityComparer<T>.Default); }

        /// <summary>
        /// Returns index of an item in the colleciton using comparer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="item">The item.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">item or comparer</exception>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static int IndexOf<T>(this IEnumerable<T> source, T item, IEqualityComparer<T> comparer)
        {
            if (item == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(item));
            }

            if (comparer == null)
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(comparer));
            }

            return source.Select((x, index) => comparer.Equals(item, x) ? index : -1).FirstOrDefault(x => x != -1, -1);
        }

        /// <summary>
        /// Joins a collection using the specified separator.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="separator">The separator.</param>
        /// <returns>System.String.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static string Join(this IEnumerable<object> source, string separator = ", ")
        { return string.Join(separator, source); }

        /// <summary>
        /// Generates hash code for the collection.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">The list to use to generate hash code.</param>
        /// <returns>Hash code as System.Int32.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static int ListHashCode<T>(this ReadOnlyCollection<T> list)
        {
            var comparer = EqualityComparer<T>.Default;

            int hash = list.Where(t => t != null)
                .Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ comparer.GetHashCode(t));

            return hash;
        }

        /// <summary>
        /// Generates hash code for the collection.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">The list to use to generate hash code.</param>
        /// <returns>Hash code as System.Int32.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static int ListHashCode<T>(this IList<T> list)
        {
            var comparer = EqualityComparer<T>.Default;

            int hash = list.Where(t => t != null)
                .Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ comparer.GetHashCode(t));

            return hash;
        }

        /// <summary>
        /// Generates hash code for the collection.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="list">The list to use to generate hash code.</param>
        /// <returns>Hash code as System.Int32.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static int ListHashCode<T>(this T[] list)
        {
            int hash = list.Where(t => t != null)
                .Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ EqualityComparer<T>.Default.GetHashCode(t));

            return hash;
        }

        /// <summary>
        /// Orders a list based on a sort expression. Useful in object binding scenarios where the ObjectDataSource
        /// generates a dynamic sort expression (example: "Name desc") that specifies the property of the object sort
        /// on.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="sortExpression">The sort expression.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="InvalidCastException"></exception>
        /// <remarks>Original code by: C.F.Meijers</remarks>
        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, string sortExpression)
        {
            if (sortExpression.HasValue() == false)
            {
                return null;
            }

            sortExpression += string.Empty;
            var parts = sortExpression.Split(Convert.ToChar(" ", CultureInfo.InvariantCulture));
            var descending = false;
            var property = string.Empty;

            if (parts.Length > 0 && !string.IsNullOrEmpty(parts[0]))
            {
                property = parts[0];

                if (parts.Length > 1)
                {
                    @descending = CultureInfo.InvariantCulture.TextInfo.ToLower(parts[1]).Contains("esc");
                }

                var prop = typeof(T).GetRuntimeProperty(property);

                if (prop is null)
                {
                    throw new InvalidCastException($"{(string.Format(CultureInfo.InvariantCulture, "{0}{1}", Convert.ToString("No property '", CultureInfo.InvariantCulture), property))}' in + {typeof(T).Name}'");
                }

                return @descending
                    ? list.OrderByDescending(x => prop.GetValue(x, null))
                    : list.OrderBy(x => prop.GetValue(x, null));
            }

            return list;
        }

        /// <summary>
        /// Orders collection by <see cref="StringComparer.Ordinal" />
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <returns>IOrderedEnumerable&lt;TSource&gt;.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static IOrderedEnumerable<TSource> OrderByOrdinal<TSource>(this IEnumerable<TSource> source,
                                                                          Func<TSource, string> keySelector)
        { return source.OrderBy(keySelector, StringComparer.Ordinal); }

        /// <summary>
        /// Pages the specified list.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="pageSize">Size of the page. Minimum page size is 1.</param>
        /// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
        /// <exception cref="ArgumentNullException">pageSize</exception>
        /// <exception cref="System.ArgumentNullException">pageSize</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">pageSize</exception>
        public static IEnumerable<IEnumerable<T>> Page<T>(this IEnumerable<T> list, int pageSize)
        {
            pageSize = pageSize.EnsureMinimumValue(1);

            using (var enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var currentPage = new List<T>(pageSize) { enumerator.Current };

                    while (currentPage.Count < pageSize && enumerator.MoveNext())
                    {
                        currentPage.Add(enumerator.Current);
                    }

                    yield return currentPage.AsEnumerable();
                }
            }
        }

        /// <summary>
        /// Picks a random item from a collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns>T.</returns>
        [Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100)]
        public static T PickRandom<T>(this IEnumerable<T> list)
        {
            var index = new Random().Next(0, list.Count() - 1);

            return list.ElementAt(index);
        }


        /// <summary>
        /// Groups the elements of a sequence according to a specified firstKey selector function and rotates the unique
        /// values from the secondKey selector function into multiple values in the output, and performs aggregations.
        /// </summary>
        /// <typeparam name="TSource">The type of the t list.</typeparam>
        /// <typeparam name="TFirstKey">The type of the t first key.</typeparam>
        /// <typeparam name="TSecondKey">The type of the t second key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="firstKeySelector">The first key selector.</param>
        /// <param name="secondKeySelector">The second key selector.</param>
        /// <param name="aggregate">The aggregate.</param>
        /// <returns>Dictionary&lt;TFirstKey, Dictionary&lt;TSecondKey, TValue&gt;&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value. or list - Aggregate cannot be null. or firstKeySelector -
        /// First key selector cannot be null. or secondKeySelector - Second key selector cannot be null.</exception>
        public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> list, Func<TSource, TFirstKey> firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
        {
            var returnValue = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

            var lookup = list.ToLookup(firstKeySelector).ToList();

            lookup.ForEach(item =>
            {
                var collection = new Dictionary<TSecondKey, TValue>();

                returnValue.Add(item.Key, collection);

                var secondLookup = item.ToLookup(secondKeySelector).ToList();

                secondLookup.ForEach(subitem =>
                {
                    collection.Add(subitem.Key, aggregate.Invoke(subitem));
                });
            });

            return returnValue;
        }

        /// <summary>
        /// Randomizes the specified list.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        [Obsolete("Use Shuffle() instead. This method will be removed at the end of 2020.")]
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> list)
        {
            var randomizer = new Random();
            return list.OrderBy(x => randomizer.Next());
        }

        /// <summary>
        /// Removes the first item in the array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <returns>T[].</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static T[] RemoveFirst<T>(this T[] array)
        {
            T[] result = new T[array.Length - 1];

            Array.Copy(array, 1, result, 0, result.Length);

            return result;
        }


        /// <summary>
        /// Removes the last.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <returns>T[].</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static T[] RemoveLast<T>(this T[] array)
        {
            T[] result = new T[array.Length - 1];
            Array.Copy(array, result, result.Length);

            return result;
        }

        /// <summary>
        /// Shuffles the specified items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The items.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list</exception>
        [Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 80)]
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list)
        {
            if (list.DoesNotHaveItems())
            {
                ExceptionThrower.ThrowArgumentNullException("List is null or does not contain items.", nameof(list));
            }

            return list.OrderBy(i => random.Next());
        }

        /// <summary>
        /// Shuffles the specified items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The items.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list</exception>
        [Information(nameof(Shuffle), "David McCarter", "8/27/2020", "8/27/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 83.33)]
        public static ImmutableArray<T> Shuffle<T>(this ImmutableArray<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} is null.");
            }

            return list.OrderBy(i => random.Next()).ToImmutableArray();
        }

        /// <summary>
        /// Shuffles the specified count.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The items.</param>
        /// <param name="count">The count.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list</exception>
        /// <exception cref="ArgumentOutOfRangeException">count - Count must be greater than 0</exception>
        [Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 60)]
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} is null.");
            }

            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be greater than 0");
            }

            return list.Shuffle().Take(count);
        }

        /// <summary>
        /// Determins if first collection starts with the second collection.
        /// </summary>
        /// <typeparam name="T">The type of the t source.</typeparam>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static bool StartsWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            using (var firstEnumerator = first.GetEnumerator())
            {
                using (var secondEnumerator = second.GetEnumerator())
                {
                    while (secondEnumerator.MoveNext())
                    {
                        if (!firstEnumerator.MoveNext() || !Equals(firstEnumerator.Current, secondEnumerator.Current))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Determins if two collection sequences are equal.
        /// </summary>
        /// <typeparam name="T">The type of the t source.</typeparam>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">second</exception>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static bool StructuralSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            if (second == null)
            {
                throw new ArgumentNullException(nameof(second), $"{nameof(second)} is null.");
            }

            if (ReferenceEquals(first, second))
            {
                return true;
            }

            using (var firstEnumerator = first.GetEnumerator())
            {
                using (var secondEnumerator = second.GetEnumerator())
                {
                    while (firstEnumerator.MoveNext())
                    {
                        if (!secondEnumerator.MoveNext() ||
                            !StructuralComparisons.StructuralEqualityComparer
                                .Equals(firstEnumerator.Current, secondEnumerator.Current))
                        {
                            return false;
                        }
                    }

                    return !secondEnumerator.MoveNext();
                }
            }
        }

        /// <summary>
        /// Convert a list to a delimited string.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <exception cref="System.ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static string ToDelimitedString<T>(this IEnumerable<T> list, char delimiter = ',')
        {
            if (list.HasItems() == false)
            {
                return string.Empty;
            }
            else
            {
                var sb = new StringBuilder();

                list.ToList()
                    .ForEach(item =>
                    {
                        if (sb.Length > 0)
                        {
                            sb.Append(delimiter.ToString(CultureInfo.CurrentCulture).ToTrimmed());
                        }

                        sb.Append(item.ToString());
                    });

                return sb.ToString();
            }
        }

        /// <summary>
        /// Converts an enumeration of groupings into a Dictionary of those groupings.
        /// </summary>
        /// <typeparam name="TKey">Key type of the grouping and list.</typeparam>
        /// <typeparam name="TValue">Element type of the grouping and list list.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>A list of groupings such that the key of the list is TKey type and the value is List of TValue type.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: James Michael Hare</remarks>
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> list)
        {
            return list.ToDictionary(group => group.Key, group => group.ToList());
        }

        /// <summary>
        /// Returns no duplicates.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>System.String[].</returns>
        public static string[] ToDistinct(this string[] list) => list.Distinct().ToArray();

        /// <summary>
        /// To the immutable dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
        public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this Dictionary<TKey, TValue> values)
        { return ImmutableDictionary.CreateRange<TKey, TValue>(values); }

        /// <summary>
        /// To the immutable.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>IImmutableList&lt;T&gt;.</returns>
        public static ImmutableList<T> ToImmutable<T>(this IEnumerable<T> values)
        { return ImmutableList.CreateRange<T>(values); }

        /// <summary>
        /// Converts to ImmutableHashSet<typeparamref name="T" />&gt;.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
        public static ImmutableHashSet<T> ToImmutable<T>(this HashSet<T> values)
        { return ImmutableHashSet.CreateRange<T>(values); }

        /// <summary>
        /// Converts to immutable Dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableSortedDictionary&lt;TKey, TValue&gt;.</returns>
        public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this SortedDictionary<TKey, TValue> values)
        { return ImmutableSortedDictionary.CreateRange<TKey, TValue>(values); }

        /// <summary>
        /// Converts to immutable SortedSet.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableSortedSet&lt;T&gt;.</returns>
        public static ImmutableSortedSet<T> ToImmutable<T>(this SortedSet<T> values)
        { return ImmutableSortedSet.CreateRange<T>(values); }

        /// <summary>
        /// Converts to linkedlist.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>LinkedList&lt;T&gt;.</returns>
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> values) => new LinkedList<T>(values);


        //TODO: NEEDS C# 8
        //public static async Task<List<TSource>> ToListAsync<TSource>(
        //    this IAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default)
        //{
        //    var list = new List<TSource>();
        //    await foreach (var element in source.WithCancellation(cancellationToken))
        //    {
        //        list.Add(element);
        //    }

        //    return list;
        //}

        /// <summary>
        /// Converts <see cref="IEnumerable" /> collection to a <see cref="List{T}" />.
        /// </summary>
        /// <typeparam name="T">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>List&lt;TSource&gt;.</returns>
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        public static List<T> ToList<T>(this IEnumerable source) { return source.OfType<T>().ToList(); }

        /// <summary>
        /// Creates a Generic List async.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static Task<List<T>> ToListAsync<T>(this IEnumerable<T> list) { return Task.Run(() => list.ToList()); }

        /// <summary>
        /// To the enumeration to ObservableCollection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ObservableCollection.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        { return new ObservableCollection<T>(list); }

        /// <summary>
        /// Converts List to ObservableCollection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ObservableCollection.</returns>
        public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> list)
        { return new ObservableCollection<T>(list); }

        /// <summary>
        /// Creates a read only list.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> list)
        { return new ReadOnlyCollection<T>(list); }

        /// <summary>
        /// Adds the or update.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>TValue.</returns>
        /// <exception cref="ArgumentNullException">key</exception>
        /// <exception cref="ArgumentNullException">value</exception>
        /// <exception cref="ArgumentNullException">key</exception>
        /// <exception cref="ArgumentNullException">value</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
        public static TValue Upsert<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }


            if (dictionary.TryGetValue(key, out TValue item) == false)
            {
                dictionary.Add(key, value);
                item = value;
            }

            return item;
        }

        /// <summary>
        /// Returns list based on function.
        /// </summary>
        /// <typeparam name="TSource">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: Phil Campbell</remarks>
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list,
                                                            bool condition,
                                                            Func<TSource, bool> predicate)
        { return condition ? list.Where(predicate) : list; }

        /// <summary>
        /// Returns list based on function.
        /// </summary>
        /// <typeparam name="TSource">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: Phil Campbell</remarks>
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list,
                                                            bool condition,
                                                            Func<TSource, int, bool> predicate)
        { return condition ? list.Where(predicate) : list; }

        /// <summary>
        /// Class DynamicEqualityComparer. This class cannot be inherited. Implements the <see cref="System.Collections.Generic.IEqualityComparer{T}" />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <seealso cref="System.Collections.Generic.IEqualityComparer{T}" />
        /// <remarks>Orginal code from efcore-master on GitHub.</remarks>
        private sealed class DynamicEqualityComparer<T> : IEqualityComparer<T>
            where T : class
        {
            private readonly Func<T, T, bool> _func;

            /// <summary>
            /// Initializes a new instance of the <see cref="DynamicEqualityComparer{T}" /> class.
            /// </summary>
            /// <param name="func">The function.</param>
            public DynamicEqualityComparer(Func<T, T, bool> func) { _func = func; }

            /// <summary>
            /// Determines whether the specified objects are equal.
            /// </summary>
            /// <param name="x">The first object of type T to compare.</param>
            /// <param name="y">The second object of type T to compare.</param>
            /// <returns>true if the specified objects are equal; otherwise, false.</returns>
            public bool Equals(T x, T y) => _func(x, y);

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <param name="obj">The <see cref="T:System.Object"></see> for which a hash code is to be returned.</param>
            /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash
            /// table.</returns>
            public int GetHashCode(T obj) => 0;
        }
    }
}
