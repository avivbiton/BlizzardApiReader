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
        public IRateLimiter rateLimiter { get; set; }


        public ApiReader(ApiConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<T> GetAsync<T>(string query)
        {

            if (isRateLimited()) throw new Exception("Client request was blocked by rate limiter.");

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                query = ParseSpecialCharacters(query);

                string parsedUrl = ParseUrl(query);

                HttpResponseMessage responseMessage = await client.GetAsync(parsedUrl);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }

                rateLimiter?.OnApiRequest(this);
            }

            return default(T);
        }


        private bool isRateLimited()
        {
            if (rateLimiter == null) return false;

            return rateLimiter.IsAtRateLimit();
        }

        private string ParseSpecialCharacters(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }

        private string ParseUrl(string query)
        {
            string region = Configuration.GetRegionString();
            string newUrl = Url.Replace("REGION", region.ToLower());
            newUrl += query + "?locale=" + Configuration.GetLocaleString() + "&apikey=" + Configuration.ApiKey;
            return newUrl;
        }
    }
}
