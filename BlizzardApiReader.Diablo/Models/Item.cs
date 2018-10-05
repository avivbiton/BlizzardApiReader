using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("tooltipParams")]
        public string TooltipParams { get; set; }

        [JsonProperty("requiredLevel")]
        public long RequiredLevel { get; set; }

        [JsonProperty("stackSizeMax")]
        public long StackSizeMax { get; set; }

        [JsonProperty("accountBound")]
        public bool AccountBound { get; set; }

        [JsonProperty("flavorText")]
        public string FlavorText { get; set; }

        [JsonProperty("flavorTextHtml")]
        public string FlavorTextHtml { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }

        [JsonProperty("dps")]
        public string Dps { get; set; }

        [JsonProperty("damageHtml")]
        public string DamageHtml { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("isSeasonRequiredToDrop")]
        public bool IsSeasonRequiredToDrop { get; set; }

        [JsonProperty("seasonRequiredToDrop")]
        public long SeasonRequiredToDrop { get; set; }

        [JsonProperty("slots")]
        public List<string> Slots { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("randomAffixes")]
        public List<RandomAffix> RandomAffixes { get; set; }

        [JsonProperty("setItems")]
        public List<object> SetItems { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("primary")]
        public List<Primary> Primary { get; set; }

        [JsonProperty("secondary")]
        public List<Primary> Secondary { get; set; }

        [JsonProperty("other")]
        public List<object> Other { get; set; }
    }

    public class Primary
    {
        [JsonProperty("textHtml")]
        public string TextHtml { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class RandomAffix
    {
        [JsonProperty("oneOf")]
        public List<Primary> OneOf { get; set; }
    }

    public class TypeClass
    {
        [JsonProperty("twoHanded")]
        public bool TwoHanded { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
