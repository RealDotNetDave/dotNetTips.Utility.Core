// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-11-2020
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace dotNetTips.Utility.Standard.Extensions
{
	/// <summary>
	/// Extension methods for <see cref="Enum" />.
	/// </summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// Converts enum to type.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="val">The value.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">val.</exception>
		/// <exception cref="System.ArgumentNullException">The exception.</exception>
		public static T As<T>(this Enum val)
		{
			if (val == null)
			{
				throw new ArgumentNullException(nameof(val), $"{nameof(val)} is null.");
			}

			var enumType = val.GetType();
			var enumValue = Enum.Parse(enumType, val.ToString());
			return (T)enumValue;
		}

		/// <summary>
		/// Gets the enum description.
		/// </summary>
		/// <param name="val">The value.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">val.</exception>
		public static string GetDescription(this Enum val)
		{
			if (val == null)
			{
				throw new ArgumentNullException(nameof(val), $"{nameof(val)} is null.");
			}

			var field = val.GetType().GetField(val.ToString());
			var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
			return attributes.Length > 0 ? attributes[0].Description : val.ToString();
		}

		/// <summary>
		/// Gets the items in an enum.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="enumeration">The enumeration.</param>
		/// <returns>IList&lt;EnumItem&lt;T&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">enumeration.</exception>
		/// <exception cref="System.ArgumentNullException">The exception.</exception>
		public static IList<EnumItem<T>> GetItems<T>(this Enum enumeration)
		{
			if (enumeration == null)
			{
				throw new ArgumentNullException(nameof(enumeration), $"{nameof(enumeration)} is null.");
			}

			var enumType = enumeration.GetType();
			var values = Enum.GetValues(enumType);
			var items = new List<EnumItem<T>>();

			var list = values as System.Collections.IList;

			for (var itemCount = 0; itemCount < list.Count; itemCount++)
			{
				var v = list[itemCount];
				var enumValue = Enum.Parse(enumType, v.ToString());
				items.Add(GetDescriptionInternal<T>(enumValue));
			}

			return items;
		}

		/// <summary>
		/// Parses the specified enum name.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="name">The name.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentException">name.</exception>
		/// <exception cref="System.ArgumentException">The exception.</exception>
		public static T Parse<T>(this string name)
			where T : struct
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException($"{nameof(name)} is null or empty.", nameof(name));
			}

			return (T)Enum.Parse(typeof(T), name);
		}

		/// <summary>
		/// Gets the description of the enum value.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="val">The value.</param>
		/// <returns>EnumItem&lt;T&gt;.</returns>
		/// <exception cref="System.ArgumentNullException">The exception.</exception>
		private static EnumItem<T> GetDescriptionInternal<T>(object val)
		{
			if (val == null)
			{
				throw new ArgumentNullException(nameof(val), $"{nameof(val)} is null.");
			}

			var field = val.GetType().GetField(val.ToString());
			var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

			var enumItem = new EnumItem<T>
			{
				Description = attributes.Length > 0 ? attributes[0].Description : val.ToString(),
				Value = (T)val,
			};

			return enumItem;
		}
	}
}
