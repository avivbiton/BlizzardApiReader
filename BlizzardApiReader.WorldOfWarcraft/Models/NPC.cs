using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class NPC
    {
        public int id { get; set; }
        public string name { get; set; }
        public string urlSlug { get; set; }
        public int creatureDisplayId { get; set; }
    }
}
