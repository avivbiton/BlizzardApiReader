using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.WorldOfWarcraft.Models;

namespace BlizzardApiReader.WorldOfWarcraft
{
    public class WorldOfWarcraftApi
    {
        private ApiReader reader;

        public WorldOfWarcraftApi()
        {
            reader = new ApiReader();
        }

        public WorldOfWarcraftApi(ApiConfiguration configuration)
        {
            reader = new ApiReader(configuration);
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
    }
}
