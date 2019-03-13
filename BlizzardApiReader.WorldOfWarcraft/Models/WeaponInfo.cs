using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class WeaponInfo
    {
        public Damage Damage { get; set; }
        public double WeaponSpeed { get; set; }
        public double Dps { get; set; }        
    }

    public class Damage
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public double ExactMin { get; set; }
        public double ExactMax { get; set; }
    }
}
