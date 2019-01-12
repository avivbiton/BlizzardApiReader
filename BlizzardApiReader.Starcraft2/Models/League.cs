using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class League
    {
        public Key Key { get; set; }
        public IEnumerable<Tier> Tiers { get; set; }
       
    }

    public class Key
    {
        public long league_id { get; set; }
        public long season_id { get; set; }
        public long queue_id { get; set; }
        public long team_type { get; set; }
    }


    public class Tier
    {
        public long id { get; set; }
        public Division division { get; set; }

    }


    public class Division
    {
        public long ID { get; set; }
        public long ladderid { get; set; }
        public long member_count { get; set; }
    }
}
