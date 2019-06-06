using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public int ExpansionId { get; set; }
        public ZoneSize NumPlayers { get; set; }
        public bool IsDungeon { get; set; }
        public bool IsRaid { get; set; }
        public int AdvisedMinLevel { get; set; }
        public int AdvisedMaxLevel { get; set; }
        public int AdvisedHeroicMinLevel { get; set; }
        public int AdvisedHeroicMaxLevel { get; set; }        
        public AvailableMode[] AvailableModes { get; set; }
        public int LfgNormalMinGearLevel { get; set; }
        public int LfgHeroicMinGearLevel { get; set; }
        public int Floors { get; set; }
        public Boss[] Bosses { get; set; }
        public string Patch { get; set; }
    }
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvailableMode {
        [EnumMember(Value = "Dungeon_Heroic")]
        DungeonHeroic,
        [EnumMember(Value = "Dungeon_Mythic")]
        DungeonMythic,
        [EnumMember(Value = "Dungeon_Normal")]
        DungeonNormal,
        [EnumMember(Value = "Legacy_Raid_40")]
        LegacyRaid40,
        [EnumMember(Value = "Raid_10_Heroic")]
        Raid10Heroic,
        [EnumMember(Value = "Raid_10_Normal")]
        Raid10Normal,
        [EnumMember(Value = "Raid_25_Heroic")]
        Raid25Heroic,
        [EnumMember(Value = "Raid_25_Normal")]
        Raid25Normal,
        [EnumMember(Value = "Raid_Flex_Heroic")]
        RaidFlexHeroic,
        [EnumMember(Value = "Raid_Flex_Lfr")]
        RaidFlexLfr,
        [EnumMember(Value = "Raid_Flex_Normal")]
        RaidFlexNormal,
        [EnumMember(Value = "Raid_Lfr")]
        RaidLfr,
        [EnumMember(Value = "Raid_Mythic")]
        RaidMythic
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ZoneSize
    {
        [EnumMember(Value = "5")]
        Five,
        [EnumMember(Value = "10/25")]
        Ten_TwentyFive,
        [EnumMember(Value = "10-30")]
        Ten_Thirty
    }
}
