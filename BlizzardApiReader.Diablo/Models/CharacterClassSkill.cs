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
        public HeroClassSkillInformationSkill Skill { get; set; }
        public List<HeroClassSkillInformationRune> Runes { get; set; }
    }

    public class HeroClassSkillInformationRune
    {
        public string Slug { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public long Level { get; set; }
        public string Description { get; set; }
        public string DescriptionHtml { get; set; }
    }

    public class HeroClassSkillInformationSkill
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
