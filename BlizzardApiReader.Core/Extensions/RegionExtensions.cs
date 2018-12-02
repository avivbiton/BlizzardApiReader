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
                case Region.Europe:
                    return Locale.BritishEnglish;
                case Region.Korea:
                    return Locale.Korean;
                case Region.Taiwan:
                    return Locale.TraditionalChinese;
                case Region.SoutheastAsia:
                case Region.UnitedStates:
                    return Locale.AmericanEnglish;
                case Region.China:
                    return Locale.SimplifiedChinese;
                default:
                    throw new NotImplementedException($"The {nameof(Region)} [{region.ToString()}] does not have an associated {nameof(Locale)}");
            }
        }

        public static bool IsLocaleAvailable (this Region region, Locale locale)
        {
            switch (region)
            {
                case Region.Europe:
                    return (Locale.BritishEnglish==locale) || 
                        (Locale.SpainSpanish==locale) || 
                        (Locale.French==locale) ||
                        (Locale.Russian==locale) ||
                        (Locale.German==locale) ||
                        (Locale.PortugalPortuguese==locale) ||
                        (Locale.Italian==locale);
                case Region.Korea:
                    return Locale.Korean==locale;
                case Region.Taiwan:
                    return Locale.TraditionalChinese==locale;
                case Region.SoutheastAsia:
                case Region.UnitedStates:
                    return (Locale.AmericanEnglish==locale) ||
                        (Locale.MexicanSpanish==locale) ||
                        (Locale.BrazilianPortuguese==locale);
                case Region.China:
                    return Locale.SimplifiedChinese==locale;
                default:
                    throw new NotImplementedException($"The {nameof(Region)} [{region.ToString()}] does not have an associated {nameof(Locale)}");
            }
        }
    }
}
