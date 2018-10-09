using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class HeroClass
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string MaleName { get; set; }
        public string FemaleName { get; set; }
        public string Icon { get; set; }
        public List<HeroClassCategory> SkillCategories { get; set; }
        public HeroClassSkills Skills { get; set; }
    }

    public class HeroClassCategory
    {
        public string Slug { get; set; }
        public string Name { get; set; }
    }

    public class HeroClassSkills
    {
        public List<HeroClassSkill> Active { get; set; }
        public List<HeroClassSkill> Passive { get; set; }
    }

    public class HeroClassSkill
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public long Level { get; set; }
        public string TooltipUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorText { get; set; }
    }
}
