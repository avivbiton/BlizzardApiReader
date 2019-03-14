using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class GuildEmblem
    {
        public int Icon { get; set; }
        public string IconColor { get; set; }
        public int IconColorId { get; set; }
        public int Border { get; set; }
        public string BorderColor { get; set; }
        public int BorderColorId { get; set; }
        public string BackgroundColor { get; set; }
        public int BackgroundColorId { get; set; }

    }
}
