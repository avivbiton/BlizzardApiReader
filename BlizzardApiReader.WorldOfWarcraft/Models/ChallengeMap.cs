using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class ChallengeMap
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public bool HasChallengeMode { get; set; }

        public ChallengeTime BronzeCriteria { get; set; }
        public ChallengeTime SilverCriteria { get; set; }
        public ChallengeTime GoldCriteria { get; set; }

    }
}
