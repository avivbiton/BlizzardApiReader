using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Range { get; set; }
        public string PowerCost { get; set; }
        public string CastTime { get; set; }
        public string Cooldown { get; set; }
    }
}
