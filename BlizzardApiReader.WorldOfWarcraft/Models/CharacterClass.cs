using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public int Mask { get; set; }
        public PowerType PowerType { get; set; }
        public string Name { get; set; }
    }

    public enum PowerType {
        Rage,
        Mana,
        Focus,
        Energy,
        [EnumMember(Value = "runic-power")]
        RunicPower,
        Fury
    }
}
