using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Talent
    {
        public int Tier { get; set; }
        public int Column { get; set; }
        public Spell Spell { get; set; }
        public Spec Spec { get; set; }
    }
}
