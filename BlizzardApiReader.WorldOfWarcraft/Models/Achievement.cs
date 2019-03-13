using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
        public string Description { get; set; }
        public string Reward { get; set; }
        public CharacterItem[] RewardItems { get; set; }
        public string Icon { get; set; }
        public Criteria[] Criteria { get; set; }
        public bool AccountWide { get; set; }
        public int FactionId { get; set; }
    }
}
