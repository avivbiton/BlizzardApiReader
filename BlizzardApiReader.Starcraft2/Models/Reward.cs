using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Reward
    {
        public int Flags { get; set; }
        public string ID { get; set; }
        public long AchievementId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string UnlockableType { get; set; }
        public bool IsSkin { get; set; }
        public int UiOrderHint { get; set; }
    }
}
