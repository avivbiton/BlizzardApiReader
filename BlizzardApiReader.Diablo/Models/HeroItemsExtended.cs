namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Combat information about all equipped hero's items
    /// </summary>
    public class HeroItemsExtended
    {
        public ItemExtended Head { get; set; }
        public ItemExtended Neck { get; set; }
        public ItemExtended Torso { get; set; }
        public ItemExtended Shoulders { get; set; }
        public ItemExtended Legs { get; set; }
        public ItemExtended Waist { get; set; }
        public ItemExtended Hands { get; set; }
        public ItemExtended Bracers { get; set; }
        public ItemExtended Feet { get; set; }
        public ItemExtended LeftFinger { get; set; }
        public ItemExtended RightFinger { get; set; }
        public ItemExtended MainHand { get; set; }
        public ItemExtended OffHand { get; set; }
    }
}