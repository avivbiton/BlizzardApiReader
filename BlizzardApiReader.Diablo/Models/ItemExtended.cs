using System.Collections.Generic;

namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Contains in-depth combat information about a single equippable item
    /// </summary>
    public class ItemExtended
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DisplayColor { get; set; }
        public string TooltipParams { get; set; }
        public int RequiredLevel { get; set; }
        public int ItemLevel { get; set; }
        public int StackSizeMax { get; set; }
        public bool AccountBound { get; set; }
        public string FlavorText { get; set; }
        public string TypeName { get; set; }
        public TypeClass Type { get; set; }
        public double Armor { get; set; }
        public string Damage { get; set; }
        public string Dps { get; set; }
        public double AttacksPerSecond { get; set; }
        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public string ElementalType { get; set; }
        public string Slots { get; set; }
        public string Augmentation { get; set; }
        public ItemAttributes Attributes { get; set; }
        public ItemAttributesHtml AttributesHtml { get; set; }
        public int OpenSockets { get; set; }
        public IList<Gem> Gems { get; set; }
        public ItemSet Set { get; set; }
        public int SeasonRequiredToDrop { get; set; }
        public TransmogrifiedItem Transmog { get; set; }
        public string BlockChance { get; set; }
        public bool IsSeasonRequiredToDrop { get; set; }

        /// <summary>
        /// General item information
        /// </summary>
        public class ItemDescription
        {
            public string Id { get; set; }
            public string Slug { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Path { get; set; }
        }

        /// <summary>
        /// Contains lists of an item's attributes
        /// </summary>
        public class ItemAttributes
        {
            public IList<string> Primary { get; set; }
            public IList<string> Secondary { get; set; }
        }

        /// <summary>
        /// Contains lists of an item's attributes in HTML form
        /// </summary>
        public class ItemAttributesHtml
        {
            public IList<string> Primary { get; set; }
            public IList<string> Secondary { get; set; }
        }

        /// <summary>
        /// Information about a socketable gem
        /// </summary>
        public class Gem
        {
            public ItemDescription Item { get; set; }
            public int JewelRank { get; set; }
            public int JewelSecondaryUnlockRank { get; set; }
            public IList<string> Attributes { get; set; }
            public bool IsGem { get; set; }
            public bool IsJewel { get; set; }
        }

        /// <summary>
        /// Information about an item set (green items in-game)
        /// </summary>
        public class ItemSet
        {
            public string Name { get; set; }
            public string Slug { get; set; }
            public string Description { get; set; }
            public string DescriptionHtml { get; set; }
        }

        /// <summary>
        /// Information about a source item of the transmogrification process
        /// </summary>
        public class TransmogrifiedItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string DisplayColor { get; set; }
            public string TooltipParams { get; set; }
        }

        /// <summary>
        /// A single reagent used for crafting
        /// </summary>
        public class Reagent
        {
            public int Quantity { get; set; }
            public ItemDescription Item { get; set; }
        }

        /// <summary>
        /// Item produced by crafting
        /// </summary>
        public class ItemProduced
        {
            public string Id { get; set; }
            public string Path { get; set; }
        }

        /// <summary>
        /// Information about a crafted item and its creator
        /// </summary>
        public class CraftedBy
        {
            public string Id { get; set; }
            public string Slug { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
            public IList<Reagent> Reagents { get; set; }
            public ItemProduced ItemProduced { get; set; }
        }
    }
}