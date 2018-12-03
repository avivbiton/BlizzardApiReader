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

        private WebProxy _WebProxy = null;
        private TimeSpan _PooledConnectionLifetime = TimeSpan.FromMinutes(1);

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
        /// Set the http proxy to use on all the calls, by default is not configured (null) and to remove it you need to call it to with ""
        /// </summary>
        /// <param name="proxy">URL with the proxy to use, for example http://server:port </param>        
        /// <returns>This instance of ApiConfiguration</returns>
        public ApiConfiguration SetHttpProxy(string proxy)
        {
            if (proxy == "")
            {
                _WebProxy = null;
            }
            else
            {
                _WebProxy = new WebProxy()
                {
                    Address = new Uri(proxy),
                    UseDefaultCredentials = true
                };
            }

            return this;
        }

        /// <summary>
        /// Configure the lifetime of the connection for refreshing DNS queries, by default is 1 minute
        /// </summary>
        /// <param name="pooledConnectionLifetime">Lifetime in minutes</param>        
        /// <returns>This instance of ApiConfiguration</returns>
        public ApiConfiguration SetPooledConnectionLifetime(int pooledConnectionLifetime)
        {
            _PooledConnectionLifetime = TimeSpan.FromMinutes(pooledConnectionLifetime);
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

        public WebProxy GetHttpProxy()
        {
            return _WebProxy;
        }
        public TimeSpan GetPooledConnectionLifetime()
        {
            return _PooledConnectionLifetime;
        }
    }
}
