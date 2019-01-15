using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BlizzardApiReader.Core.Exceptions;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using BlizzardApiReader.Core.Enums;
using System.Net.Http.Headers;

namespace BlizzardApiReader.Core
{
    public class ApiReader
    {
        /// <summary>
        /// Default configuration will be used if api reader does not have a local instance of ApiConfiguration
        /// </summary>
        private static ApiConfiguration defaultConfig { get; set; }
        private static LimitersList limiters { get; } = new LimitersList();


        private ApiConfiguration apiConfiguration;
        public ApiConfiguration Configuration
        {
            get { return apiConfiguration ?? defaultConfig; }
            set
            {
                apiConfiguration = value;               
            }
        }

        private readonly IWebClient _webClient;
        
        private string _token;
        private DateTime _tokenExpiration;
               
        public ApiReader()
        {

        }

        public ApiReader(IOptions<ApiConfiguration> apiConfiguration, IWebClient webClient)
        {
            _webClient = webClient;
            
            Configuration = apiConfiguration.Value;                        
        }

        public static void SetDefaultConfiguration(ApiConfiguration configuration)
        {
            defaultConfig = configuration;
        }
                
        public static void ClearDefaultConfiguration()
        {
            defaultConfig = null;
        }

        public async Task<T> GetAsync<T>(string query)
        {
            throwIfInvalidRequest();

            if (hasTokenExpired())
            {
                await SendTokenRequest();
            }

            string urlRequest = parsePath(query);
            IApiResponse response = await _webClient.MakeApiRequestAsync(Configuration.GetApiUrl() + urlRequest);
            limiters.NotifyAll(this, response);

            if (response.IsSuccessful())
            {
                string json = await response.ReadContentAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                throw new BadResponseException("Response is not successful", response);
            }

        }

        /// <summary>
        /// Sends token request and sets it as the current token.
        /// </summary>
        /// <returns></returns>
        public async Task<string> SendTokenRequest()
        {
            var response = await _webClient.RequestAccessTokenAsync();
            if (response.IsSuccessful())
            {
                string json = await response.ReadContentAsync();
                JObject jObject = JObject.Parse(json);
                _token = (string)jObject["access_token"];
                int expiresInSeconds = (int)jObject["expires_in"];
                _tokenExpiration = DateTime.Now.AddSeconds(expiresInSeconds);
                return _token;
            }
            //TODO: Add better error handling
            throw new HttpRequestException("response code was not successful");
        }


        private void throwIfInvalidRequest()
        {
            verifyConfigurationIsValid();

            if (limiters.AnyReachedLimit())
                throw new RateLimitReachedException("http request was blocked by RateLimiter");
        }

        private bool hasTokenExpired()
        {
            if (string.IsNullOrEmpty(_token)
                || DateTime.Now > _tokenExpiration)
            {
                return true;
            }

            return false;
        }


        private void verifyConfigurationIsValid()
        {
            if (Configuration == null || _webClient == null)
                throw new NullReferenceException("ApiConfiguration is not set, either declare one as global configuration or set a local instance configuration object.");
        }


        private string parsePath(string query)
        {
            return parseSpecialCharacters(query) 
                + "?locale=" + Configuration.GetLocaleString() 
                + "&access_token=" + _token;
        }



        private string parseSpecialCharacters(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }
    }
}
