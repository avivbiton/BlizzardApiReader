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

        /// <summary>
        /// Default configuration will be used if api reader does not have a local instance of ApiConfiguration
        /// </summary>
        private static ApiConfiguration defaultConfig { get; set; }
    
        // NOTE: I still don't like the limiters to sit  on the ApiReader object, maybe move it somewhere else in the future? (Aviv Biton)
        public static LimitersList Limiters { get; } = new LimitersList();

        public ApiConfiguration Configuration;

        public ApiReader(ApiConfiguration apiConfiguration = null)
        {
            Configuration = apiConfiguration;
        }

        public static void SetDefaultConfiguration(ApiConfiguration configuration)
        {
            defaultConfig = configuration;
        }

        public async Task<T> GetAsync<T>(string query)
        {
            verifyConfigurationIsValid();
            if (Limiters.AnyReachedLimit())
                throw new RateLimitReachedException("http request was blocked by RateLimiter");

            string urlRequest = parseUrl(query);
            HttpResponseMessage response = await makeHttpRequest(urlRequest);
            Limiters.NotifyAll(this, response);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }

            return default(T);
        }

        private void verifyConfigurationIsValid()
        {
            if (getConfiguration() == null)
                throw new NullReferenceException("ApiConfiguration is not set, either declare one as global configuration or set a local instance configuration object.");
        }



        private string parseUrl(string query)
        {
            query = parseSpecialCharacters(query);

            string region = getConfiguration().GetRegionString();
            string newUrl = Url.Replace("REGION", region.ToLower());
            newUrl += query + "?locale=" + getConfiguration().GetLocaleString() + "&apikey=" + getConfiguration().ApiKey;
            return newUrl;
        }

        private async Task<HttpResponseMessage> makeHttpRequest(string urlRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return await client.GetAsync(urlRequest);
            }
        }

        private string parseSpecialCharacters(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }
        private ApiConfiguration getConfiguration()
        {
            if (Configuration == null)
                return defaultConfig;
            else
                return Configuration;
        }
    }
}
