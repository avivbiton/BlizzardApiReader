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
        public string Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string TooltipParams { get; set; }
        public long RequiredLevel { get; set; }
        public long StackSizeMax { get; set; }
        public bool AccountBound { get; set; }
        public string FlavorText { get; set; }
        public string FlavorTextHtml { get; set; }
        public string TypeName { get; set; }
        public TypeClass Type { get; set; }
        public string Damage { get; set; }
        public string Dps { get; set; }
        public string DamageHtml { get; set; }
        public string Color { get; set; }
        public bool IsSeasonRequiredToDrop { get; set; }
        public long SeasonRequiredToDrop { get; set; }
        public List<string> Slots { get; set; }
        public Attributes Attributes { get; set; }
        public List<RandomAffix> RandomAffixes { get; set; }
        public List<object> SetItems { get; set; }
    }

    public class Attributes
    {
        public List<Primary> Primary { get; set; }
        public List<Primary> Secondary { get; set; }
        public List<object> Other { get; set; }
    }

    public class Primary
    {
        public string TextHtml { get; set; }
        public string Text { get; set; }
    }

    public class RandomAffix
    {
        public List<Primary> OneOf { get; set; }
    }

    public class TypeClass
    {
        public bool TwoHanded { get; set; }
        public string Id { get; set; }
    }
}
