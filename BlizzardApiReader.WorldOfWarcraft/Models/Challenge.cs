﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Challenge
    {
        public Realm Realm { get; set; }

        public ChallengeMap Map { get; set; }

        public List<ChallengeGroup> Groups { get; set; }

    }
}
