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
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Portrait { get; set; }

        [JsonProperty("training")]
        private Dictionary<string, List<ArtsianTier>> _training { get; set; }

        [JsonIgnore]
        public List<ArtsianTier> Tiers { get { return _training["tiers"]; } set { _training["tiers"] = value; } }


        public class ArtsianTier
        {
            public int Tier { get; set; }
            public List<ArtisanRecipe> TrainedRecipes { get; set; }

        }


        public class ArtisanRecipe
        {
            public string Id { get; set; }
            public string Slug { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
            public List<ArtisanReagent> Reagents { get; set; }
            public ArtisanItem ItemProduced { get; set; }

        }


        /// <summary>
        /// The required crafting materials for a single item 
        /// </summary>
        public class ArtisanReagent
        {
            public int Quantity { get; set; }
            public ArtisanItem Item { get; set; }

        }


        /// <summary>
        /// Can represent a crafting material or craftable item
        /// </summary>
        public class ArtisanItem
        {
            public string Id { get; set; }
            public string Slug { get; set; }
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Path { get; set; }
        }


    }


}
