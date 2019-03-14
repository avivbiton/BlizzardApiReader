using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class GuildNewsItem
    {
        
        public string Type { get; set; }
        public string Character { get; set; }

        //TODO: Review the formating of timestamp
        public long Timestamp { get; set; }
        public string context { get; set; }
        public int[] BonusLists { get; set; }
        
        //Type: playerAchievement
        public Achievement Achievement { get; set; }

        //Type: itemLoot, itemPurchase, itemCraft
        public int ItemId { get; set; }
    }
}
