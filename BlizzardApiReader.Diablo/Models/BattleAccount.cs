using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class BattleAccount
    {
        public string BattleTag { get; set; }
        public int ParagonLevel { get; set; }
        public int ParagonLevelHardcore { get; set; }
        public int ParagonLevelSeason { get; set; }
        public int ParagonLevelSeasonHardcore { get; set; }
        public string GuildName { get; set; }
        public List<Hero> Heroes { get; set; }
        public long LastHeroPlayed { get; set; }
        public long LastUpdated { get; set; }
        public Dictionary<string, long> Kills { get; set; }
        public short HighestHardcoreLevel { get; set; }
        public Dictionary<string, float> TimePlayed { get; set; }
        public Dictionary<string, bool> Progression { get; set; }
        public List<Hero> FallenHeroes { get; set; }
        public Dictionary<string, Season> SeasonalProfiles { get; set; }

        public Artisan Blacksmith { get; set; }
        public Artisan Jeweler { get; set; }
        public Artisan Mystic { get; set; }
        public Artisan BlacksmithSeason { get; set; }
        public Artisan JewelerSeason { get; set; }
        public Artisan MysticSeason { get; set; }
        public Artisan BlacksmithHardcore { get; set; }
        public Artisan JewelerHardcore { get; set; }
        public Artisan MysticHardcore { get; set; }

        public Artisan BlacksmithSeasonHardcore { get; set; }
        public Artisan JewelerSeasonHardcore { get; set; }
        public Artisan MysticSeasonHardcore { get; set; }
    }
}
