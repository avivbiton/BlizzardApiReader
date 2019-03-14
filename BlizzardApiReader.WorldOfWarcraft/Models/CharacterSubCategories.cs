using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterSubCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CharacterSubCategories[] SubCategories { get; set; }
        public CharacterStatistics[] Statistics { get; set; }

    }
}
