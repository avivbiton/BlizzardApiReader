using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardApiReader.Diablo.Models
{
    public class Hero
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("class")]
        public string ClassName { get; set; }
        public string ClassSlug { get; set; }
        public short Gender { get; set; }
        public short Level { get; set; }
        public Dictionary<string, long> Kills { get; set; }
        public int ParagonLevels { get; set; }
        public bool Hardcore { get; set; }
        public bool Seasonal { get; set; }
        public bool Dead { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public long LastUpdated { get; set; }

    }


}
