using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace dotNetTips.Utility.Standard.Extensions
{
    public static class EnumExtensions
    {
        public static T As<T>(this Enum val)
        {
            var enumType = val.GetType();
            var enumValue = Enum.Parse(enumType, val.ToString());
            return (T)enumValue;
        }

        public static T Parse<T>(this String name) where T : struct
        {
            return (T)Enum.Parse(typeof(T), name);
        }

        //public static String GetDescription(this Enum val)
        //{
        //    var field = val.GetType().GetField(val.ToString());
        //    var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
        //    return attributes.Length > 0 ? attributes[0].Description : val.ToString();
        //}

        //public static IList<EnumItem<T>> GetItems<T>(this Enum enumeration)
        //{
        //    var enumType = enumeration.GetType();
        //    var values = Enum.GetValues(enumType);
        //    var items = new List<EnumItem<T>>();
        //    foreach (var v in values)
        //    {
        //        var enumValue = Enum.Parse(enumType, v.ToString());
        //        items.Add(GetDescriptionInternal<T>(enumValue));
        //    }
        //    return items;
        //}

        //private static EnumItem<T> GetDescriptionInternal<T>(object val)
        //{
        //    var field = val.GetType().GetField(val.ToString());
        //    var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

        //    var enumItem = new EnumItem<T>
        //    {
        //        Description = attributes.Length > 0 ? attributes[0].Description : val.ToString(),
        //        Value = (T)val
        //    };
        //    return enumItem;
        //}
    }
}
