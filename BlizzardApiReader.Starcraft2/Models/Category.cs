using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlizzardApiReader.Starcraft2.Models
{
    public class Category
    {
        public IList<long> ChildrenCategoryIds { get; set; }
        public long FeaturedAchievementId { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ParentCategoryId { get; set; }
        public int Points { get; set; }
        public int UiOrderHint { get; set; }
    }
}
