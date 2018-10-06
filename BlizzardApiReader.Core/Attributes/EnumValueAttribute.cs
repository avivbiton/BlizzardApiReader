using System;

namespace BlizzardApiReader.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumValueAttribute : Attribute
    {
        public EnumValueAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
