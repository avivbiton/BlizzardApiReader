using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BlizzardApiReader.Diablo.Models;
using System.IO;

namespace BlizzardApiReader
{
    public class ApiReader
    {
        private static readonly string Url = "https://REGION.api.battle.net";

        public ApiConfiguration Configuration { get; set; }


        public ApiReader(ApiConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public async Task<T> Get<T>(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                query = ValidateFormat(query);

                HttpResponseMessage responseMessage = await client.GetAsync(GetUrl() + query + "?locale=" + ApiConfiguration.GetLocaleString(Configuration.locale) + "&apikey=" + Configuration.Key);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }

            }

            return default(T);
        }

        private string ValidateFormat(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }

        private string GetUrl()
        {
            string region = ApiConfiguration.GetRegionString(Configuration.ApiRegion);
            return Url.Replace("REGION", region.ToLower());
        }
    }
}
