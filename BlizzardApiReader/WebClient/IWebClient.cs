using System.Threading.Tasks;

namespace BlizzardApiReader.WebClient
{
    public interface IWebClient
    {
        Task<string> MakeHttpRequest(string urlRequest);
    }
}