using BlizzardApiReader.Core.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace BlizzardApiReader.WorldOfWarcraft
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBlizzardApiReaderWorldOfWarcraft(this IServiceCollection services)
        {
            services.AddBlizzardApiReader();
            services.AddScoped<WorldOfWarcraftApi>();            
            return services;
        }

    }
}
