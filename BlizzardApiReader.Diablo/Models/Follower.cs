using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class Follower
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realName")]
        public string RealName { get; set; }

        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        [JsonProperty("skills")]
        public List<Skill> Skills { get; set; }
    }

    public class Skill
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
