using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class ProfilleSnapshot
    {
        public SeasonSnapshot SeasonSnapshot { get; set; }
        public int TotalRankedSeasonGamesPlayed { get; set; }
    }

    public class SeasonSnapshot
    {
        [JsonProperty("1v1")]
        public Snapshot OnevOne { get; set; }
        [JsonProperty("2v2")]
        public Snapshot TwovTwo { get; set; }
        [JsonProperty("3v3")]
        public Snapshot ThreevThree { get; set; }
        [JsonProperty("4v4")]
        public Snapshot FourvFour { get; set; }
        public Snapshot Archon { get; set; }
    }

    public class Snapshot
    {
        public int Rank { get; set; }
        public string LeagueName { get; set; }
        public int TotalGames { get; set; }
        public int TotalWins { get; set; }

    }

}
