using BlizzardApiReader.Core.Attributes;
using System;
using System.Reflection;

namespace BlizzardApiReader.Core.Extensions
{
    public static class EnumNameAttributeExtensions
    {
        public static string GetEnumName<TEnum>(this TEnum value) where TEnum : Enum
        {
            Type type = typeof(TEnum);
            var field = type.GetField(value.ToString());
            var attr = field.GetCustomAttribute(typeof(EnumNameAttribute)) as EnumNameAttribute;

            return attr?.Name ?? value.ToString();
        }
    }
}
