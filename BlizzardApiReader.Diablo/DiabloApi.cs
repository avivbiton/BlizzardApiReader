using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core.Models;
using BlizzardApiReader.Diablo.Models;

namespace BlizzardApiReader.Diablo
{
    public class DiabloApi
    {

        private ApiReader reader;

        public DiabloApi()
        {
            reader = new ApiReader();
            
        }

        public DiabloApi(ApiConfiguration configuration)
        {
            reader = new ApiReader(configuration);
        }

        public void OverrideConfiguration(ApiConfiguration newConfiguration)
        {
            reader.Configuration = newConfiguration;
        }


        public async Task<BattleAccount> GetApiAccountAsync(string battleTag)
        {
            string query = $"/d3/profile/{battleTag}/";
            return await reader.GetAsync<BattleAccount>(query);
        }


        #region D3 Act Api

        public async Task<List<StoryAct>> GetActIndexAsync()
        {
            string query = $"/d3/data/act/";
            var results = await reader.GetAsync<Dictionary<string, List<StoryAct>>>(query);
            return results["acts"];
        }

        public async Task<StoryAct> GetActAsync(int actId)
        {
            string query = $"/d3/data/act/{actId}/";
            return await reader.GetAsync<StoryAct>(query);
        }


        #endregion

        #region D# artisan and recipe api

        public async Task<DetailedArtisan> GetArtisanAsync(string artisanSlug)
        {
            string query = $"/d3/data/artisan/{artisanSlug}/";
            return await reader.GetAsync<DetailedArtisan>(query);
        }

        public async Task<DetailedArtisan.ArtisanRecipe> GetArtisanRecipeAsync(string artisanSlug, string recipeSlug)
        {
            string query = $"/d3/data/artisan/{artisanSlug}/recipe/{recipeSlug}/";
            return await reader.GetAsync<DetailedArtisan.ArtisanRecipe>(query);
        }




        #endregion
    }
}
