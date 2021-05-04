// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2021
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using dotNetTips.Utility.Standard.Common;
using dotNetTips.Utility.Standard.Extensions.Properties;

namespace dotNetTips.Utility.Standard.Extensions
{
	/// <summary>
	/// Extension methods for objects.
	/// </summary>
	public static class ObjectExtensions
	{
		private const string NullString = "[null]";

		private static readonly Dictionary<Type, string> _builtInTypeNames = new Dictionary<Type, string>
		{
			{ typeof(void), "void" },
			{ typeof(bool), "bool" },
			{ typeof(byte), "byte" },
			{ typeof(char), "char" },
			{ typeof(decimal), "decimal" },
			{ typeof(double), "double" },
			{ typeof(float), "float" },
			{ typeof(int), "int" },
			{ typeof(long), "long" },
			{ typeof(object), "object" },
			{ typeof(sbyte), "sbyte" },
			{ typeof(short), "short" },
			{ typeof(string), "string" },
			{ typeof(uint), "uint" },
			{ typeof(ulong), "ulong" },
			{ typeof(ushort), "ushort" },
			{ typeof(DateTime), "datetime" },
			{ typeof(DateTimeOffset), "datetimeoffset" },
		};

		/// <summary>
		/// Converts object to a different type.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="value">The value.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">value.</exception>
		public static T As<T>(this object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			return (T)value;
		}

		/// <summary>
		/// Clones the specified object.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="obj">The object.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">obj.</exception>
		public static T Clone<T>(this object obj)
			where T : class
		{
			if (obj is null)
			{
				throw new ArgumentNullException(nameof(obj));
			}

			var json = JsonSerializer.Serialize(obj);

			return JsonSerializer.Deserialize<T>(json);
		}

		/// <summary>
		/// Computes the sha256 hash.
		/// </summary>
		/// <param name="data">The data.</param>
		/// <returns>System.String.</returns>
		public static string ComputeSha256Hash(this object data)
		{
			// Create a SHA256
			using (var sha256Hash = SHA256.Create())
			{
				// ComputeHash - returns byte array
				var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data.ToJson()));

				// Convert byte array to a string
				var builder = new StringBuilder();

				for (var i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2", CultureInfo.InvariantCulture));
				}

