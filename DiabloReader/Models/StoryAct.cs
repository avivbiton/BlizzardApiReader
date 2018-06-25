using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloReader.Models
{
    public class StoryAct : IApiReadable
    {
        public string slug { get; set; }
        public short number { get; set; }
        public string name { get; set; }
        public List<Quest> quests { get; set; }
    }
}
