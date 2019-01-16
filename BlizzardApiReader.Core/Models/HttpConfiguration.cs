using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using System;
using System.Net;

namespace BlizzardApiReader.Core
{
    public class HttpConfiguration
    {
        
        private WebProxy _WebProxy = null;
        private TimeSpan _PooledConnectionLifetime = TimeSpan.FromMinutes(1);

        public HttpConfiguration()
        {
            
        }

        /*public static HttpConfiguration Create()
        {
            return new HttpConfiguration();
        }*/

        
        /// <summary>
        /// Set the http proxy to use on all the calls, by default is not configured (null) and to remove it you need to call it to with ""
        /// </summary>
        /// <param name="proxy">URL with the proxy to use, for example http://server:port </param>        
        /// <returns>This instance of ApiConfiguration</returns>
        public HttpConfiguration SetHttpProxy(string proxy)
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
        /// Configure the lifetime of the connection for refreshing DNS queries.
        /// </summary>
        /// <param name="pooledConnectionLifetime">Lifetime in minutes</param>        
        /// <returns>This instance of ApiConfiguration</returns>
        public HttpConfiguration SetPooledConnectionLifetime(int pooledConnectionLifetime)
        {
            _PooledConnectionLifetime = TimeSpan.FromMinutes(pooledConnectionLifetime);
            return this;
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
