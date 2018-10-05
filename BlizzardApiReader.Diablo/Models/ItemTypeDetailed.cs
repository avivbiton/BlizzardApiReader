using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class ItemTypeDetailed
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
