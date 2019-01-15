using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using BlizzardApiReader.Core.Enums;
using System.Net.Http.Headers;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace BlizzardApiReader.Core.DependencyInjection
{
    public static class IServiceCollectionExtension
    {        
        public static IServiceCollection AddBlizzardApiReader(this IServiceCollection services, HttpConfiguration httpConfiguration =null )
        {
            if (httpConfiguration != null)
            {
                SocketsHttpHandler socketsHttpHandler;

                socketsHttpHandler = new SocketsHttpHandler()
                {
                    Proxy = httpConfiguration.GetHttpProxy(),
                    PooledConnectionLifetime = httpConfiguration.GetPooledConnectionLifetime()
                };


                services.AddHttpClient(NamedHttpClients.ApiClient.ToString())
                    .ConfigurePrimaryHttpMessageHandler(() => socketsHttpHandler)
                    .ConfigureHttpClient(client => client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));

                services.AddHttpClient(NamedHttpClients.AuthClient.ToString())
                    .ConfigurePrimaryHttpMessageHandler(() => socketsHttpHandler)
                    .ConfigureHttpClient(client => client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));
            }
            else
            {
                services.AddHttpClient(NamedHttpClients.ApiClient.ToString())                    
                    .ConfigureHttpClient(client => client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));

                services.AddHttpClient(NamedHttpClients.AuthClient.ToString())                    
                    .ConfigureHttpClient(client => client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")));
            }

            //Using TryAdd... in case it is already added
            //TODO: Move to TryAddScoped or Transient if possible to be more multithread friendly
            services.TryAddSingleton<ApiReader>();
            services.TryAddSingleton<IWebClient,ApiWebClient>();
                        
            return services;
        }        
    }
}
