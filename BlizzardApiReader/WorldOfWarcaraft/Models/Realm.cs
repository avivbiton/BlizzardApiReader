using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.WorldOfWarcaraft.Models
{
    public class Realm
    {
        public string type { get; set; }
        public string population { get; set; }
        public bool queue { get; set; }
        public bool status { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string battlegroup { get; set; }
        public string locale { get; set; }
        public string timezone { get; set; }
        public string[] connected_realms { get; set; }
    }
}