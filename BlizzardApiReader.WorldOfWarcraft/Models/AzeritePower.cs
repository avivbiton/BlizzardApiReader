using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class AzeritePower
    {
        public int Id { get; set; }
        public int Tier { get; set; }
        public int SpellId { get; set; }
        public int BonusListId { get; set; }
    }
}
