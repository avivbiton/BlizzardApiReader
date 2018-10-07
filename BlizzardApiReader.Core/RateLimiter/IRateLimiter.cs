using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public interface IRateLimiter
    {
        bool IsAtRateLimit();

        void OnHttpRequest(ApiReader reader, HttpResponseMessage response);

    }
}
