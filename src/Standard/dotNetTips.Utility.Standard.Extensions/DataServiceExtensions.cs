// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-08-2020
// ***********************************************************************
// <copyright file="DataServiceExtensions.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Text;
using dotNetTips.Utility.Standard.Common;

namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// DataServiceExtensions.
    /// </summary>
    public static  class DataServiceExtensions
    {
        /// <summary>
        /// Copies the request header values to a collection.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>SortedDictionary&lt;System.String, System.String&gt;.</returns>
        /// <exception cref="ArgumentNullException">args</exception>
        [Information(nameof(CopyRequestHeaderValues), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/8/2020", UnitTestCoverage = 0, Status = Status.New)]
        public static SortedDictionary<string, string> CopyRequestHeaderValues(this ProcessRequestArgs args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var requestHeaderValues = new SortedDictionary<string, string>();

            if (args.OperationContext.RequestHeaders != null && args.OperationContext.RequestHeaders.Count > 0)
            {
                for (var i = 0; i < args.OperationContext.RequestHeaders.AllKeys.Length; i++)
                {
                    var key = args.OperationContext.RequestHeaders.AllKeys[i];
                    requestHeaderValues.Add(key, args.OperationContext.RequestHeaders.Get(key));
                }
            }

            return requestHeaderValues;
        }
    }
}
