using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class HunterPet
    {        
        public string Name { get; set; }
        public int Creature { get; set; }
        public int Slot { get; set; }
        public Spec Spec { get; set; }
        public string CalcSpec { get; set; }
        public int FamilyId { get; set; }
        public string FamilyName { get; set; }
        public bool Selected { get; set; }
        
    }
}
