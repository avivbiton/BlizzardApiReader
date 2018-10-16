namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Contains item information for all followers
    /// </summary>
    public class FollowerItemsExtended
    {
        public FollowerItems Templar { get; set; }
        public FollowerItems Scoundrel { get; set; }
        public FollowerItems Enchantress { get; set; }

        /// <summary>
        /// Equipment of a single follower
        /// </summary>
        public class FollowerItems
        {
            public ItemExtended Neck { get; set; }
            public ItemExtended LeftFinger { get; set; }
            public ItemExtended RightFinger { get; set; }
            public ItemExtended MainHand { get; set; }
            public ItemExtended OffHand { get; set; }
            public ItemExtended Special { get; set; }
        }
    }
}