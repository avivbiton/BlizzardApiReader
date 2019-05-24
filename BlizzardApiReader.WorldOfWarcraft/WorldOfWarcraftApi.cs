using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.WorldOfWarcraft.Models;

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
        public async Task<Character> GetCharacterAsync(string realm, string characterName, string fields=null)
        {
            string query = $"/wow/character/{realm}/{characterName}";

            if (fields is null)
            {            
                return await reader.GetAsync<Character>(query);
            } else
            {
                return await reader.GetAsync<Character>(query,"&fields="+fields);
            }
        }



        #endregion

        #region Guild Profile
        public async Task<Guild> GetGuildAsync(string realm, string guildName, string fields = null)
        {
            string query = $"/wow/guild/{realm}/{guildName}";

            if (fields is null)
            {
                return await reader.GetAsync<Guild>(query);
            }
            else
            {
                return await reader.GetAsync<Guild>(query, "&fields=" + fields);
            }
        }

        //TODO Members, Achievements, News Challenge

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

    }
}
