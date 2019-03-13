using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterPetSlot
    {        
        public int Slot { get; set; }
        public string BattlePetGuid { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsLocked { get; set; }
        public int[] Abilities { get; set; }
        
    }
}
