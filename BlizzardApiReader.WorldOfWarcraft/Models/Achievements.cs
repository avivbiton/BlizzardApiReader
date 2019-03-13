using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Achievements
    {
        public int[] AchievementsCompleted { get; set; }

        public long[] AchievementsCompletedTimestamp { get; set; }

        public int[] Criteria { get; set; }

        public long[] CriteriaQuantity { get; set; }
        public long[] CriteriaTimestamp { get; set; }

        public long[] CriteriaCreated { get; set; }

    }
}
