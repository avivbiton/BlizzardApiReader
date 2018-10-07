using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.Core.Models;
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

        #region WoW Realm Status
        public async Task<List<Realm>> GetRealmIndexAsync()
        {
            string query = $"/wow/realm/status";
            var results = await reader.GetAsync<Dictionary<string, List<Realm>>>(query);
            return results["realms"];
        }
        #endregion
    }
}
