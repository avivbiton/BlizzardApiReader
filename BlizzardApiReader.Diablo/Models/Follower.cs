using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class Follower
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public string Portrait { get; set; }
        public List<Skill> Skills { get; set; }
    }

}
