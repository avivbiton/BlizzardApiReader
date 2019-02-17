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

        #region SC2 ProfileAPI

        #region SC2 Static
        public async Task<Static> GetStaticAsync(int regionID)
        {
            string query = $"/sc2/static/profile/{regionID}";
            return await reader.GetAsync<Static>(query);
        }
        #endregion

        #region SC2 MetaData
        public async Task<MetaData> GetMetaDataAsync(int regionID, int realmID, int profileId)
        {
            string query = $"/sc2/metadata/profile/{regionID}/{realmID}/{profileId}";
            return await reader.GetAsync<MetaData>(query);
        }
        #endregion

        #region SC2 Profile
        //TODO: implement "Profile.achievementShowcase".
        //achievementShowcase - returned empty object
        public async Task<Profile> GetProfileAsync(int regionID, int realmID, int profileId)
        {
            string query = $"/sc2/profile/{regionID}/{realmID}/{profileId}";
            return await reader.GetAsync<Profile>(query);
        }
        #endregion

        #region SC2 LadderSummary
        //TODO: implement "LadderSummary". 
        //Returns a ladder summary for an individual SC2 profile.
        //GET - /sc2/profile/:regionId/:realmId/:profileId/ladder/summary
        public async Task<LadderSummary> GetLadderSummaryAsync(int regionId, int realmId, int profileId, int ladderId, string locale = "en_US")
        {
            string query = $"/sc2/profile/{regionId}/{realmId}/{profileId}/{ladderId}/ladder/summary";
            return await reader.GetAsync<LadderSummary>(query);
        }
        #endregion

        #region SC2 Ladder
        //TODO: implement "Ladder". 
        //Returns data about an individual profile's ladder.
        //GET - /sc2/profile/:regionId/:realmId/:profileId/ladder/:ladderId
        public async Task<Ladder> GetLadderAsync(int regionId, int realmId, int profileId, int ladderId, string locale = "en_US")
        {
            string query = $"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/{ladderId}";
            return await reader.GetAsync<Ladder>(query);
        }
        #endregion
        #endregion

        #region SC2 LadderAPI

        #region SC2 GrandmasterLeaderboard
        public async Task<List<GrandmasterLeaderboard>> GetGrandmasterLeaderboardAsync(int regionID)
        {
            string query = $"/sc2/ladder/grandmaster/{regionID}";
            var results = await reader.GetAsync<Dictionary<string, List<GrandmasterLeaderboard>>>(query);
            return results["ladderTeams"];
        }
        #endregion

        #region SC2 Season
        public async Task<Season> GetSeasonAsync(int regionID)
        {
            string query = $"/sc2/ladder/season/{regionID}";
            return await reader.GetAsync<Season>(query);
        }
        #endregion
        #endregion

        #region SC2 AccountAPI

        #region SC2 Player
        public async Task<Player> GetPlayerAsync(int playerId)
        {
            string query = $"/sc2/player/{playerId}";
            return await reader.GetAsync<Player>(query);
        }
        #endregion

        #endregion
    }
}
