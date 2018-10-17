using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BlizzardApiReader.Core.Models;

namespace BlizzardApiReader.Core
{
    public class ApiWebClient : IWebClient
    {

        private const string AUTH_URL = "https://REGION.battle.net/oauth/token";


        public async Task<HttpResponseMessage> MakeHttpRequestAsync(string urlRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return await client.GetAsync(urlRequest);
            }
        }

        public async Task<HttpResponseMessage> RequestAccessTokenAsync(ApiConfiguration configuration)
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

                return await client.PostAsync(url, requestContent);
            }
        }

        private AuthenticationHeaderValue authenticate(string user, string password)
        {
            String encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(user + ":" + password));
            return new AuthenticationHeaderValue("Basic", encoded);
        }
    }
}
