// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-08-2020
// ***********************************************************************
// <copyright file="DataContextExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using dotNetTips.Utility.Standard.Common;
using LinqToDB;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// DataContextExtensions.
    /// </summary>
    public static class DataContextExtensions
    {
        /// <summary>
        /// Gets the tracked objects.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="context">The context.</param>
        /// <returns>IList&lt;Tuple&lt;T, T&gt;&gt;.</returns>
        [Information(nameof(GetTrackedObjects), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static IList<Tuple<T, T>> GetTrackedObjects<T>(this DataContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            List<Tuple<T, T>> result = new List<Tuple<T, T>>();
            var dcType = typeof(DataContext);

            // Use reflection to get to the underlying items being tracked in the DataContext
            const BindingFlags Bindings = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField;

            var services = dcType.GetField("services", Bindings).GetValue(context);

            var tracker = services.GetType().GetField("tracker", Bindings).GetValue(services);

            var trackerItems = (IDictionary)tracker.GetType().GetField("items", Bindings).GetValue(tracker);

            // iterate through each update in context, adding only those that are of type T to the method's result variable
            foreach (DictionaryEntry entry in trackerItems)
            {
                dynamic original = entry.Value.GetType().GetField(nameof(original), Bindings).GetValue(entry.Value);

                if (entry.Key is T && original is T)
                {
                    result.Add(new Tuple<T, T>((T)original, (T)entry.Key));
                }
            }

            return result;
        }

    }
}
