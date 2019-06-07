using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterRace
    {
        public int Id { get; set; }
        public int Mask { get; set; }
        public Side Side { get; set; }
        public string Name { get; set; }
    }

    public enum Side { Alliance, Horde, Neutral };


}
