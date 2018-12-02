using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class ChallengeGroup
    {
        public int Ranking { get; set; }

        public ChallengeTime Time { get; set; }

        public DateTime Date { get; set; }

        public string Faction { get; set; }

        public bool IsRecurring { get; set; }

        public List<GroupMember> Members { get; set; }
    }
}
