using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterTalent
    {
        public bool Selected { get; set; }
        public Talent[] Talents { get; set; }
        public Spec Spec { get; set; }
        public string CalcTalent { get; set; }
        public string CalcSpec { get; set; }
    }
}
