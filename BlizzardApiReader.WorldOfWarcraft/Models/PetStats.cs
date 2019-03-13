using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class PetStats
    {        
        public int SpeciesId { get; set; }
        public int BreedId { get; set; }
        public int PetQualityId { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        
    }
}
