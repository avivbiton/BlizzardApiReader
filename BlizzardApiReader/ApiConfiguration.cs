using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader
{
    public enum Region { EU, KR, SEA, TW, US  }
    public enum Locale { en_GB, ko_KR, zh_TW, en_US }

    public class ApiConfiguration
    {
        public Region ApiRegion;
        public Locale ResultLocale;
        public string ApiKey;

        public string GetLocaleString()
        {
            return Enum.GetName(typeof(Locale), ResultLocale);
        }
        public string GetRegionString()
        {
            return Enum.GetName(typeof(Region), ApiRegion);
        }
    }
}
