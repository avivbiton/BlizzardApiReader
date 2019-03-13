using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Quality { get; set; }
        public TooltipParams TooltipParams { get; set; }
        public ItemStat[] Stats { get; set; }
        public int Armor { get; set; }
        public WeaponInfo WeaponInfo { get; set; }
        public string Context { get; set; }
        public int[] BonusLists { get; set; }
        public int DisplayInfoId { get; set; }
        public int ArtifactId { get; set; }
        public int ArtifactAppearanceId { get; set; }
        public ArtifactTrait[] ArtifactTraits { get; set; }
        public Relic[] Relics { get; set; }
        public ItemAppearance Appearance { get; set; }
        public AzeriteItem AzeriteItem { get; set; }
        public AzeriteEmpoweredItem AzeriteEmpoweredItem { get; set; }

    }
}
