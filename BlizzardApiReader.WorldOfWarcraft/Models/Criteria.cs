using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcraft.Models
{
    public class Criteria
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int OrderIndex { get; set; }
        public int Max { get; set; }
    }
}
