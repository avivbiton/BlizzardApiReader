using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Career
    {
        public int TerranWins { get; set; }
        public int ZergWins { get; set; }
        public int ProtossWins { get; set; }
        public int TotalCareerGames { get; set; }
        public int TotalGamesThisSeason { get; set; }
        public string Current1v1LeagueName { get; set; }
        public string CurrentBestTeamLeagueName { get; set; }
        public Finish Best1v1Finish { get; set; }
        public Finish BestTeamFinish { get; set; }
    }

    public class Finish
    {
        public string LeagueName { get; set; }
        public int TimesAchieved { get; set; }
    }
}
