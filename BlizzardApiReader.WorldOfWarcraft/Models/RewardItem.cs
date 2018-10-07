using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class RewardItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams tooltipParams { get; set; }
        public object[] stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public object[] bonusLists { get; set; }
        public int displayInfoId { get; set; }
        public int artifactId { get; set; }
        public int artifactAppearanceId { get; set; }
        public object[] artifactTraits { get; set; }
        public object[] relics { get; set; }
        public object appearance { get; set; }
    }
}
