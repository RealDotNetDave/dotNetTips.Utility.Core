// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 02-11-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2019
// ***********************************************************************
// <copyright file="ICloneable.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace dotNetTips.Utility.Standard
{
    /// <summary>
    /// ICloneable Interface.
    /// </summary>
   /// <typeparam name="T">Generic type parameter.</typeparam>
    public interface ICloneable<T>
    {
        /// <summary>
        /// Cones this instance.
        /// </summary>
        /// <returns>T.</returns>
        T Cone();
    }
}