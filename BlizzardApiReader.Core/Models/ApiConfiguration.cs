using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using System;
using System.Net;

namespace BlizzardApiReader.Core
{
    public class ApiConfiguration
    {
        public Region ApiRegion;
        public Locale ResultLocale;
        public string ClientId;
        public string ClientSecret;

        private const string AUTH_URL_TEMPLATE = "https://REGION.battle.net/oauth/token";
        private const string API_URL_TEMPLATE = "https://REGION.api.blizzard.com";
        private string authUrl = string.Empty;
        private string apiUrl = string.Empty;
                
        public ApiConfiguration()
        {
            SetRegion(Region.Europe, true);
            ResultLocale = ApiRegion.GetDefaultLocale();
        }

        public static ApiConfiguration Create()
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
            apiUrl = API_URL_TEMPLATE.Replace("REGION", GetRegionString());
            authUrl = AUTH_URL_TEMPLATE.Replace("REGION", GetRegionString());
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

        public string GetAuthUrl()
        {
            return authUrl;
        }

        public string GetApiUrl()
        {
            return apiUrl;
        }
    }
}
