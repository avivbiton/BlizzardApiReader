using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class BattleAccount
    {
        public string battleTag { get; set; }
        public int paragonLevel { get; set; }
        public int paragonLevelHardcore { get; set; }
        public int paragonLevelSeason { get; set; }
        public int paragonLevelSeasonHardcore { get; set; }
        public string guildName { get; set; }
        public List<Hero> heroes { get; set; }
        public long lastHeroPlayed { get; set; }
        public long lastUpdated { get; set; }
        public Dictionary<string, long> kills { get; set; }
        public short highestHardcoreLevel { get; set; }
        public Dictionary<string, float> timePlayed { get; set; }
        public Dictionary<string, bool> progression { get; set; }
        public List<Hero> fallenHeroes { get; set; }
        public Dictionary<string, Season> seasonalProfiles { get; set; }

        public Artisan blacksmith { get; set; }
        public Artisan jeweler { get; set; }
        public Artisan mystic { get; set; }
        public Artisan blacksmithSeason { get; set; }
        public Artisan jewelerSeason { get; set; }
        public Artisan mysticSeason { get; set; }
        public Artisan blacksmithHardcore { get; set; }
        public Artisan jewelerHardcore { get; set; }
        public Artisan mysticHardcore { get; set; }

        public Artisan blacksmithSeasonHardcore { get; set; }
        public Artisan jewelerSeasonHardcore { get; set; }
        public Artisan mysticSeasonHardcore { get; set; }
    }
}
