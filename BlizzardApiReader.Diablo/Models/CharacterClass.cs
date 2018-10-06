using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class HeroClass
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("maleName")]
        public string MaleName { get; set; }

        [JsonProperty("femaleName")]
        public string FemaleName { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("skillCategories")]
        public List<HeroClassCategory> SkillCategories { get; set; }

        [JsonProperty("skills")]
        public HeroClassSkills Skills { get; set; }
    }

    public class HeroClassCategory
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HeroClassSkills
    {
        [JsonProperty("active")]
        public List<HeroClassSkill> Active { get; set; }

        [JsonProperty("passive")]
        public List<HeroClassSkill> Passive { get; set; }
    }

    public class HeroClassSkill
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("tooltipUrl")]
        public string TooltipUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("flavorText", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorText { get; set; }
    }
}
