using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.Core.Models;
using BlizzardApiReader.WorldOfWarcaraft.Models;

namespace BlizzardApiReader.WorldOfWarcaraft
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
