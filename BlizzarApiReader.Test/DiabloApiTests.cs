using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlizzardApiReader;
using BlizzardApiReader.Diablo;
using BlizzardApiReader.WebClient;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;

namespace BlizzarApiReader.Test
{
    [TestFixture]
    public class DiabloApiTests
    {
        private Mock<IWebClient> webClient;
        private ApiConfiguration configuration;
        private DiabloApi diabloApi;
        [SetUp]
        public void Init()
        {
            webClient = new Mock<IWebClient>();
            configuration = new ApiConfiguration
            {
                ApiKey = "testKey",
                ApiRegion = Region.EU,
                ResultLocale = Locale.en_GB
            };
            diabloApi = new DiabloApi(configuration, webClient.Object);
        }

        [Test]
        public async Task GetActIndexAsync_Should_Form_Correct_Url()
        {
            var expectedUrl = "https://eu.api.battle.net/d3/data/act/?locale=en_GB&apikey=testKey";
            var json = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}/../../TestData/getActIndex.json");
            webClient.Setup(x => x.MakeHttpRequest(expectedUrl)).ReturnsAsync(json);
            await diabloApi.GetActIndexAsync();
            webClient.Verify(x => x.MakeHttpRequest(expectedUrl), Times.Once);
        }

        [Test]
        public async Task GetActIndexAsync_Should_Parse_Json_Correctly()
        {
            var expectedUrl = "https://eu.api.battle.net/d3/data/act/?locale=en_GB&apikey=testKey";
            var json = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}/../../TestData/getActIndex.json");
            webClient.Setup(x => x.MakeHttpRequest(expectedUrl)).ReturnsAsync(json);
            var result = await diabloApi.GetActIndexAsync();
            result.First().name.Should().NotBeNullOrWhiteSpace();
            result.First().slug.Should().NotBeNullOrWhiteSpace();
            result.First().number.Should().NotBe(0);
            result.First().quests.Should().NotContainNulls();
        }
    }
}
