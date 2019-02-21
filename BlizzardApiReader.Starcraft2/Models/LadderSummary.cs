using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class LadderSummary
    {
        public IList<ShowCaseEntry> ShowCaseEntries { get; set; }
        public IList<PlacementMatch> PlacementMatches { get; set; }
        public IList<LadderMembership> AllLadderMemberships { get; set; }

    }

    public class ShowCaseEntry
    {
    }

    public class PlacementMatch
    {
    }
}
