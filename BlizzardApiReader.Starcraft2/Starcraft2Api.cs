using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardApiReader.Core;
using BlizzardApiReader.Starcraft2.Models;

namespace BlizzardApiReader.Starcraft2
{
   public class Starcraft2Api
    {
        private ApiReader reader;

        public Starcraft2Api()
        {
            reader = new ApiReader();
        }

        public Starcraft2Api(ApiConfiguration configuration)
        {
            reader = new ApiReader(configuration);
        }

        public void OverrideConfiguration(ApiConfiguration newConfiguration)
        {
            reader.Configuration = newConfiguration;
        }

        #region SC2 Account
        public async Task<Account> GetAccountAsync(int accountId)
        {
            string query = $"/sc2/player/{accountId}";
            return await reader.GetAsync<Account>(query);
        }
        #endregion

        #region SC2 Profile
        public async Task<Profile> GetProfileAsync(int regionID, int realmID, int profileId)
        {
            string query = $"/sc2/profile/{regionID}/{realmID}/{profileId}";
            return await reader.GetAsync<Profile>(query);
        }
        #endregion

        #region SC2 League
        public async Task<League> GetLeagueAsync(string seasonId, string queueId, string teamType, string leagueId)
        {
            string query = $"/data/sc2/league/{seasonId}/{queueId}/{teamType}/{leagueId}";
            return await reader.GetAsync<League>(query);
        }
        #endregion



    }
}
