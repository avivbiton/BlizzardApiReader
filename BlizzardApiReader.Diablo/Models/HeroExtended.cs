using System.Collections.Generic;

namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Contains information about player's hero profile - his/her gameplay statistics, chosen skills, equipped items and followers.
    /// </summary>
    public class HeroExtended
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Gender { get; set; }
        public int Level { get; set; }
        public int ParagonLevel { get; set; }
        public Dictionary<string, long> Kills { get; set; }
        public bool Hardcore { get; set; }
        public bool Seasonal { get; set; }
        public int SeasonCreated { get; set; }
        public HeroSkills Skills { get; set; }
        public HeroEquippedItems Items { get; set; }
        public HeroFollowers Followers { get; set; }
        public IList<HeroItem> LegendaryPowers { get; set; }
        public ProgressionDetail Progression { get; set; }
        public bool Alive { get; set; }
        public int LastUpdated { get; set; }
        public int HighestSoloRiftCompleted { get; set; }
        public HeroStats Stats { get; set; }

        /// <summary>
        /// Contains information about a single active skill and its rune
        /// </summary>
        public class ActiveSkillDetail
        {
            public ActiveSkill Skill { get; set; }
            public Rune Rune { get; set; }
        }

        /// <summary>
        /// Contains information about a single passive skill
        /// </summary>
        public class PassiveSkillDetail
        {
            public PassiveSkill Skill { get; set; }
        }

        /// <summary>
        /// Detailed information about an active skill
        /// </summary>
        public class ActiveSkill
        {
            public string Slug { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public long Level { get; set; }
            public string TooltipUrl { get; set; }
            public string Description { get; set; }
            public string DescriptionHtml { get; set; }
        }

        /// <summary>
        /// Detailed information about a rune
        /// </summary>
        public class Rune
        {
            public string Slug { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public string Description { get; set; }
            public string DescriptionHtml { get; set; }
        }

        /// <summary>
        /// Detailed information about a passive skill
        /// </summary>
        public class PassiveSkill
        {
            public string Slug { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public long Level { get; set; }
            public string TooltipUrl { get; set; }
            public string Description { get; set; }
            public string DescriptionHtml { get; set; }
            public string FlavorText { get; set; }
        }

        /// <summary>
        /// All hero's learned passive and active skills
        /// </summary>
        public class HeroSkills
        {
            public IList<ActiveSkillDetail> Active { get; set; }
            public IList<PassiveSkillDetail> Passive { get; set; }
        }

        /// <summary>
        /// Non-combat information about hero's item
        /// </summary>
        public class HeroItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string DisplayColor { get; set; }
            public string TooltipParams { get; set; }
            public HeroItem TransmogItem { get; set; }
        }

        /// <summary>
        /// All hero's equipped items
        /// </summary>
        public class HeroEquippedItems
        {
            public HeroItem Head { get; set; }
            public HeroItem Neck { get; set; }
            public HeroItem Torso { get; set; }
            public HeroItem Shoulders { get; set; }
            public HeroItem Legs { get; set; }
            public HeroItem Waist { get; set; }
            public HeroItem Hands { get; set; }
            public HeroItem Bracers { get; set; }
            public HeroItem Feet { get; set; }
            public HeroItem LeftFinger { get; set; }
            public HeroItem RightFinger { get; set; }
            public HeroItem MainHand { get; set; }
            public HeroItem OffHand { get; set; }
        }

        /// <summary>
        /// Stats of a follower
        /// </summary>
        public class FollowerStats
        {
            public double GoldFind { get; set; }
            public double MagicFind { get; set; }
            public double ExperienceBonus { get; set; }
        }

        /// <summary>
        /// All items for a single follower
        /// </summary>
        public class FollowerItems
        {
            // Special follower item missing in this API endpoint
            public HeroItem Neck { get; set; }
            public HeroItem LeftFinger { get; set; }
            public HeroItem RightFinger { get; set; }
            public HeroItem MainHand { get; set; }
            public HeroItem OffHand { get; set; }
        }

        /// <summary>
        /// Information about a single follower
        /// </summary>
        public class Follower
        {
            public string Slug { get; set; }
            public int Level { get; set; }
            public FollowerItems Items { get; set; }
            public FollowerStats Stats { get; set; }
            public IList<ActiveSkill> Skills { get; set; }
        }

        /// <summary>
        /// Information about all hero's followers
        /// </summary>
        public class HeroFollowers
        {
            public Follower Templar { get; set; }
            public Follower Scoundrel { get; set; }
            public Follower Enchantress { get; set; }
        }

        /// <summary>
        /// Information about a single act progress
        /// </summary>
        public class Act
        {
            public bool Completed { get; set; }
            public IList<Quest> CompletedQuests { get; set; }
        }

        /// <summary>
        /// Information about a hero's full gameplay progress
        /// </summary>
        public class ProgressionDetail
        {
            public Act Act1 { get; set; }
            public Act Act2 { get; set; }
            public Act Act3 { get; set; }
            public Act Act4 { get; set; }
            public Act Act5 { get; set; }
        }

        /// <summary>
        /// All hero's combat stats 
        /// </summary>
        public class HeroStats
        {
            public double Life { get; set; }
            public double Damage { get; set; }
            public double Toughness { get; set; }
            public double Healing { get; set; }
            public double AttackSpeed { get; set; }
            public double Armor { get; set; }
            public double Strength { get; set; }
            public double Dexterity { get; set; }
            public double Vitality { get; set; }
            public double Intelligence { get; set; }
            public double PhysicalResist { get; set; }
            public double FireResist { get; set; }
            public double ColdResist { get; set; }
            public double LightningResist { get; set; }
            public double PoisonResist { get; set; }
            public double ArcaneResist { get; set; }
            public double BlockChance { get; set; }
            public double BlockAmountMin { get; set; }
            public double BlockAmountMax { get; set; }
            public double GoldFind { get; set; }
            public double CritChance { get; set; }
            public double Thorns { get; set; }
            public double LifeSteal { get; set; }
            public double LifePerKill { get; set; }
            public double LifeOnHit { get; set; }
            public double PrimaryResource { get; set; }
            public double SecondaryResource { get; set; }
        }
    }
}
