using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Relic
    {
        public int Socket { get; set; }
        public int ItemId { get; set; }
        public int context { get; set; }
        public int[] BonusLists { get; set; }        
    }
}
