using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlizzardApiReader.Diablo.Models
{
    public class DetailedArtisan
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string portrait { get; set; }

        [JsonProperty]
        private Dictionary<string, List<ArtsianTier>> training { get; set; }

        [JsonIgnore]
        public List<ArtsianTier> tiers { get { return training["tiers"]; } set { training["tiers"] = value; } }


        public class ArtsianTier
        {
            public int tier { get; set; }
            public List<ArtisanRecipe> trainedRecipes { get; set; }

        }


        public class ArtisanRecipe
        {
            public string id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public int cost { get; set; }
            public List<ArtisanReagent> reagents { get; set; }
            public ArtisanItem itemProduced { get; set; }

        }


        /// <summary>
        /// The required crafting materials for a single item 
        /// </summary>
        public class ArtisanReagent
        {
            public int quantity { get; set; }
            public ArtisanItem item { get; set; }

        }


        /// <summary>
        /// Can represent a crafting material or craftable item
        /// </summary>
        public class ArtisanItem
        {
            public string id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public string icon { get; set; }
            public string path { get; set; }
        }


    }


}
