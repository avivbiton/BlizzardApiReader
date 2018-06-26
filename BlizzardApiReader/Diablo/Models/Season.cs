using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class Season
    {
        public int seasonId { get; set; }
        public int paragonLevel { get; set; }
        public int paragonLevelHardcore { get; set; }
        public Dictionary<string, long> kills { get; set; }
        public Dictionary<string, float> timePlayed { get; set; }
        public short highestHardcoreLevel { get; set; }

    }
}
