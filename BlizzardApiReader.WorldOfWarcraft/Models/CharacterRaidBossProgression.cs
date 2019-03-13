using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterRaidBossProgression
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LfrKills { get; set; }
        public long LfrTimestamp { get; set; }
        public int NormalKills { get; set; }
        public long NormalTimestamp { get; set; }
        public int HeroicKills { get; set; }
        public long HeroicTimestamp { get; set; }
        public int MythicKills { get; set; }
        public long MythicTimestamp { get; set; }

    }
}
