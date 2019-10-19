using BlizzardApiReader.Core;
using System;
using System.Threading.Tasks;

namespace BlizzardApiReader.Hearthstone
{
    public class HearthstoneApi
    {
        private ApiReader reader;

        public HearthstoneApi(ApiReader apiReader)
        {
            apiReader = apiReader;

        }


        public async Task<Card> GetCardAsync(string idOrSlug)
        {
            string query = $"/hearhstone/cards/{idOrSlug}";
            return await reader.GetAsync<Card>(query);
        }


    }
}
