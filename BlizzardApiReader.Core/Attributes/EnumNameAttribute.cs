using System;

namespace BlizzardApiReader.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumNameAttribute : Attribute
    {
        public EnumNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
