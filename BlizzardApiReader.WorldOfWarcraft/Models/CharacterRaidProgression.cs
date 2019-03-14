using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterRaidProgression
    {
        public string Name { get; set; }
        public int Lfr { get; set; }
        public int Normal { get; set; }
        public int Heroic { get; set; }
        public int Mythic { get; set; }
        public int Id { get; set; }
        public CharacterRaidBossProgression[] Bosses { get; set; }        
    }
}
