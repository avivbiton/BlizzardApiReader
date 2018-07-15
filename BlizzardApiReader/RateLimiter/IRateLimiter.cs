using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader
{
    public interface IRateLimiter
    {
        bool IsAtRateLimit();

        void OnApiRequest(ApiReader reader);

    }
}
