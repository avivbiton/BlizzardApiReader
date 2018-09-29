using System;
using System.Reflection;

namespace BlizzardApiReader.Core.Attributes
{
    public class EnumNameAttribute : Attribute
    {
        public EnumNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public static class EnumNameAttributeExtensions
    {
        public static string GetEnumName<TEnum>(this TEnum value) where TEnum : Enum
        {
            Type type = typeof(TEnum);
            var field = type.GetField(value.ToString());
            var attr = field.GetCustomAttribute(typeof(EnumNameAttribute)) as EnumNameAttribute;

            return attr?.Name;
        }
    }
}
