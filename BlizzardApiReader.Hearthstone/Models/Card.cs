namespace BlizzardApiReader.Hearthstone
{
    public class Card
    {
        public string Region { get; set; }
        public string Locale { get; set; }
        public string Set { get; set; }
        public string Class { get; set; }
        public int ManaCost { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public bool Collective { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
        public string MinionType { get; set; }
        public string KeyWord { get; set; }
        

    }
}