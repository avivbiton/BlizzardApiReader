using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BlizzardApiReader.Core.Exceptions;

namespace BlizzardApiReader.Core
{
    public class ApiReader
    {
        /// <summary>
        /// Default configuration will be used if api reader does not have a local instance of ApiConfiguration
        /// </summary>
        private static ApiConfiguration defaultConfig { get; set; }
        private static LimitersList limiters { get; } = new LimitersList();


        private ApiConfiguration _configuration;
        public ApiConfiguration Configuration
        {
            get { return _configuration ?? defaultConfig; }
            set
            {
                _configuration = value;
                _webClient = new ApiWebClient(_configuration);
            }
        }

        private IWebClient _webClient;
        private string _token;
        private DateTime _tokenExpiration;

        public ApiReader(ApiConfiguration apiConfiguration = null, IWebClient webClient = null)
        {
            _configuration = apiConfiguration;
            if (webClient == null)
                _webClient = new ApiWebClient(Configuration);
            else
                _webClient = webClient;
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
            ThrowIfInvalidRequest();

            if (tokenExpired())
            {
                await SendTokenRequest();
            }

            string urlRequest = ParsePath(query);
            IApiResponse response = await _webClient.MakeApiRequestAsync(urlRequest);
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


        private void ThrowIfInvalidRequest()
        {

            VerifyConfigurationIsValid();

            if (limiters.AnyReachedLimit())
                throw new RateLimitReachedException("http request was blocked by RateLimiter");
        }

        private bool tokenExpired()
        {
            if (String.IsNullOrEmpty(_token)
                || DateTime.Now > _tokenExpiration)
            {
                return true;
            }

            return false;
        }


        private void VerifyConfigurationIsValid()
        {
            if (Configuration == null)
                throw new NullReferenceException("ApiConfiguration is not set, either declare one as global configuration or set a local instance configuration object.");
        }


        private string ParsePath(string query)
        {
            return ParseSpecialCharacters(query) 
                + "?locale=" + Configuration.GetLocaleString() 
                + "&access_token=" + _token;
        }



        private string ParseSpecialCharacters(string s)
        {
            s = s.Replace("#", "%23");
            return s;
        }
    }
}
