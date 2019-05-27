using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.WorldOfWarcraft.Models;
using BlizzardApiReader.WorldOfWarcraft.Enums;

namespace BlizzardApiReader.WorldOfWarcraft
{
    public class WorldOfWarcraftApi
    {
        private ApiReader reader;

        public WorldOfWarcraftApi(ApiReader apiReader)
        {
            reader = apiReader;
        }
        
        public void OverrideConfiguration(ApiConfiguration newConfiguration)
        {
            reader.Configuration = newConfiguration;
        }

        #region WoW Achievements
        public async Task<Achievement> GetAchievementAsync(int achievementId)
        {
            string query = $"/wow/achievement/{achievementId}";
            return await reader.GetAsync<Achievement>(query);
        }
        #endregion

        #region WoW Boss
        public async Task<List<Boss>> GetBossesAsync()
        {
            string query = $"/wow/boss/";
            
            var results = await reader.GetAsync<Dictionary<string, List<Boss>>>(query);
            return results["bosses"];
        }

        public async Task<Boss> GetBossAsync(int bossId)
        {
            string query = $"/wow/boss/{bossId}";
            return await reader.GetAsync<Boss>(query);
        }
        #endregion

        #region WoW Mount
        public async Task<IEnumerable<Mount>> GetMountsAsync()
        {
            string query = "/wow/mount/";
            var result = await reader.GetAsync<MountApiModel>(query);
            return result.Mounts;
        }
        #endregion

        #region WoW Quests
        public async Task<Quest> GetQuestAsync(int questId)
        {
            string query = $"/wow/quest/{questId}";
            return await reader.GetAsync<Quest>(query);
        }
        #endregion

        #region WoW Realm Status
        public async Task<List<Realm>> GetRealmIndexAsync()
        {
            string query = $"/wow/realm/status";
            var results = await reader.GetAsync<Dictionary<string, List<Realm>>>(query);
            return results["realms"];
        }
        #endregion

        #region WoW Spells
        public async Task<Spell> GetSpellAsync(int spellId)
        {
            string query = $"/wow/spell/{spellId}";
            return await reader.GetAsync<Spell>(query);
        }
        #endregion

        #region Challenge Mode
        public async Task<List<Challenge>> GetChallengesAsync(string realm)
        {
            string query = $"/wow/challenge/{realm}";
            var results = await reader.GetAsync<Dictionary<string, List<Challenge>>>(query);
            return results["challenge"];
        }

        public async Task<List<Challenge>> GetChallengesRegionAsync()
        {
            string query = $"/wow/challenge/region";
            var results = await reader.GetAsync<Dictionary<string, List<Challenge>>>(query);
            return results["challenge"];
        }
        #endregion

        #region Character Profile
        public async Task<Character> GetCharacterAsync(string realm, string characterName, CharacterOptions characterOptions=CharacterOptions.None)
        {
            string query = $"/wow/character/{realm}/{characterName}";
            
            return await reader.GetAsync<Character>(query,CharacterFields.BuildOptionalFields(characterOptions));
            
        }



        #endregion

        #region Guild Profile
        public async Task<Guild> GetGuildAsync(string realm, string guildName, GuildOptions guildOptions = GuildOptions.None)
        {
            string query = $"/wow/guild/{realm}/{guildName}";

            return await reader.GetAsync<Guild>(query, GuildFields.BuildOptionalFields(guildOptions));
            
        }   

        #endregion

        #region Items
        public async Task<Item> GetItemAsync(int itemId)
        {
            string query = $"/wow/item/{itemId}";

            return await reader.GetAsync<Item>(query);
            
        }

        public async Task<ItemSet> GetItemSetAsync(int setId)
        {
            string query = $"/wow/item/set/{setId}";

            return await reader.GetAsync<ItemSet>(query);
            
        }

        #endregion

        //Pending:  Pvp, Quest, Recipe, User, Zone, DataSources

        #region Pet

        public async Task<List<Pet>> GetPetsAsync()
        {
            string query = $"/wow/pet/";
            
            var results = await reader.GetAsync<Dictionary<string, List<Pet>>>(query);
            return results["pets"];
        }

        public async Task<PetAbility> GetPetAbilityAsync(int abilityId){
            string query = $"/wow/pet/ability/{abilityId}";

            return await reader.GetAsync<PetAbility>(query);
            
        }

        public async Task<PetSpecies> GetPetSpeciesAsync(int petSpeciesId){
            string query = $"/wow/pet/species/{petSpeciesId}";

            return await reader.GetAsync<PetSpecies>(query);
            
        }

        public async Task<PetStats> GetPetStatsAsync(int petSpeciesId,int level,int breedId,int qualityId){
            string query = $"/wow/pet/stats/{petSpeciesId}";

            return await reader.GetAsync<PetStats>(query,$"&level={level}&breedId={breedId}&qualityId={qualityId}");
            
        }

        #endregion
    }
}
