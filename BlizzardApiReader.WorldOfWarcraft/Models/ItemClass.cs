using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class ItemClass
    {
        public int Class { get; set; }
        public string Name { get; set; }
        public ItemSubClass[] Subclasses { get; set; }
    }

    public class ItemSubClass
    {
        public int SubClass { get; set; }
        public string Name { get; set; }        
    }
}
