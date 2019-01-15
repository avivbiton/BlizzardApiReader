using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.Diablo.Models;

namespace BlizzardApiReader.Diablo
{
    public class DiabloApi
    {

        private ApiReader reader;

        public DiabloApi(ApiReader apiReader)
        {
            reader =  apiReader;
            
        }
                
        public void OverrideConfiguration(ApiConfiguration newConfiguration)
        {
            reader.Configuration = newConfiguration;
        }
        
        #region D3 Profile Api

        public async Task<BattleAccount> GetApiAccountAsync(string battleTag)
        {
            string query = $"/d3/profile/{battleTag}/";
            return await reader.GetAsync<BattleAccount>(query);
        }

        public async Task<HeroExtended> GetApiHeroAsync(string battleTag, long heroId)
        {
            string query = $"/d3/profile/{battleTag}/hero/{heroId}/";
            return await reader.GetAsync<HeroExtended>(query);
        }

        public async Task<HeroItemsExtended> GetApiDetailedHeroItemsAsync(string battleTag, long heroId)
        {
            string query = $"/d3/profile/{battleTag}/hero/{heroId}/items/";
            return await reader.GetAsync<HeroItemsExtended>(query);
        }

        public async Task<FollowerItemsExtended> GetApiDetailedFollowerItemsAsync(string battleTag, long heroId)
        {
            string query = $"/d3/profile/{battleTag}/hero/{heroId}/follower-items/";
            return await reader.GetAsync<FollowerItemsExtended>(query);
        }

        #endregion

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

        public async Task<IEnumerable<ItemType>> GetItemTypesAsync()
        {
            string query = "/d3/data/item-type";
            return await reader.GetAsync<IEnumerable<ItemType>>(query);
        }

        public async Task<IEnumerable<ItemTypeDetailed>> GetItemTypeDetailedAsync(string itemTypeSlug)
        {
            string query = $"/d3/data/item-type/{itemTypeSlug}";
            return await reader.GetAsync<IEnumerable<ItemTypeDetailed>>(query);
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
