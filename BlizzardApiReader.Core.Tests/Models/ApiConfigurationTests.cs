using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
namespace BlizzardApiReader.Core.Tests
{


    ** need to update these tests to the new system
    * 

    [TestClass]
    public class ApiConfigurationTests
    {
        #region Constructor
        [TestMethod]
        public void Constructor_NoParameter_DefaultConfigurations()
        {
            var configuration = new ApiConfiguration();

            configuration.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
            configuration.ApiKey.Should().BeNull();
        }

        [TestMethod]
        public void Constructor_ApiKeyParameter_DefaultConfigurations()
        {
            var configuration = new ApiConfiguration("anyapikey");

            configuration.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }

        [TestMethod]
        public void Constructor_RegionParameter_DefaultLocale()
        {
            var configuration = new ApiConfiguration(Region.Europe, "anyapikey");

            configuration.ApiRegion.Should().BeEquivalentTo(Region.Europe);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.BritishEnglish);
        }

        [TestMethod]
        public void Constructor_AllParameters_Configurations()
        {
            var configuration = new ApiConfiguration(Region.Europe, Locale.Korean, "anyapikey");

            configuration.ApiRegion.Should().BeEquivalentTo(Region.Europe);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.Korean);
        }
        #endregion

        #region CreateEmpty
        [TestMethod]
        public void CreateEmpty_NoParameter_DefaultConfigurations()
        {
            var config = ApiConfiguration.CreateEmpty();

            config.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            config.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
            config.ApiKey.Should().BeNull();
        }
        #endregion

        #region SetRegion
        [TestMethod]
        public void SetRegion_RegionParameter_ExpectedRegion()
        {
            var config = new ApiConfiguration(Region.UnitedStates, Locale.AmericanEnglish, "anyapikey");

            config = config.SetRegion(Region.Korea);
            config.ApiRegion.Should().BeEquivalentTo(Region.Korea);
            config.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }

        [TestMethod]
        public void SetRegion_UseDefaultLocale_ExpectedLocale()
        {
            var config = new ApiConfiguration(Region.UnitedStates, Locale.AmericanEnglish, "anyapikey");

            config = config.SetRegion(Region.Korea, true);
            config.ApiRegion.Should().BeEquivalentTo(Region.Korea);
            config.ResultLocale.Should().BeEquivalentTo(Locale.Korean);
        }

        [TestMethod]
        public void SetRegion_DoNotUseDefaultLocale_ExpectedLocale()
        {
            var config = new ApiConfiguration(Region.UnitedStates, Locale.AmericanEnglish, "anyapikey");

            config = config.SetRegion(Region.Korea, false);
            config.ApiRegion.Should().BeEquivalentTo(Region.Korea);
            config.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }
        #endregion

        #region SetLocale
        [TestMethod]
        public void SetLocale_LocaleParameter_ExpectedLocale()
        {
            var config = new ApiConfiguration(Region.UnitedStates, Locale.AmericanEnglish, "anyapikey");

            config = config.SetLocale(Locale.TraditionalChinese);
            config.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            config.ResultLocale.Should().BeEquivalentTo(Locale.TraditionalChinese);
        }
        #endregion

        #region UseDefaultLocale
        [TestMethod]
        public void UseDefaultLocale_NoParameter_ExpectedLocale()
        {
            var config = new ApiConfiguration(Region.UnitedStates, Locale.Korean, "anyapikey");

            config = config.UseDefaultLocale();
            config.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }
        #endregion
    }
}
*/