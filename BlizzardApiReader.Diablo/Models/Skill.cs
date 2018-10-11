namespace BlizzardApiReader.Diablo.Models
{
    public class Skill
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public long Level { get; set; }
        public string TooltipUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }
    }
}
