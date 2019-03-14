using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterPets
    {
        public int NumCollected { get; set; }
        public int NumNotCollected { get; set; }
        public Pet[] Collected { get; set; }
       
    }
}
