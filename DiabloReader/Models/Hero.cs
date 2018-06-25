using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace DiabloReader.Models
{
    public class Hero
    {
        public long id { get; set; }
        public string name { get; set; }
        [JsonProperty("class")]
        public string className { get; set; }
        public string classSlug { get; set; }
        public short gender { get; set; }
        public short level { get; set; }
        public Dictionary<string, long> kills { get; set; }
        public int paragonLevels { get; set; }
        public bool hardcore { get; set; }
        public bool seasonal { get; set; }
        public bool dead { get; set; }
        public long last_updated { get; set; }

    }


}
