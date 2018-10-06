using System;
using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Core.Tests.Extensions
{
    [TestClass]
    public class RegionExtensionsTests
    {
        #region GetDefaultLocale
        [TestMethod]
        public void GetDefaultLocale_Europe_BritishEnglish()
        {
            Region.Europe.GetDefaultLocale().Should().BeEquivalentTo(Locale.BritishEnglish);
        }

        [TestMethod]
        public void GetDefaultLocale_Korea_Korean()
        {
            Region.Korea.GetDefaultLocale().Should().BeEquivalentTo(Locale.Korean);
        }

        [TestMethod]
        public void GetDefaultLocale_Taiwan_TraditionalChinese()
        {
            Region.Taiwan.GetDefaultLocale().Should().BeEquivalentTo(Locale.TraditionalChinese);
        }

        [TestMethod]
        public void GetDefaultLocale_SoutheastAsia_AmericanEnglish()
        {
            Region.SoutheastAsia.GetDefaultLocale().Should().BeEquivalentTo(Locale.AmericanEnglish);
        }

        [TestMethod]
        public void GetDefaultLocale_UnitedStates_AmericanEnglish()
        {
            Region.UnitedStates.GetDefaultLocale().Should().BeEquivalentTo(Locale.AmericanEnglish);
        }
        #endregion
    }
}
