using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class StoryAct 
    {
        public string Slug { get; set; }
        public short Number { get; set; }
        public string Name { get; set; }
        public List<Quest> Quests { get; set; }
    }
}
