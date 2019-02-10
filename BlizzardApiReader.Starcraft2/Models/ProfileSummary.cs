using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class ProfileSummary
    {
        public int ID { get; set; }
        public int RealmID { get; set; }
        public string DisplayName { get; set; }
        public string Portrait { get; set; }
        public string DecalTerran { get; set; }
        public string DecalProtoss { get; set; }
        public string DecalZerg { get; set; }
        public int TotalSwarmLevel { get; set; }
        public int TotalAchievementPoints { get; set; }


    }
}
