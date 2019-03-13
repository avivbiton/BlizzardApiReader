using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Guild
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string BattleGroup { get; set; }
        public int AchievementPoints { get; set; }
        public GuildEmblem Emblem { get; set; }

        public int Level { get; set; }
        public int Side { get; set; }
             
        public GuildMember[] Members { get; set; }

        //Field=achievements
        public Achievements Achievements { get; set; }

        //Field=news
        public GuildNewsItem[] News { get; set; }
    }    
}
