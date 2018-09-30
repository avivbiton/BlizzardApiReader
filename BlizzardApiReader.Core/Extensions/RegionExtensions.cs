using BlizzardApiReader.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Extensions
{
    public static class RegionExtensions
    {
        public static Locale GetDefaultLocale(this Region region)
        {
            switch (region)
            {
                case Region.EU:
                case Region.Europe:
                    return Locale.BritishEnglish;
                case Region.KR:
                case Region.Korea:
                    return Locale.Korean;
                case Region.TW:
                case Region.Taiwan:
                    return Locale.TraditionalChinese;
                case Region.SEA:
                case Region.SoutheastAsia:
                case Region.US:
                case Region.UnitedStates:
                    return Locale.AmericanEnglish;
                default:
                    throw new NotImplementedException($"The {nameof(Region)} [{region.ToString()}] does not have an associated {nameof(Locale)}");
            }
        }
    }
}
