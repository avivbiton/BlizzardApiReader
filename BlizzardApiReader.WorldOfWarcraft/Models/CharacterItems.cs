using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterItems
    {
        public int AverageItemLevel { get; set; }
        public int AverageItemLevelEquipped { get; set; }
        public CharacterItem Head { get; set; }
        public CharacterItem Neck { get; set; }
        public CharacterItem Shoulder { get; set; }
        public CharacterItem Back { get; set; }
        public CharacterItem Chest { get; set; }
        public CharacterItem Shirt { get; set; }
        public CharacterItem Tabard { get; set; }
        public CharacterItem Wrist { get; set; }
        public CharacterItem Hands { get; set; }
        public CharacterItem Waist { get; set; }
        public CharacterItem Legs { get; set; }
        public CharacterItem Feet { get; set; }
        public CharacterItem Finger1 { get; set; }
        public CharacterItem Finger2 { get; set; }
        public CharacterItem Trinket1 { get; set; }
        public CharacterItem Trinket2 { get; set; }
        public CharacterItem MainHand { get; set; }

    }
}
