using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public class ApiWebClient : IWebClient
    {

        private const string AUTH_URL = "https://REGION.battle.net/oauth/token";


        public async Task<IApiResponse> MakeHttpRequestAsync(string urlRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(urlRequest);
                return new ApiResponse(response);
            }
        }

        public async Task<IApiResponse> RequestAccessTokenAsync(ApiConfiguration configuration)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = authenticate(configuration.ClientId, configuration.ClientSecret);
                var requestContent = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" }
                });
                string url = AUTH_URL.Replace("REGION", configuration.GetRegionString());


                var response =  await client.PostAsync(url, requestContent);
                return new ApiResponse(response);
            }
        }

        private AuthenticationHeaderValue authenticate(string user, string password)
        {
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(user + ":" + password));
            return new AuthenticationHeaderValue("Basic", encoded);
        }
    }
}
