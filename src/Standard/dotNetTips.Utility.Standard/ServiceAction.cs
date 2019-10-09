// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 07-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2019
// ***********************************************************************
// <copyright file="ServiceAction.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// Class ServiceAction.
    /// </summary>
    public class ServiceAction
    {
        /// <summary>
        /// Gets or sets the service action request.
        /// </summary>
        /// <value>The service action request.</value>
        public ServiceActionRequest ServiceActionRequest
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the service action result.
        /// </summary>
        /// <value>The service action result.</value>
        public ServiceActionResult ServiceActionResult
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        public string ServiceName
        {
            get; set;
        }
    }
}
