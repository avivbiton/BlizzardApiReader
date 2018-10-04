using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Diablo.Models;

namespace BlizzardApiReader.Diablo
{
    public interface IDiabloApi
    {
        void OverrideConfiguration(ApiConfiguration newConfiguration);
        Task<BattleAccount> GetApiAccountAsync(string battleTag);
        Task<List<StoryAct>> GetActIndexAsync();
        Task<StoryAct> GetActAsync(int actId);
        Task<DetailedArtisan> GetArtisanAsync(string artisanSlug);
        Task<DetailedArtisan.ArtisanRecipe> GetArtisanRecipeAsync(string artisanSlug, string recipeSlug);
        Task<Follower> GetFollowerAsync(string followerSlug);
        Task<HeroClass> GetCharacterClassAsync(string classSlug);
        Task<HeroClassSkillInformation> GetCharacterClassSkillAsync(string classSlug, string skillSlug);
        Task<ItemType> GetItemTypesAsync();
        Task<ItemTypeDetailed> GetItemTypeDetailedAsync(string itemTypeSlug);
        Task<Item> GetItemAsync(string itemSlugAndId);
    }
}