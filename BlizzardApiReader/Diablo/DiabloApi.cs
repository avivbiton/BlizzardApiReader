using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlizzardApiReader.Diablo.Models;

namespace BlizzardApiReader.Diablo
{
    public class DiabloApi
    {

        public ApiReader Reader;

        public DiabloApi(ApiReader _reader)
        {
            Reader = _reader;
        }


        public async Task<BattleAccount> GetApiAccount(string battleTag)
        {
            string query = $"/d3/profile/{battleTag}/";
            return await Reader.Get<BattleAccount>(query);
        }


        #region D3 Act Api

        public async Task<List<StoryAct>> GetActIndex()
        {
            string query = $"/d3/data/act/";
            var results = await Reader.Get<Dictionary<string, List<StoryAct>>>(query);
            return results["acts"];
        }

        public async Task<StoryAct> GetAct(int actId)
        {
            string query = $"/d3/data/act/{actId}/";
            return await Reader.Get<StoryAct>(query);
        }


        #endregion

        #region D# artisan and recipe api



        #endregion
    }
}
