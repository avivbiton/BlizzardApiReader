using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class HeroClassSkillInformation
    {
        [JsonProperty("skill")]
        public HeroClassSkillInformationSkill Skill { get; set; }

        [JsonProperty("runes")]
        public List<HeroClassSkillInformationRune> Runes { get; set; }
    }

    public class HeroClassSkillInformationRune
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionHtml")]
        public string DescriptionHtml { get; set; }
    }

    public class HeroClassSkillInformationSkill
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
    }
}
