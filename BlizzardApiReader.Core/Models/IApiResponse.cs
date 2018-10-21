using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public interface IApiResponse
    {
        bool IsSuccessful();
        Task<string> ReadContentAsync();
    }
}
