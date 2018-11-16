using System.Net.Http;
using System.Threading.Tasks;
namespace BlizzardApiReader.Core
{
    public interface IWebClient
    {

        Task<IApiResponse> MakeHttpRequestAsync(string query);

        Task<IApiResponse> RequestAccessTokenAsync(ApiConfiguration configuration);

    }
}
