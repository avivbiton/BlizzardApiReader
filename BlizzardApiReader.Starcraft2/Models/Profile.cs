using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Profile
    {
        public ProfileSummary Summary { get; set; }
        public ProfilleSnapshot Snapshot { get; set; }
        public Career Career { get; set; }
        public SwarmLevels SwarmLevels { get; set; }
        public Campaign Campaign { get; set; }
        public IList<Category> CategoryPointProgress { get; set; }
        //public AchievementShowcase AchievementShowcase { get; set; }
        public IList<Reward> EarnedRewards { get; set; }
        public IList<EarnedAchievement> EarnedAchievements { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public int PointsEarned { get; set; }
    }

    public class Reward
    {
        public long RewardId { get; set; }
        public bool Selected { get; set; }
        public string Category { get; set; }
        public long AchievementId { get; set; }

    }

    public class EarnedAchievement
    {
        public string AchievementId { get; set; }
        public string CompletionDate { get; set; } //handle -9223372036854776000 value
        public int NumCompletedAchievementsInSeries { get; set; }
        public int TotalAchievementsInSeries { get; set; }
        public bool IsComplete { get; set; }
        public bool InProgress { get; set; }
        public IList<Criteria> EarnedRewards { get; set; }

    }

    public class Criteria
    {
        public string CriterionId { get; set; }
        public Earned Earned { get; set; }
    }

    public class Earned
    {
        public int Quantity { get; set; }
        public string StartTime { get; set; } //handle -9223372036854776000 value
    }
}
