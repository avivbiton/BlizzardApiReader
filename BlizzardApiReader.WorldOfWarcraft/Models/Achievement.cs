using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Achievement
    {
        public int id { get; set; }
        public string title { get; set; }
        public int points { get; set; }
        public string description { get; set; }
        public string reward { get; set; }
        public RewardItem[] rewardItems { get; set; }
        public string icon { get; set; }
        public Criteria[] criteria { get; set; }
        public bool accountWide { get; set; }
        public int factionId { get; set; }
    }
}
