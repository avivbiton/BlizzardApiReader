using System.Net.Http;
using System.Threading.Tasks;
using BlizzardApiReader.Core.Models;
namespace BlizzardApiReader.Core
{
    public interface IWebClient
    {

        Task<HttpResponseMessage> MakeHttpRequestAsync(string query);

        Task<HttpResponseMessage> RequestAccessTokenAsync(ApiConfiguration configuration);

    }
}
