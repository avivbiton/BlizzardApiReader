using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using System;

namespace BlizzardApiReader.Core.Models
{
    public class ApiConfiguration
    {
        public Region ApiRegion;
        public Locale ResultLocale;
        public string ClientId;
        public string ClientSecret;

        public ApiConfiguration()
        {
            ResultLocale = ApiRegion.GetDefaultLocale();
        }
       
        public static ApiConfiguration Default()
        {
            return new ApiConfiguration();
        }

        public ApiConfiguration SetClientId(string clientId)
        {
            ClientId = clientId;
            return this;
        }


        public ApiConfiguration SetClientSecret(string clientSecret)
        {
            ClientSecret = clientSecret;
            return this;
        }

        public ApiConfiguration SetRegion(Region region)
        {
            return SetRegion(region, false);
        }

        /// <summary>
        /// Set the region of the ApiConfiguration with locale set to default locale of region if bool is set to true
        /// </summary>
        /// <param name="region">The region to set</param>
        /// <param name="useDefaultLocale">Determines whether locale should be set based on default locale of region</param>
        /// <returns>This instance of ApiConfiguration</returns>
        public ApiConfiguration SetRegion(Region region, bool useDefaultLocale)
        {
            ApiRegion = region;
            if (useDefaultLocale)
            {
                ResultLocale = region.GetDefaultLocale();
            }
            return this;
        }

        public ApiConfiguration SetLocale(Locale locale)
        {
            ResultLocale = locale;
            return this;
        }

        /// <summary>
        /// Declare this Configuration as the global default configuration, it will be used when no configuration is provided to the api reader.
        /// </summary>  
        public ApiConfiguration DeclareAsDefault()
        {
            ApiReader.SetDefaultConfiguration(this);
            return this;
        }

        public string GetLocaleString()
        {
            return ResultLocale.GetEnumValue();
        }
        public string GetRegionString()
        {
            return ApiRegion.GetEnumValue();
        }
    }
}
