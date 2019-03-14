using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Rank { get; set; }
        public int Max { get; set; }
        public int[] Recipes { get; set; }
        
    }
}
