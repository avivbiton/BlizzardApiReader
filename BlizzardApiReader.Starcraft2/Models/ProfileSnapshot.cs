using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class ProfileSnapshot
    {
        public Dictionary<string, Snapshot> SeasonSnapshot { get; set; }
        public int TotalRankedSeasonGamesPlayed { get; set; }
    }

    public class Snapshot
    {
        public int Rank { get; set; }
        public string LeagueName { get; set; }
        public int TotalGames { get; set; }
        public int TotalWins { get; set; }

    }

}
