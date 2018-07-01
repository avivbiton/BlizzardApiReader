using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader
{
    public enum Region { EU, KR, SEA, TW, US  }
    public enum Locale { en_GB, ko_KR, zh_TW, en_US }


    //TODO: add caching?
    public class ApiConfiguration
    {
        public Region ApiRegion;
        public Locale locale;
        public string Key;

        public static string GetLocaleString(Locale locale)
        {
            return Enum.GetName(typeof(Locale), locale);
        }
        public static string GetRegionString(Region region)
        {
            return Enum.GetName(typeof(Region), region);
        }
    }
}
