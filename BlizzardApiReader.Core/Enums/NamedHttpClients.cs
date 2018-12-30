using BlizzardApiReader.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Enums
{
    public enum NamedHttpClients
    {
        [EnumValue("ApiClient")]
        ApiClient,
        [EnumValue("AuthClient")]
        AuthClient        
    }
}
