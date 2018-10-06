using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class Quest
    {
        public long id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}
