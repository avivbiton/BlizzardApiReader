using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloReader.Diablo.Models
{
    public class DetailedArtisan
    {
        public string slug { get; set; }
        public string name { get; set; }
        public string portrait { get; set; }


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
            

        }

        public class ArtisanReagent
        {
            public int quantity { get; set; }
            public ArtisanItem item { get; set; }
            
        }

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
