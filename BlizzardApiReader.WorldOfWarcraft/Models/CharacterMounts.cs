using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterMounts
    {
        public int NumCollected { get; set; }
        public int NumNotCollected { get; set; }
        public Mount[] Collected { get; set; }
       
    }
}
