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
            string query = $"/d3/data/act/{actId}";
            return await reader.GetAsync<StoryAct>(query);
        }


        #endregion

        #region D3 artisan and recipe api

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

        #region D3 follower api

        public async Task<Follower> GetFollowerAsync(string followerSlug)
        {
            string query = $"/d3/data/follower/{followerSlug}";
            return await reader.GetAsync<Follower>(query);
        }
        #endregion

        #region D3 characters and skills api

        public async Task<HeroClass> GetCharacterClassAsync(string classSlug)
        {
            string query = $"/d3/data/hero/{classSlug}";
            return await reader.GetAsync<HeroClass>(query);
        }

        public async Task<HeroClassSkillInformation> GetCharacterClassSkillAsync(string classSlug, string skillSlug)
        {
            string query = $"/d3/data/hero/{classSlug}/skill/{skillSlug}";
            return await reader.GetAsync<HeroClassSkillInformation>(query);
        }
        #endregion

        #region D3 item type api

        public async Task<ItemType> GetItemTypesAsync()
        {
            string query = "/d3/data/item-type";
            return await reader.GetAsync<ItemType>(query);
        }

        public async Task<ItemTypeDetailed> GetItemTypeDetailedAsync(string itemTypeSlug)
        {
            string query = $"/d3/data/item-type/{itemTypeSlug}";
            return await reader.GetAsync<ItemTypeDetailed>(query);
        }
        #endregion

        #region D3 item api

        public async Task<Item> GetItemAsync(string itemSlugAndId)
        {
            string query = $"/d3/data/item/{itemSlugAndId}";
            return await reader.GetAsync<Item>(query);
        }
        #endregion

    }
}
