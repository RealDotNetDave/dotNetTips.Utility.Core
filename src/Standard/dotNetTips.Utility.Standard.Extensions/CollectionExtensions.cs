// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2019
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
using System.Text;
using System.Threading.Tasks;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Extension methods for a collection.
    /// </summary>
    public static class CollectionExtensions
    {

        /// <summary>
        /// Adds if not exists.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The value.</param>
        /// <exception cref="ArgumentNullException">list - List cannot be null.
        /// or
        /// value - Value cannot be null.</exception>
        /// <exception cref="ArgumentException">list - List cannot be read-only.</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        /// <exception cref="System.ArgumentException">List cannot be read-only.</exception>
        public static void AddIfNotExists<T>(this ICollection<T> list, T item)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                throw new ArgumentException("List cannot be read-only.", nameof(list));
            }

            if (item is null)
            {
                throw new ArgumentNullException(nameof(item), $"{nameof(item)} is null.");
            }

            if (list.Contains(item))
            {
                return;
            }
            else
            {
                list.Add(item);
            }
        }

        /// <summary>
        /// Adds if not exists.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The values.</param>
        /// <exception cref="ArgumentNullException">list - List cannot be null.
        /// or
        /// values - Values cannot be null.</exception>
        /// <exception cref="ArgumentException">list - List cannot be read-only.</exception>
        public static void AddIfNotExists<T>(this ICollection<T> list, params T[] items)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                throw new ArgumentException("List cannot be read-only.", nameof(list));
            }

            if (items.HasItems())
            {
                for (int index = 0; index < items.Length; index++)
                {
                    list.AddIfNotExists(items[index]);
                }
            }
        }

        /// <summary>
        /// Adds the items to the collection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The new items.</param>
        /// <param name="insureUnique">Set to true if items added to list are unique.</param>
        /// <exception cref="ArgumentNullException">items</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        /// <exception cref="ArgumentException">items</exception>
        public static void AddRange<T>(this ICollection<T> list, IEnumerable<T> items, bool insureUnique = false)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                throw new ArgumentException("List cannot be read-only.", nameof(list));
            }

            if (items.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(items), $"{nameof(items)} is null.");
            }

            if (items.HasItems())
            {
                items.ToList().ForEach(item =>
                {
                    if (insureUnique)
                    {
                        list.AddIfNotExists(item);
                    }
                    else
                    {
                        list.Add(item);
                    }
                });
            }
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
        /// <exception cref="ArgumentNullException">list - Dictionary cannot be null.
        /// or
        /// key - Key cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">list - Dictionary cannot be null.
        /// or
        /// key - Key cannot be null.</exception>
        /// <exception cref="ArgumentException">list - Dictionary cannot be null.
        /// or
        /// key - Key cannot be null.</exception>
        /// <remarks>Code by: Lucas</remarks>
        public static void AddRange<T, TKey, TValue>(this IDictionary<TKey, TValue> list, IEnumerable<T> items, Func<T, TKey> key, Func<T, TValue> value)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (list.IsReadOnly)
            {
                throw new ArgumentException("List cannot be read-only.", nameof(list));
            }

            if (items.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(items), $"{nameof(items)} is null or is empty.");
            }

            if (key is null)
            {
                throw new ArgumentNullException(nameof(key), $"{nameof(key)} is null.");
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), $"{nameof(value)} is null.");
            }

            if (items.HasItems())
            {
                items.ToList().ForEach(item =>
                {
                    list.Add(key(item), value(item));
                });
            }
        }

        /// <summary>
        /// Copies the collection to a generic List.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="source">The source.</param>
        /// <returns>List&lt;T&gt;.</returns>
        public static List<T> CopyToList<T>(this List<T> source)
        {
            if (source.HasItems()==false)
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
        public static int Count(this IEnumerable list)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

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
        public static void DisposeCollection<TKey, TValue>(this IDictionary<TKey, TValue> items) => ProcessCollectionToDispose(items.Select(p => p.Value));

        /// <summary>
        /// Fasts any.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>System.Boolean.</returns>
        /// <exception cref="ArgumentNullException">predicate - predicate</exception>
        /// <exception cref="System.ArgumentNullException">predicate - predicate</exception>
        public static bool FastAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

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
        /// <exception cref="ArgumentNullException">source
        /// or
        /// source</exception>
        /// <exception cref="System.ArgumentNullException">source
        /// or
        /// source</exception>
        /// <exception cref="Exception">source
        /// or
        /// source</exception>
        public static int FastCount<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

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
        /// Finds first item or returns null.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="match">The match.</param>
        /// <returns>System.Nullable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null.
        /// or
        /// match - Match cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        public static T? FirstOrNull<T>(this IEnumerable<T> list, Func<T, bool> match) where T : struct
        {
            if (list.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} is null or is empty.");
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
        /// Converts delimited string to list.
        /// </summary>
        /// <param name="delimitedInput">The string buffer.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        /// <exception cref="ArgumentException">delimitedInput</exception>
        /// <remarks>Code by: Blake Pell</remarks>
        public static IEnumerable<string> FromDelimitedString(this string delimitedInput, char delimiter)
        {
            if (string.IsNullOrEmpty(delimitedInput))
            {
                throw new ArgumentException($"{nameof(delimitedInput)} is null or empty.", nameof(delimitedInput));
            }

            var items = delimitedInput.Split(delimiter);

            return items.AsEnumerable();
        }

        /// <summary>
        /// Determines whether the specified source has items.
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
        /// Determines whether the specified collection has items based on the Predicate.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
        /// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException">action</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        public static bool HasItems<T>(this List<T> source, Predicate<T> action)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (action is null)
            {
                throw new ArgumentNullException(nameof(action), $"{nameof(action)} is null.");
            }

            return source.TrueForAll(action);
        }

        /// <summary>
        /// Orders a list based on a sort expression. Useful in object data binding scenarios where
        /// the ObjectDataSource generates a dynamic sort expression (example: "Name desc") that
        /// specifies the property of the object sort on.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="sortExpression">The sort expression.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="InvalidCastException">The exception.</exception>
        /// <exception cref="System.InvalidCastException">The exception.</exception>
        /// <exception cref="ArgumentNullException">The exception.</exception>
        /// <remarks>Original code by: C.F.Meijers</remarks>
        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, string sortExpression)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (string.IsNullOrEmpty(sortExpression))
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
                    @descending = CultureInfo.InvariantCulture.TextInfo.ToLower(parts[1]).Contains("esc", StringComparison.InvariantCultureIgnoreCase);
                }

                var prop = typeof(T).GetRuntimeProperty(property);

                if (prop is null)
                {
                    throw new InvalidCastException($"{(string.Format(CultureInfo.InvariantCulture, "{0}{1}", Convert.ToString("No property '", CultureInfo.InvariantCulture), property))}' in + {typeof(T).Name}'");
                }

                return @descending ? list.OrderByDescending(x => prop.GetValue(x, null)) : list.OrderBy(x => prop.GetValue(x, null));
            }

            return list;
        }

        /// <summary>
        /// Pages the specified list.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null.
        /// or
        /// list - Page size cannot be 0 length.</exception>
        /// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The exception.</exception>
        public static IEnumerable<IEnumerable<T>> Page<T>(this IEnumerable<T> list, int pageSize)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} is null.");
            }

            if (pageSize < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), $"{nameof(pageSize)} cannot be less than 1.");
            }

            using (var enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var currentPage = new List<T>(pageSize)
                    {
                        enumerator.Current
                    };

                    while (currentPage.Count < pageSize && enumerator.MoveNext())
                    {
                        currentPage.Add(enumerator.Current);
                    }

                    yield return currentPage.AsEnumerable();
                }
            }
        }

        /// <summary>
        /// Picks random items out of the list.
        /// </summary>
        /// <typeparam name="T">Collection type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="count">The selection count.</param>
        /// <returns>IEnumerable list.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.
        /// or
        /// list - Count cannot be 0.</exception>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> list, int count) => list.Randomize().Take(count);

        /// <summary>
        /// Groups the elements of a sequence according to a specified firstKey selector function and
        /// rotates the unique values from the secondKey selector function into multiple values in
        /// the output, and performs aggregations.
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
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.
        /// or
        /// list - Aggregate cannot be null.
        /// or
        /// firstKeySelector - First key selector cannot be null.
        /// or
        /// secondKeySelector - Second key selector cannot be null.</exception>
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
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> list) => list.OrderBy(x => new Random().Next());

        /// <summary>
        /// Convert a list to a delimited string.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <exception cref="System.ArgumentNullException">The exception.</exception>
        public static string ToDelimitedString<T>(this IEnumerable<T> list, char delimiter)
        {
            if (list.HasItems() == false)
            {
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} is null or is empty.");
            }

            var sb = new StringBuilder();

            list.ToList().ForEach(item =>
            {
                if (sb.Length > 0)
                {
                    sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
                }

                sb.Append(item.ToString());
            });

            return sb.ToString();
        }

        /// <summary>
        /// Converts an enumeration of groupings into a Dictionary of those groupings.
        /// </summary>
        /// <typeparam name="TKey">Key type of the grouping and list.</typeparam>
        /// <typeparam name="TValue">Element type of the grouping and list list.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>A list of groupings such that the key of the list is TKey type and the value
        /// is List of TValue type.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: James Michael Hare</remarks>
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> list) => list.ToDictionary(group => group.Key, group => group.ToList());

        /// <summary>
        /// Returns no duplicates.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>System.String[].</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 length.</exception>
        public static string[] ToDistinct(this string[] list) => list.Distinct().ToArray();

        /// <summary>
        /// To the immutable dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
        public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this Dictionary<TKey, TValue> values)
        {
            var builder = ImmutableDictionary.CreateRange<TKey, TValue>(values);

            return builder;
        }

        /// <summary>
        /// To the immutable.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>IImmutableList&lt;T&gt;.</returns>
        public static ImmutableList<T> ToImmutable<T>(this IEnumerable<T> values)
        {
            var builder = ImmutableList.CreateRange<T>(values);

            return builder;
        }

        /// <summary>
        /// Converts to ImmutableHashSet<typeparamref name="T" />&gt;.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
        /// <remarks>NEW: Added July 2019</remarks>
        public static ImmutableHashSet<T> ToImmutable<T>(this HashSet<T> values)
        {
            var builder = ImmutableHashSet.CreateRange<T>(values);

            return builder;
        }

        /// <summary>
        /// Converts to immutable Dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableSortedDictionary&lt;TKey, TValue&gt;.</returns>
        /// <remarks>NEW: Added July 2019</remarks>
        public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this SortedDictionary<TKey, TValue> values)
        {
            var builder = ImmutableSortedDictionary.CreateRange<TKey, TValue>(values);

            return builder;
        }

        /// <summary>
        /// Converts to immutable SortedSet.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>ImmutableSortedSet&lt;T&gt;.</returns>
        /// <remarks>NEW: Added July 2019</remarks>
        public static ImmutableSortedSet<T> ToImmutable<T>(this SortedSet<T> values)
        {
            var builder = ImmutableSortedSet.CreateRange<T>(values);

            return builder;
        }

        /// <summary>
        /// Converts to linkedlist.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="values">The values.</param>
        /// <returns>LinkedList&lt;T&gt;.</returns>
        /// <remarks>NEW: Added July 2019</remarks>
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> values) => new LinkedList<T>(values);

        /// <summary>
        /// Creates a Generic List async.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static Task<List<T>> ToListAsync<T>(this IEnumerable<T> list)
        {
            return Task.Run(() => list.ToList());
        }

        /// <summary>
        /// To the enumeration to ObservableCollection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ObservableCollection.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            return new ObservableCollection<T>(list);
        }

        /// <summary>
        /// Converts List to ObservableCollection.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ObservableCollection.</returns>
        /// <remarks>NEW: Added July 2019</remarks>
        public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> list)
        {
            return new ObservableCollection<T>(list);
        }

        /// <summary>
        /// Creates a read only list.
        /// </summary>
        /// <typeparam name="T">The type of T.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> list)
        {
            return new ReadOnlyCollection<T>(list);
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
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list, bool condition, Func<TSource, bool> predicate)
        {
            return condition ? list.Where(predicate) : list;
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
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list, bool condition, Func<TSource, int, bool> predicate)
        {
            return condition ? list.Where(predicate) : list;
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
                    else
                    {
                        return;
                    }
                }
            }
        }

    }
}