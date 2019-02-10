using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{

    public class GrandmasterLeaderboard
    {
        public IList<TeamMember> TeamMembers { get; set; }
        public int PreviousRank { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int MMR { get; set; }
        public long JoinTimestamp { get; set; }

    }

    public class TeamMember
    {
        public int ID { get; set; }
        public int Realm { get; set; }
        public int Region { get; set; }
        public string DisplayName { get; set; }
        public string favoriteRace { get; set; }

    }

}
