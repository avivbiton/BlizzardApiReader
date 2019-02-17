using BlizzardApiReader.Core;
using BlizzardApiReader.Core.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

namespace BlizzardApiReader.Starcraft2
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBlizzardApiReaderStarcraft2(this IServiceCollection services, HttpConfiguration httpConfiguration = null)
        {
            services.AddBlizzardApiReader(httpConfiguration);
            services.AddScoped<Starcraft2Api>();
            return services;
        }

    }
}
