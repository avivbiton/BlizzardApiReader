using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Static
    {
        public IList<Achievement> Achievements { get; set; }
        public IList<Criteria> Criteria { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Reward> Rewards { get; set; }

    }
}
