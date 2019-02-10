using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Ladder
    {
        public IList<LadderTeam> LadderTeams { get; set; }
        public IList<LadderMembership> AllLadderMemberships { get; set; }
        public IList<RanksAndPool> RanksAndPools { get; set; }

    }

    public class LadderTeam
    {
    }

    public class RanksAndPool
    {
    }
}
