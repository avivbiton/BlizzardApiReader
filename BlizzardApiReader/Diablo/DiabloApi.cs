using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlizzardApiReader.Diablo.Models;

namespace BlizzardApiReader.Diablo
{
    public class DiabloApi
    {

        private ApiReader Reader;

        public DiabloApi(ApiReader _reader)
        {
            Reader = _reader;
        }


        public async Task<BattleAccount> GetApiAccountAsync(string battleTag)
        {
            string query = $"/d3/profile/{battleTag}/";
            return await Reader.GetAsync<BattleAccount>(query);
        }


        #region D3 Act Api

        public async Task<List<StoryAct>> GetActIndexAsync()
        {
            string query = $"/d3/data/act/";
            var results = await Reader.GetAsync<Dictionary<string, List<StoryAct>>>(query);
            return results["acts"];
        }

        public async Task<StoryAct> GetActAsync(int actId)
        {
            string query = $"/d3/data/act/{actId}/";
            return await Reader.GetAsync<StoryAct>(query);
        }


        #endregion

        #region D# artisan and recipe api

        public async Task<DetailedArtisan> GetArtisanAsync(string artisanSlug)
        {
            string query = $"/d3/data/artisan/{artisanSlug}/";
            return await Reader.GetAsync<DetailedArtisan>(query);
        }

        public async Task<DetailedArtisan.ArtisanRecipe> GetArtisanRecipeAsync(string artisanSlug, string recipeSlug)
        {
            string query = $"/d3/data/artisan/{artisanSlug}/recipe/{recipeSlug}/";
            return await Reader.GetAsync<DetailedArtisan.ArtisanRecipe>(query);
        }




        #endregion
    }
}
