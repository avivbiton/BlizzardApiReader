using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Diablo.Models
{
    public class Quest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
