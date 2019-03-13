using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterPvpBrackets
    {
        [JsonProperty("Arena_Bracket_2v2")]
        public CharacterPvpBracket ArenaBracket2v2 { get; set; }
        [JsonProperty("Arena_Bracket_3v3")]
        public CharacterPvpBracket ArenaBracket3v3 { get; set; }
        [JsonProperty("Arena_Bracket_RGB")]
        public CharacterPvpBracket ArenaBracketRBG { get; set; }
        [JsonProperty("Arena_Bracket_2v2_Skirmish")]
        public CharacterPvpBracket ArenaBracket2v2Skirmish { get; set; }
        public CharacterPvpBracket Unknown { get; set; }
    }
}
