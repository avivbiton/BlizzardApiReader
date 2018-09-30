using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using System;

namespace BlizzardApiReader.Core.Models
{
    public class ApiConfiguration
    {
        public Region ApiRegion;
        public Locale ResultLocale;
        public string ApiKey;

        /// <summary>
        /// Initialize ApiConfiguration with default configurations and empty api key
        /// Default configurations:
        /// - Region.UnitedStates
        /// - Locale.AmericanEnglish
        /// </summary>
        public ApiConfiguration() : this(null)
        {

        }

        /// <summary>
        /// Initialize ApiConfiguration with default configurations and api key
        /// Default configurations:
        /// - Region.UnitedStates
        /// - Locale.AmericanEnglish
        /// </summary>
        /// <param name="apiKey">ApiKey to set</param>
        public ApiConfiguration(string apiKey) : this(Region.UnitedStates, apiKey)
        {

        }

        /// <summary>
        /// Initialize ApiConfiguration with locale based on default locale of region and api key
        /// </summary>
        /// <param name="region">Region to set</param>
        /// <param name="apiKey">ApiKey to set</param>
        public ApiConfiguration(Region region, string apiKey) : this(region, region.GetDefaultLocale(), apiKey)
        {

        }

        /// <summary>
        /// Initialize ApiConfiguration
        /// </summary>
        /// <param name="region">Region to set. Defaults to UnitedStates</param>
        /// <param name="locale">Locale to set. Defaults to AmericanEnglish</param>
        /// <param name="apiKey">ApiKey to set</param>
        public ApiConfiguration(Region region, Locale locale, string apiKey)
        {
            ApiRegion = region;
            ResultLocale = locale;
            ApiKey = apiKey;
        }

        /// <summary>
        /// Default configurations: Region.UnitedStates, Locale.AmericanEnglish
        /// </summary>
        [Obsolete("Enum values and are non-nullable and will always default to the first value within the enumeration even if no value was explicitly assigned. Creating an empty configuration is impossible, default configurations will be used. Please use constructor method instead")]
        public static ApiConfiguration CreateEmpty()
        {
            return new ApiConfiguration();
        }

        public ApiConfiguration SetApiKey(string key)
        {
            ApiKey = key;
            return this;
        }

        /// <summary>
        /// Set the region of the ApiConfiguration
        /// </summary>
        /// <param name="region">The region to set</param>
        /// <returns>This instance of ApiConfiguration</returns>
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
        /// Will use the default locale for the configuration region, must be called only after setting the Region
        /// </summary>
        /// <returns></returns>
        [Obsolete("Please use overload of SetRegion to assign default locale of Region to configuration locale")]
        public ApiConfiguration UseDefaultLocale()
        {
            ResultLocale = ApiRegion.GetDefaultLocale();
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
            return ResultLocale.GetEnumName();
        }
        public string GetRegionString()
        {
            return ApiRegion.GetEnumName();
        }
    }
}
