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

        #region IsLocaleAvailable        
        [DataTestMethod]
        [DataRow(Region.UnitedStates,Locale.AmericanEnglish)]
        [DataRow(Region.UnitedStates, Locale.MexicanSpanish)]
        [DataRow(Region.UnitedStates, Locale.BrazilianPortuguese)]
        [DataRow(Region.Europe, Locale.BritishEnglish)]
        [DataRow(Region.Europe, Locale.SpainSpanish)]
        [DataRow(Region.Europe, Locale.French)]
        [DataRow(Region.Europe, Locale.Russian)]
        [DataRow(Region.Europe, Locale.German)]
        [DataRow(Region.Europe, Locale.PortugalPortuguese)]
        [DataRow(Region.Europe, Locale.Italian)]
        [DataRow(Region.Korea, Locale.Korean)]
        [DataRow(Region.Taiwan, Locale.TraditionalChinese)]
        [DataRow(Region.China, Locale.SimplifiedChinese)]
        public void ValidLocaleForRegion(Region region, Locale locale)
        {
            region.IsLocaleAvailable(locale).Should().BeTrue();
        }


        [DataTestMethod]
        [DataRow(Region.Europe, Locale.AmericanEnglish)]
        [DataRow(Region.Korea, Locale.AmericanEnglish)]
        [DataRow(Region.Taiwan, Locale.AmericanEnglish)]
        [DataRow(Region.China, Locale.AmericanEnglish)]
        [DataRow(Region.Europe, Locale.MexicanSpanish)]
        [DataRow(Region.Korea, Locale.MexicanSpanish)]
        [DataRow(Region.Taiwan, Locale.MexicanSpanish)]
        [DataRow(Region.China, Locale.MexicanSpanish)]
        [DataRow(Region.Europe, Locale.BrazilianPortuguese)]
        [DataRow(Region.Korea, Locale.BrazilianPortuguese)]
        [DataRow(Region.Taiwan, Locale.BrazilianPortuguese)]
        [DataRow(Region.China, Locale.BrazilianPortuguese)]

        [DataRow(Region.UnitedStates, Locale.BritishEnglish)]

        [DataRow(Region.China, Locale.Korean)]

        [DataRow(Region.Europe, Locale.SimplifiedChinese)]
        public void InvalidLocaleForRegion(Region region, Locale locale)
        {
            region.IsLocaleAvailable(locale).Should().BeFalse();
        }

        #endregion

    }
}
