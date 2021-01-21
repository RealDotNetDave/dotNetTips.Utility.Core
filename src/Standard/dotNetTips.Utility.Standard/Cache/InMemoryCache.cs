// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 06-26-2017
//
// Last Modified By : David McCarter
// Last Modified On : 08-07-2020
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Microsoft.Extensions.Caching.Memory;

namespace dotNetTips.Utility.Standard.Cache
{
    /// <summary>
    /// Class InMemoryCache.
    /// </summary>
    /// <remarks>Expiration is set to 20 minutes.</remarks>
    public sealed class InMemoryCache
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private static readonly InMemoryCache _instance = new InMemoryCache();

        /// <summary>
        /// Prevents a default instance of the <see cref="InMemoryCache"/> class from being created.
        /// Default timeout is 20 minutes.
        /// </summary>
        private InMemoryCache()
        {
            this.Cache = CreateCache(new TimeSpan(0, 20, 0));
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static InMemoryCache Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Gets or sets (private) the cache.
        /// </summary>
        /// <value>The cache.</value>
        public MemoryCache Cache { get; private set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count => _instance.Cache.Count;

        /// <summary>
        /// Adds item to the cache.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="item">The item.</param>
        public void AddCacheItem<T>(string key, T item) => this.Cache.Set(key, item);

        /// <summary>
        /// Gets the cache item.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="key">The key.</param>
        /// <returns>TValue.</returns>
        public T GetCacheItem<T>(string key)
        {
            this.Cache.TryGetValue<T>(key, out var item);

            return item;
        }

        /// <summary>
        /// Creates the cache using 20 minute expiration.
        /// </summary>
        /// <returns>MemoryCache.</returns>
        private static MemoryCache CreateCache(TimeSpan expariation)
        {
            var options = new MemoryCacheOptions
            {
                ExpirationScanFrequency = expariation,
            };

            return new MemoryCache(options);
        }
    }
}
