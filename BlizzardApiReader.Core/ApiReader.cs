using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BlizzardApiReader.Core.Models;
using Newtonsoft.Json;

namespace BlizzardApiReader.Core
{
    public class ApiReader
    {
        private static readonly string Url = "https://REGION.api.battle.net";

        /// <summary>
        /// Default configuration will be used if api reader does not have a local instance of ApiConfiguration
        /// </summary>
        private static ApiConfiguration defaultConfig { get; set; }
        private static List<IRateLimiter> rateLimiters { get; set; }

        public ApiConfiguration Configuration;

        private string parsedUrl;

        public ApiReader(ApiConfiguration apiConfiguration = null)
        {
            Configuration = apiConfiguration;
        }

        public static void SetDefaultConfiguration(ApiConfiguration configuration)
        {
            defaultConfig = configuration;
        }

        public static void AddRateLimiter(IRateLimiter limiter)
        {
            if (rateLimiters == null)
                rateLimiters = new List<IRateLimiter>();

            rateLimiters.Add(limiter);
        }

        public static void RemoveRateLimiter(IRateLimiter limiter)
        {
            if (rateLimiters.Contains(limiter) == false)
                throw new KeyNotFoundException();

            rateLimiters.Remove(limiter);
        }

        public static void RemoveAllLimiters()
        {
            rateLimiters = null;
        }


        public async Task<T> GetAsync<T>(string query)
        {
            verifyConfigurationIsValid();
            validateRateLimit();
            string urlRequest = parseUrl(query);
            HttpResponseMessage response = await makeHttpRequest();
            notifyLimiters();

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

        private void validateRateLimit()
        {
            if (rateLimiters != null)
                if (rateLimiters.Any(i => i.IsAtRateLimit()))
                    throw new Exception("Get api request blocked by rate Limiter");
        }

        private string parseUrl(string query)
        {
            query = parseSpecialCharacters(query);

            string region = getConfiguration().GetRegionString();
            string newUrl = Url.Replace("REGION", region.ToLower());
            newUrl += query + "?locale=" + getConfiguration().GetLocaleString() + "&apikey=" + getConfiguration().ApiKey;
            return newUrl;
        }

        private async Task<HttpResponseMessage> makeHttpRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return await client.GetAsync(parsedUrl);
            }
        }

        private void notifyLimiters()
        {
            if (rateLimiters == null)
                return;

            rateLimiters.ForEach(i => i.OnApiRequest(this));
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
