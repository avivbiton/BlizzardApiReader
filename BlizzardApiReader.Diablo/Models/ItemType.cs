using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class ItemType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
