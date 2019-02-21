using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class SwarmLevels
    {
        public int Level { get; set; }
        public SwarmLevel Terran { get; set; }
        public SwarmLevel Zerg { get; set; }
        public SwarmLevel Protoss { get; set; }
    }

    public class SwarmLevel
    {
        public int Level { get; set; }
        public int MaxLevelPoints { get; set; }
        public int CurrentLevelPoints { get; set; }
    }
}
