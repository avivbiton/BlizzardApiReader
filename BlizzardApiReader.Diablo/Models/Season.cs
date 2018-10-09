using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public int ParagonLevel { get; set; }
        public int ParagonLevelHardcore { get; set; }
        public Dictionary<string, long> Kills { get; set; }
        public Dictionary<string, float> TimePlayed { get; set; }
        public short HighestHardcoreLevel { get; set; }

    }
}
