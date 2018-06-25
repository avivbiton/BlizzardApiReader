using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloReader.Models;

namespace DiabloReader
{
    public static class DiabloApi
    {

        public static void SetKey(string key)
        {
            ApiReader.Key = key;
        }

        public static async Task<BattleAccount> GetApiAccount(string battleTag)
        {
            ApiReader reader = new ApiReader();
            string query = $"/d3/profile/{battleTag}/";
            return await reader.Get<BattleAccount>(query);
        }


        #region D3 Act Api

        public static async Task<List<StoryAct>> GetActIndex()
        {
            ApiReader reader = new ApiReader();
            string query = $"/d3/data/act/";
            var results = await reader.Get<Dictionary<string, List<StoryAct>>>(query);
            return results["acts"];
        }

        public static async Task<StoryAct> GetAct(int actId)
        {
            ApiReader reader = new ApiReader();
            string query = $"/d3/data/act/{actId}/";
            return await reader.Get<StoryAct>(query);
        }


        #endregion

        #region D# artisan and recipe api

        #endregion
    }
}
