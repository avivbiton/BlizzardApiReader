using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class CharacterFeedItem
    {
        //Type: ACHIEVEMENT
        public string Type { get; set; }
        //TODO: Review the formating of timestamp
        public long Timestamp { get; set; }
        public Achievement Achievement { get; set; }
        public bool FeatOfStrength { get; set; }

        //Type: CRITERIA
        public Criteria Criteria { get; set; }

        //Type: BOSSKILL
        public int Quantity { get; set; }
        public string Name { get; set; }

        //Type: LOOT
        public int ItemId { get; set; }
        public string context { get; set; }
        public int[] BonusLists { get; set; }

    }
}
