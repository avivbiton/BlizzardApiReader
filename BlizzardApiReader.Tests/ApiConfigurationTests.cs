using System;
using BlizzardApiReader.Core.Enums;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Tests
{
    [TestClass]
    public class ApiConfigurationTests
    {
        #region Constructor
        [TestMethod]
        public void Constructor_NoParameters_DefaultConfigurations()
        {
            var configuration = new ApiConfiguration();

            configuration.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }

        [TestMethod]
        public void Constructor_ApiKey_DefaultConfigurations()
        {
            var configuration = new ApiConfiguration("anyapikey");

            configuration.ApiRegion.Should().BeEquivalentTo(Region.UnitedStates);
            configuration.ResultLocale.Should().BeEquivalentTo(Locale.AmericanEnglish);
        }

        [TestMethod]
        public void Constructor_Region_DefaultLocale()
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

        #region SetRegion
        #endregion
    }
}
