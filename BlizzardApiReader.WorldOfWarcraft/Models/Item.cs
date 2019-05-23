using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Item
    {        

    public long Id { get; set; }
    public long DisenchantingSkillRank { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public long Stackable { get; set; }
    public long ItemBind { get; set; }
    public ItemStat[] BonusStats { get; set; }
    public object[] ItemSpells { get; set; }
    public long BuyPrice { get; set; }
    public long ItemClass { get; set; }
    public long ItemSubClass { get; set; }
    public long ContainerSlots { get; set; }
    public WeaponInfo WeaponInfo { get; set; }
    public long InventoryType { get; set; }
    public bool Equippable { get; set; }
    public long ItemLevel { get; set; }
    public long MaxCount { get; set; }
    public long MaxDurability { get; set; }
    public long MinFactionId { get; set; }
    public long MinReputation { get; set; }
    public long Quality { get; set; }
    public long SellPrice { get; set; }
    public long RequiredSkill { get; set; }
    public long RequiredLevel { get; set; }
    public long RequiredSkillRank { get; set; }
    public ItemSource ItemSource { get; set; }
    public long BaseArmor { get; set; }
    public bool HasSockets { get; set; }
    public bool IsAuctionable { get; set; }
    public long Armor { get; set; }
    public long DisplayInfoId { get; set; }
    public string NameDescription { get; set; }
    public string NameDescriptionColor { get; set; }
    public bool Upgradable { get; set; }
    public bool HeroicTooltip { get; set; }
    public string Context { get; set; }
    public object[] BonusLists { get; set; }
    public string[] AvailableContexts { get; set; }
    public ItemBonusSummary BonusSummary { get; set; }
    public long ArtifactId { get; set; }
}
}