using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class RewardItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Quality { get; set; }
        public int ItemLevel { get; set; }
        public TooltipParams TooltipParams { get; set; }
        public object[] Stats { get; set; }
        public int Armor { get; set; }
        public string Context { get; set; }
        public object[] BonusLists { get; set; }
        public int DisplayInfoId { get; set; }
        public int ArtifactId { get; set; }
        public int ArtifactAppearanceId { get; set; }
        public object[] ArtifactTraits { get; set; }
        public object[] Relics { get; set; }
        public object Appearance { get; set; }
    }
}
