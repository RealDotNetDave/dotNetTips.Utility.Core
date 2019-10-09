// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard
// Author           : David McCarter
// Created          : 01-21-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2017
// ***********************************************************************
// <copyright file="MathExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.OOP;
using System;

/// <summary>
/// The Extensions namespace.
/// </summary>
namespace dotNetTips.Utility.Standard.Extensions
{
    /// <summary>
    /// Class MathExtensions.
    /// </summary>
    public static class MathExtensions
    {
        #region Public Methods

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this double value)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= double.MinValue || value >= double.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digits">The digits.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this double value, int digits)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= double.MinValue || value >= double.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value, digits));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="mode">The mode.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this double value, MidpointRounding mode)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= double.MinValue || value >= double.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value, mode));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digits">The digits.</param>
        /// <param name="mode">The mode.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this double value, int digits, MidpointRounding mode)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= double.MinValue || value >= double.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value, digits, mode));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this decimal value)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= decimal.MinValue || value >= decimal.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digits">The digits.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this decimal value, int digits)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(value <= decimal.MinValue || value >= decimal.MaxValue, nameof(value));

            return Convert.ToInt32(System.Math.Round(value, digits));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="mode">The mode.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this decimal value, MidpointRounding mode)
        {
            if (value <= decimal.MinValue || value >= decimal.MaxValue)
            {
                throw new ArgumentNullException(nameof(value), "Value is invalid.");
            }

            return Convert.ToInt32(System.Math.Round(value, mode));
        }

        /// <summary>
        /// Rounds the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="digits">The digits.</param>
        /// <param name="mode">The mode.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
        /// <remarks>Code by: Lucas http://code.msdn.microsoft.com/LucasExtensions</remarks>
        public static int Round(this decimal value, int digits, MidpointRounding mode)
        {
            if (value <= decimal.MinValue || value >= decimal.MaxValue)
            {
                throw new ArgumentNullException(nameof(value), "Value is invalid.");
            }

            return Convert.ToInt32(System.Math.Round(value, digits, mode));
        }

        #endregion Public Methods
    }
}