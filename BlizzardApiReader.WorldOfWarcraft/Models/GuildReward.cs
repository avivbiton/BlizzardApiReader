using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class GuildReward
    {
        public int MinGuildLevel { get; set; }
        public int MinGuildRepLevel { get; set; }
        public Achievement Achievement { get; set; }
        public Item Item { get; set; }
        public int[] Races { get; set; }
    }
}
