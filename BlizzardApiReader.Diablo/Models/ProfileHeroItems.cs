namespace BlizzardApiReader.Diablo.Models
{
    /// <summary>
    /// Combat information about all equipped hero's items
    /// </summary>
    public class ProfileHeroItems
    {
        public ProfileItem Head { get; set; }
        public ProfileItem Neck { get; set; }
        public ProfileItem Torso { get; set; }
        public ProfileItem Shoulders { get; set; }
        public ProfileItem Legs { get; set; }
        public ProfileItem Waist { get; set; }
        public ProfileItem Hands { get; set; }
        public ProfileItem Bracers { get; set; }
        public ProfileItem Feet { get; set; }
        public ProfileItem LeftFinger { get; set; }
        public ProfileItem RightFinger { get; set; }
        public ProfileItem MainHand { get; set; }
        public ProfileItem OffHand { get; set; }
    }
}