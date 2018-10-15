namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Contains item information for all followers
    /// </summary>
    public class ProfileHeroFollowerItems
    {
        public FollowerItems Templar { get; set; }
        public FollowerItems Scoundrel { get; set; }
        public FollowerItems Enchantress { get; set; }

        /// <summary>
        /// Equipment of a single follower
        /// </summary>
        public class FollowerItems
        {
            public ProfileItem Neck { get; set; }
            public ProfileItem LeftFinger { get; set; }
            public ProfileItem RightFinger { get; set; }
            public ProfileItem MainHand { get; set; }
            public ProfileItem OffHand { get; set; }
            public ProfileItem Special { get; set; }
        }
    }
}