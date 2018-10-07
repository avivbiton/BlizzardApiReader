using BlizzardApiReader.Core.Attributes;
using System;
using System.Reflection;

namespace BlizzardApiReader.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumValue<TEnum>(this TEnum value) 
        {
            Type type = typeof(TEnum);
            var field = type.GetField(value.ToString());
            var attr = field.GetCustomAttribute(typeof(EnumValueAttribute)) as EnumValueAttribute;

            return attr?.Name ?? value.ToString();
        }
    }
}
