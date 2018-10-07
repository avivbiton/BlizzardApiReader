using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Boss
    {
        public int id { get; set; }
        public string name { get; set; }
        public string urlSlug { get; set; }
        public string description { get; set; }
        public int zoneId { get; set; }
        public bool availableInNormalMode { get; set; }
        public bool availableInHeroicMode { get; set; }
        public int health { get; set; }
        public int heroicHealth { get; set; }
        public int level { get; set; }
        public int heroicLevel { get; set; }
        public int journalId { get; set; }
        public NPC[] npcs { get; set; }
    }
}
