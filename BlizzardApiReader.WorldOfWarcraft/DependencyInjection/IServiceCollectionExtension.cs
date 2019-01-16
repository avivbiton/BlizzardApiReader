using BlizzardApiReader.Core;
using BlizzardApiReader.Core.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace BlizzardApiReader.WorldOfWarcraft
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBlizzardApiReaderWorldOfWarcraft(this IServiceCollection services, HttpConfiguration httpConfiguration=null)
        {
            services.AddBlizzardApiReader(httpConfiguration);
            services.AddScoped<WorldOfWarcraftApi>();            
            return services;
        }

    }
}
