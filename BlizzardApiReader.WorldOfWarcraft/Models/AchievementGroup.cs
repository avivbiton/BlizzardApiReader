using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class AchievementGroup
    {

        public int Id { get; set; }
        public Achievement[] Achievements { get; set; }
        public string Name { get; set; }
        public AchievementGroup[] Categories { get; set; }
    }
}
