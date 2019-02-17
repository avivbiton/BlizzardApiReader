using System.Net.Http;
using System.Threading.Tasks;
namespace BlizzardApiReader.Core
{
    public interface IWebClient
    {
        Task<IApiResponse> MakeApiRequestAsync(string path);
        Task<IApiResponse> RequestAccessTokenAsync();        
    }
}