				return builder.ToString();
			}
		}

		/// <summary>
		/// Disposes the fields.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <exception cref="ArgumentNullException">obj.</exception>
		public static void DisposeFields(this IDisposable obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException(nameof(obj), $"{nameof(obj)} is null.");
			}

			var list = obj.GetType().GetRuntimeFields().Where(p => p.IsStatic == false).ToList();

			for (var fieldCount = 0; fieldCount < list.Count; fieldCount++)
			{
				var value = list[fieldCount].GetValue(obj);

				if (value != null)
				{
					if (value is IDisposable disposableItem)
					{
						disposableItem.TryDispose();
					}
					else if (value is IEnumerable collection)
					{
						collection.DisposeCollection();
					}
				}
			}
		}

		/// <summary>
		/// Creates object from Json.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="input">The json.</param>
		/// <returns>T.</returns>
		public static T FromJson<T>(this string input)
			where T : class
		{
			return JsonSerializer.Deserialize<T>(input);
		}

		/// <summary>
		/// Creates object from a Json file.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>T.</returns>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="System.IO.FileNotFoundException"></exception>
		public static T FromJsonFile<T>(string fileName)
			where T : class
		{
			if (File.Exists(fileName) == false)
			{
				throw new FileNotFoundException(Resources.FileNotFound, fileName);
			}

			var json = File.ReadAllText(fileName, Encoding.UTF8);

			return JsonSerializer.Deserialize<T>(json);
		}

		/// <summary>
		/// Determines whether the specified object has the property.
		/// </summary>
		/// <param name="obj">The instance.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns><c>true</c> if the specified property name has property; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">obj.</exception>
		public static bool HasProperty(this object obj, string propertyName)
		{
			if (obj is null)
			{
				throw new ArgumentNullException(nameof(obj));
			}

			var propertyInfo = obj.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == propertyName);

			return propertyInfo != null;
		}

		/// <summary>
		/// Ins the specified source.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="list">The list.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">source - Source cannot be null.
		/// or
		/// list - List cannot be null or have a 0 length.</exception>
		/// <remarks>Original code by: Rory Becker.</remarks>
		public static bool In<T>(this T source, params T[] list)
		{
			return list.FastAny(value => value.Equals(source));
		}

		/// <summary>
		/// Initializes the fields of an object.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <exception cref="ArgumentNullException">Input cannot be null.</exception>
		public static void InitializeFields(this object obj)
		{
			if (obj.IsNull())
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			var fieldInfos = obj.GetType().GetRuntimeFields().ToList();

			for (var fieldCount = 0; fieldCount < fieldInfos.Count; fieldCount++)
			{
				var fieldInfo = fieldInfos[fieldCount];
				var objectValue = fieldInfo.GetValue(obj);
				var runtimeField = obj.GetType().GetRuntimeField(fieldInfo.Name);

				if (runtimeField != null)
				{
					var t = Nullable.GetUnderlyingType(runtimeField.FieldType) ?? runtimeField.FieldType;
					var safeValue = ( objectValue == null )
						? null
						: Convert.ChangeType(objectValue, t, CultureInfo.InvariantCulture);
					runtimeField.SetValue(obj, safeValue);
				}
			}
		}

		/// <summary>
		/// Determines whether [is not null] [the specified object].
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <returns><count>true</count> if [is not null] [the specified object]; otherwise, <count>false</count>.</returns>
		public static bool IsNotNull(this object obj) => obj != null;

		/// <summary>
		/// Determines whether the specified object is null.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns><count>true</count> if the specified object is null; otherwise, <count>false</count>.</returns>
		public static bool IsNull(this object obj) => obj is null;

		/// <summary>
		/// Generates a Dictionary that represents the property name (Key) and it's value.
		/// </summary>
		/// <param name="obj">The input.</param>
		/// <param name="memberName">Name of the member used to identify the object.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore <see langword="null"/> property values].</param>
		/// <returns>IDictionary&lt;System.String, System.Object&gt;.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		/// <example>Output:
		/// [0]: {[PersonRecord.BornOn, 1/29/2007 11:52:12 AM -08:00]}
		/// [1]: {[PersonRecord.CellPhone, 747-388-4458]}
		/// [2]: {[PersonRecord.Email, elfhlsoepfmuiyr@uomrrywscvaapwjcu.org.uk]}
		/// [3]: {[PersonRecord.FirstName, ZyeMgwQRFABsisq]}
		/// [4]: {[PersonRecord.HomePhone, 255 - 871 - 4415]}
		/// [5]: {[PersonRecord.Id, 58dc933fe6004719a37e7a35373ad645]}
		/// [6]: {[PersonRecord.LastName, j_`iqWAGoOeKTpjWhojFyRHld]}
		/// [7]: {[PersonRecord.Addresses[0].Address1, XkbOcAlseMEMnPY ^ jkEcYWnFD]}
		/// [8]: {[PersonRecord.Addresses[0].Address2, tJkpTHikrRfFaGENX]`_agaw[]}
		/// [9]: {[PersonRecord.Addresses[0].City, KlWA ^ Aw]KhqADREV\uwmXJeAU]}
		/// [10]: {[PersonRecord.Addresses[0].Country, AtN`\NbnUIVSjUQicVXNMUL[J]}
		/// [11]: {[PersonRecord.Addresses[0].Id, 9330f3a225b14d96b67779f2c932302a]}
		/// [12]: {[PersonRecord.Addresses[0].CountyProvince, EkdKDBGWf ^ Givi[OMhIh]}
		/// [13]: {[PersonRecord.Addresses[0].State, RGOuDpJyfgwxyfC]}
		/// [14]: {[PersonRecord.Addresses[0].Phone, 065 - 507 - 7161]}
		/// [15]: {[PersonRecord.Addresses[0].PostalCode, 56633485]}
		/// [16]: {[PersonRecord.Addresses[1].Address1, lGSJwGNOtd ^ rXv`RxPcVCZHhk]}
		/// [17]: {[PersonRecord.Addresses[1].Address2, \EJGOmHyfAPERA ^ DrTR`xlDFU]}
		/// [18]: {[PersonRecord.Addresses[1].City, xiWPASydY[BEHfpVrluPNgOFS]}
		/// [19]: {[PersonRecord.Addresses[1].Country, JFpIljBDlQEkiehQ[r`\xjh[J]}
		/// [20]: {[PersonRecord.Addresses[1].Id, 8c95fd0cbbcf4beb993081bdd9c96ceb]}
		/// [21]: {[PersonRecord.Addresses[1].CountyProvince, FyHoHRZQwpMJ[gjABVUk]}
		/// [22]: {[PersonRecord.Addresses[1].State, dxeZkn[HyLo\wUS]}
		/// [23]: {[PersonRecord.Addresses[1].Phone, 511 - 286 - 7653]}
		/// [24]: {[PersonRecord.Addresses[1].PostalCode, 33385672]}.
		/// </example>
		[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "1/26/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static IDictionary<string, string> PropertiesToDictionary(this object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			if (obj is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			if (memberName is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			var result = new Dictionary<string, string>();

			if (obj is null)
			{
				result.Add(memberName, NullString);
				return result;
			}

			var objectType = obj.GetType();

			// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
			if (_builtInTypeNames.ContainsKey(objectType))
			{
				result.Add(memberName, obj.ToString());
				return result;
			}

			// If the type implements the IEnumerable interface.
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				// Loop through the collection using the enumerator strategy and collect all items in the result bag
				// Note: if the collection is empty it will not return anything about its existence,
				// because the method is supposed to catch value items not the list itself.
				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;

					var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);
					result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
				}

				return result;
			}

			// Otherwise go deeper in the object tree.
			// And foreach object public property collect each value
			var propertyCollection = objectType.GetProperties();

			var newMemberName = string.Empty;

			if (memberName.Length > 0)
			{
				newMemberName = memberName + ControlChars.Dot;
			}

			foreach (var property in propertyCollection)
			{
				var innerObject = property.GetValue(obj, null);

				if (ignoreNulls && innerObject == null)
				{
					continue;
				}

				var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);

				result = result.Concat(innerObject.PropertiesToDictionary(innerMember)).ToDictionary(e => e.Key, e => e.Value);
			}

			return result;
		}

		/// <summary>
		/// Generates a string that returns the property names and values.
		/// The input cannot be a collection type.
		/// Supports nested types.
		/// </summary>
		/// <param name="obj">The input.</param>
		/// <param name="header">The header.</param>
		/// <param name="keyValueSeparator">The key value separator.</param>
		/// <param name="sequenceSeparator">The delimiter.</param>
		/// <param name="ignoreNulls">if set to <c>true</c> [ignore null values].</param>
		/// <param name="includeMemeberName">if set to <c>true</c> [include memeber name].</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">Object cannot be null.</exception>
		/// <exception cref="ArgumentInvalidException">Object cannot be a collection type.</exception>
		/// <example>Output:
		/// PersonRecord, PersonRecord.BornOn:1/29/2007 11:52:12 AM -08:00, PersonRecord.CellPhone:747-388-4458,
		/// PersonRecord.Email:elfhlsoepfmuiyr @uomrrywscvaapwjcu.org.uk, PersonRecord.FirstName:ZyeMgwQRFABsisq,
		/// PersonRecord.HomePhone:255-871-4415, PersonRecord.Id:58dc933fe6004719a37e7a35373ad645,
		/// PersonRecord.LastName:j_`iqWAGoOeKTpjWhojFyRHld, PersonRecord.Addresses[0].Address1:XkbOcAlseMEMnPY^jkEcYWnFD,
		/// PersonRecord.Addresses[0].Address2:tJkpTHikrRfFaGENX]`_agaw[,
		/// PersonRecord.Addresses[0].City:KlWA ^ Aw] KhqADREV\\uwmXJeAU,
		/// PersonRecord.Addresses[0].Country:AtN`\\NbnUIVSjUQicVXNMUL[J,
		/// PersonRecord.Addresses[0].Id:9330f3a225b14d96b67779f2c932302a,
		/// PersonRecord.Addresses[0].CountyProvince:EkdKDBGWf ^ Givi[OMhIh,
		/// PersonRecord.Addresses[0].State:RGOuDpJyfgwxyfC, PersonRecord.Addresses[0].Phone:065 - 507 - 7161,
		/// PersonRecord.Addresses[0].PostalCode:56633485, PersonRecord.Addresses[1].Address1:lGSJwGNOtd ^ rXv`RxPcVCZHhk,
		/// PersonRecord.Addresses[1].Address2:\\EJGOmHyfAPERA ^ DrTR`xlDFU,
		/// PersonRecord.Addresses[1].City:xiWPASydY[BEHfpVrluPNgOFS,
		/// PersonRecord.Addresses[1].Country:JFpIljBDlQEkiehQ[r`\\xjh[J,
		/// PersonRecord.Addresses[1].Id:8c95fd0cbbcf4beb993081bdd9c96ceb,
		/// PersonRecord.Addresses[1].CountyProvince:FyHoHRZQwpMJ[gjABVUk,
		/// PersonRecord.Addresses[1].State:dxeZkn[HyLo\\wUS, PersonRecord.Addresses[1].Phone:511 - 286 - 7653,
		/// PersonRecord.Addresses[1].PostalCode:33385672.
		/// </example>
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", modifiedOn: "1/26/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemeberName = true)
		{
			if (obj is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			if (header is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(header));
			}

			if (sequenceSeparator is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(sequenceSeparator));
			}

			var typeName = obj.GetType().Name;

			if (typeName == typeof(List<>).Name)
			{
				typeName = "Item";
			}
			else if (includeMemeberName == false)
			{
				typeName = string.Empty;
			}

			var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

			return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result.Remove(0, sequenceSeparator.Length) : result;
		}

		/// <summary>
		/// Strips the null.
		/// </summary>
		/// <param name="obj">The field.</param>
		/// <returns>System.String.</returns>
		public static string StripNull(this object obj)
		{
			return obj == null ? string.Empty : obj.ToString();
		}

		/// <summary>
		/// Serializes object to Json.
		/// </summary>
		/// <param name="obj">The instance.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">obj.</exception>
		public static string ToJson(this object obj)
		{
			if (obj is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			return JsonSerializer.Serialize(obj);
		}

		/// <summary>
		/// Saves object to Json file.
		/// </summary>
		/// <param name="obj">The instance.</param>
		/// <param name="fileName">The file.</param>
		/// <exception cref="ArgumentNullException">obj.</exception>
		/// <exception cref="ArgumentException">message - fileName.</exception>
		public static void ToJsonFile(this object obj, string fileName)
		{
			if (obj is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(obj));
			}

			if (string.IsNullOrEmpty(fileName))
			{
				ExceptionThrower.ThrowArgumentException("File name is missing.", nameof(fileName));
			}

			var json = JsonSerializer.Serialize(obj);

			File.WriteAllText(fileName, json, Encoding.UTF8);
		}

		/// <summary>
		/// Tries the to call Dispose.
		/// </summary>
		/// <param name="obj">The obj.</param>
		public static void TryDispose(this IDisposable obj) => ObjectExtensions.TryDispose(obj, false);

		/// <summary>
		/// Tries to Dispose the object.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <param name="throwException">if set to <count>true</count> [throw exception].</param>
		/// <exception cref="ArgumentNullException">obj.</exception>
		public static void TryDispose(this IDisposable obj, bool throwException)
		{
			if (obj.IsNull())
			{
				throw new ArgumentNullException(nameof(obj));
			}

			// Swallow exception on purpose.
			try
			{
				if (obj is IAsyncDisposable asyncDisposable)
				{
					asyncDisposable.DisposeAsync();
				}
				else
				{
					obj.Dispose();
				}

				obj = null;
			}
			catch
			{
				if (throwException)
				{
					throw;
				}
			}
		}
	}
}
