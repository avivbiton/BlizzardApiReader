using BlizzardApiReader.Core;
using BlizzardApiReader.Core.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace BlizzardApiReader.Diablo
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddBlizzardApiReaderDiablo(this IServiceCollection services, HttpConfiguration httpConfiguration=null)
        {
            services.AddBlizzardApiReader(httpConfiguration);
            services.AddScoped<DiabloApi>();            
            return services;
        }

    }
}
