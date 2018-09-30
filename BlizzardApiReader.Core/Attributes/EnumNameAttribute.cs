using System;

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
}
