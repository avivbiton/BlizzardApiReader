using System;
using System.Collections.Generic;
using System.Text;
using BlizzardApiReader.WorldOfWarcraft.Enums;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public bool CanBattle { get; set; }
        public int CreatureId { get; set; }
        public int ItemId { get; set; }
        public int QualityId { get; set; }
        public string Icon { get; set; }
        public PetStats Stats { get; set; }

        //From Character Pet List
        public int SpellId { get; set; }
        public string BattlePetGuid { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsFirstAbilitySlotSelected { get; set; }
        public bool IsSecondAbilitySlotSelected { get; set; }
        public bool IsThirdAbilitySlotSelected { get; set; }
        public string CreatureName { get; set; }
        

        //From Pets API
        public PetFamily Family { get; set; }
        public PetFamily[] StrongAgainst { get; set; }
        public PetFamily[] WeakAgainst { get; set; }
        public long TypeId { get; set; }
    

    }
}
