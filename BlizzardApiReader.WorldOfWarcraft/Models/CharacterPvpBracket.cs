using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterPvpBracket
    {
        public string Slug { get; set; }
        public int Rating { get; set; }
        public int WeeklyPlayed { get; set; }
        public int WeeklyWon { get; set; }
        public int WeeklyLost { get; set; }
        public int SeasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int SeasonLost { get; set; }
        public int Tier { get; set; }
    }
}
