using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class GuildMember
    {        
        public Character Character { get; set; }        
        public int Rank { get; set; }        
    }
}
