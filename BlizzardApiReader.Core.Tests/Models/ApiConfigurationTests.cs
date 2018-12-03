using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiConfigurationTests
    {

        #region Constructor
        [TestMethod]
        public void Constructor_NoParameter_DefaultConfigurations()
        {
            var configuration = new ApiConfiguration();

            configuration.ApiRegion.Should().BeEquivalentTo(default(Region));
            configuration.ResultLocale.Should().BeEquivalentTo(default(Locale));
            configuration.ClientId.Should().BeNull();
            configuration.ClientSecret.Should().BeNull();
        }

        #endregion

        #region CreateEmpty
        [TestMethod]
        public void CreateDefault_NoParameter_DefaultConfigurations()
        {
            var config = ApiConfiguration.Create();

            config.ApiRegion.Should().BeEquivalentTo(default(Region));
            config.ResultLocale.Should().BeEquivalentTo(default(Locale));
            config.ClientId.Should().BeNull();
            config.ClientSecret.Should().BeNull();
        }
        #endregion

        #region SetRegion

        [TestMethod]
        public void SetRegion_ShouldSetCorrectlyTest()
        {
            var config = new ApiConfiguration();

            config.SetRegion(Region.Taiwan);
            config.ApiRegion.Should().BeEquivalentTo(Region.Taiwan);
        }

        [TestMethod]
        public void SetRegionWithDefaultLocaleTest()
        {
            var config = new ApiConfiguration();

            config.SetRegion(Region.SoutheastAsia, true);
            config.ApiRegion.Should().BeEquivalentTo(Region.SoutheastAsia);
            config.ResultLocale.Should().BeEquivalentTo(Region.SoutheastAsia.GetDefaultLocale());
        }


        [TestMethod]
        public void SetRegion_ShouldNotOverrideLocaleWhenFalse()
        {
            var config = new ApiConfiguration();

            config = config.SetRegion(Region.Korea);
            config.ApiRegion.Should().BeEquivalentTo(Region.Korea);
            config.ResultLocale.Should().BeEquivalentTo(default(Locale));
        }

        #endregion

        #region SetLocale
        [TestMethod]
        public void SetLocale_ShouldSetCorrectlyTest()
        {
            var config = new ApiConfiguration();

            config = config.SetLocale(Locale.TraditionalChinese);
            config.ApiRegion.Should().BeEquivalentTo(default(Region));
            config.ResultLocale.Should().BeEquivalentTo(Locale.TraditionalChinese);
        }
        #endregion

        [TestMethod]
        public void SetClientId_ShouldSetCorrectlyTest()
        {
            var config = new ApiConfiguration();

            config.SetClientId("test");
            config.ClientId.Should().Be("test");
            config.ClientSecret.Should().BeNull();
        }

        [TestMethod]
        public void SetClientSecret_ShouldSetCorrectlyTest()
        {
            var config = new ApiConfiguration();
            config.SetClientSecret("test");
            config.ClientSecret.Should().Be("test");
            config.ClientId.Should().BeNull();
        }


    }
}
