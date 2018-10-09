using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Realm
    {
        public string Type { get; set; }
        public string Population { get; set; }
        public bool Queue { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Battlegroup { get; set; }
        public string Locale { get; set; }
        public string Timezone { get; set; }
        /// <summary>
        /// The strings returned to the ConnectedRealms correspond to the Slug of a Realm
        /// </summary>
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string[] ConnectedRealms { get; set; }
    }
}
