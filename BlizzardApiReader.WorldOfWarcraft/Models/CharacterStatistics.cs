using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterStatistics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        //TODO: Date format
        public long LastUpdated { get; set; }
        public bool Money { get; set; }

    }
}
