using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Criteria
    {
        public string AchievementId { get; set; }
        public string Description { get; set; }
        public string EvaluationClass { get; set; }
        public int Flags { get; set; }
        public long ID { get; set; }
        public int NecessaryQuantity { get; set; }
        public int UiOrderHint { get; set; }

    }
}
