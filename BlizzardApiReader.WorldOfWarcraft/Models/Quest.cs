using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Quest
    {
        public int id { get; set; }
        public string title { get; set; }
        public int reqLevel { get; set; }
        public int suggestedPartyMembers { get; set; }
        public string category { get; set; }
        public int level { get; set; }
    }
}
