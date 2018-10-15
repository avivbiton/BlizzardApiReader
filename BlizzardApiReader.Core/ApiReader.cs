using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlizzardApiReader.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlizzardApiReader.Core
{
    public class ApiReader
    {
        private const string url = "https://REGION.api.blizzard.com";

        /// <summary>
        /// Default configuration will be used if api reader does not have a local instance of ApiConfiguration
        /// </summary>
        private static ApiConfiguration defaultConfig { get; set; }
        private static LimitersList limiters { get; } = new LimitersList();

        public ApiConfiguration Configuration;

        private IWebClient webClient;
        private string token;

        public ApiReader(ApiConfiguration apiConfiguration = null)
        {
            Configuration = apiConfiguration;
            webClient = new ApiWebClient();
        }

        public static void SetDefaultConfiguration(ApiConfiguration configuration)
        {
            defaultConfig = configuration;
        }

        public async Task<T> GetAsync<T>(string query)
        {
            verifyConfigurationIsValid();
            if (limiters.AnyReachedLimit())
                throw new RateLimitReachedException("http request was blocked by RateLimiter");

            string urlRequest = parseUrl(query);
            HttpResponseMessage response = await webClient.MakeHttpRequestAsync(urlRequest);
            limiters.NotifyAll(this, response);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }

            return default;
        }

        public async Task<string> RequestToken()
        {
            var response = await webClient.RequestAccessTokenAsync(getConfiguration());
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(json);
                return (string)jObject["access_token"];
            }
            //TODO: Add better error handling
            throw new HttpRequestException("response code was not successful");
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
            string newUrl = url.Replace("REGION", region.ToLower());
            newUrl += query + "?locale=" + getConfiguration().GetLocaleString() + "&token=" + token;
            return newUrl;
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
