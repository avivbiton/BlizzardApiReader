using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlizzardApiReader.WebClient
{
    public class WebClient : IWebClient
    {
        public async Task<string> MakeHttpRequest(string urlRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(urlRequest);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                throw new HttpRequestException();
                //TODO Add logging or throw exception(aunauthorized, etc...)
            }
        }
    }
}
