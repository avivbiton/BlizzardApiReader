using BlizzardApiReader.Core.Enums;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public class ApiWebClient : IWebClient
    {
        private HttpClient _apiClient;
        private HttpClient _authClient;

        private readonly IHttpClientFactory _httpClientFactory;

        public ApiWebClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        private readonly FormUrlEncodedContent _authRequestContent = new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" }
                });

        private string authPath;
        private SocketsHttpHandler socketsHttpHandler;

        public void Initialize(ApiConfiguration _configuration)
        {
            authPath = _configuration.GetAuthUrl();
            socketsHttpHandler = createSocketsHandler(_configuration);

            _apiClient = configureApiClient();
            _authClient = configureAuthClient(authenticateHeader(_configuration.ClientId, _configuration.ClientSecret));
        }

        public async Task<IApiResponse> MakeApiRequestAsync(string path)
        {
            var response = await _apiClient.GetAsync(path);
            return new ApiResponse(response);
        }

        public async Task<IApiResponse> RequestAccessTokenAsync()
        {

            FormUrlEncodedContent _authRequestContent = new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" }
                });

            var response = await _authClient.PostAsync(authPath, _authRequestContent);
            return new ApiResponse(response);
        }


        private SocketsHttpHandler createSocketsHandler(ApiConfiguration _configuration)
        {
            SocketsHttpHandler socketsHttpHandler;
            //if a proxy was configured use it for the connection
            if (_configuration.GetHttpProxy() != null)
            {
                socketsHttpHandler = new SocketsHttpHandler()
                {
                    Proxy = _configuration.GetHttpProxy(),
                    PooledConnectionLifetime = _configuration.GetPooledConnectionLifetime()
                };
            }
            else
            {
                socketsHttpHandler = new SocketsHttpHandler()
                {
                    PooledConnectionLifetime = _configuration.GetPooledConnectionLifetime()
                };
            }

            return socketsHttpHandler;
        }

        private HttpClient configureApiClient()
        {            
            var client = _httpClientFactory.CreateClient(NamedHttpClients.ApiClient.ToString());         
            return client;
        }

        private HttpClient configureAuthClient(AuthenticationHeaderValue header)
        {
            var client = _httpClientFactory.CreateClient(NamedHttpClients.AuthClient.ToString());

            client.DefaultRequestHeaders.Authorization = header;

            return client;
        }

        private AuthenticationHeaderValue authenticateHeader(string clientId, string clientSecret)
        {
            return new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                    Encoding.GetEncoding("ISO-8859-1")
                    .GetBytes(clientId + ":" + clientSecret)));
        }
    }
}
