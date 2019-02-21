using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Achievement
    {
        public int CategoryId { get; set; }
        public IList<long> ChainAchievementIDs { get; set; }
        public int ChainRewardSize { get; set; }
        public IList<long> CriteriaIds { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public long ID { get; set; }
        public string ImageUrl { get; set; }
        public bool IsChained { get; set; }
        public int Points { get; set; }
        public string Title { get; set; }
        public int UiOrderHint { get; set; }

    }
}
