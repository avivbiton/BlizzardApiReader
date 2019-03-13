using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterReputation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standing { get; set; }
        public int Value { get; set; }
        public int Max { get; set; }
        
    }
}
