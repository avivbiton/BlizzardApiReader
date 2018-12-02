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
        private readonly HttpClient _apiClient;
        private readonly HttpClient _authClient;
        private readonly ApiConfiguration _configuration;
        private readonly FormUrlEncodedContent _authRequestContent;

        public ApiWebClient(ApiConfiguration configuration)
        {
            _configuration = configuration;
            var jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");
            _apiClient = new HttpClient(
                new SocketsHttpHandler() { PooledConnectionLifetime = TimeSpan.FromMinutes(1) });
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(jsonHeader);

            _authClient = new HttpClient(
                new SocketsHttpHandler() { PooledConnectionLifetime = TimeSpan.FromMinutes(1) });
            AuthenticationHeaderValue authHeaderValue = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                    Encoding.GetEncoding("ISO-8859-1")
                    .GetBytes(_configuration.ClientId + ":" + _configuration.ClientSecret)));
            _authClient.DefaultRequestHeaders.Accept.Clear();
            _authClient.DefaultRequestHeaders.Accept.Add(jsonHeader);
            _authClient.DefaultRequestHeaders.Authorization = authHeaderValue;
            _authRequestContent = new FormUrlEncodedContent(
                new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" }
                });
        }

        public async Task<IApiResponse> MakeApiRequestAsync(string path)
        {
            var response = await _apiClient.GetAsync(_configuration.GetApiUrl() + path);
            return new ApiResponse(response);
        }

        public async Task<IApiResponse> RequestAccessTokenAsync()
        {
            var response =  await _authClient.PostAsync(_configuration.GetAuthUrl(), _authRequestContent);
            return new ApiResponse(response);
        }
    }
}
