using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using System.Net.Http;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiReaderTests
    {

        private ApiConfiguration defaultConfig = ApiConfiguration.CreateDefault();

        [TestMethod]
        public void GetAsync_ShouldThrowIfInvalidTest()
        {
            var reader = new ApiReader();
            // reader has no configuration nor token

            Task.Run(async () =>
            {
                try
                {
                    await reader.GetAsync<object>("anyquery");
                    Assert.Fail();
                }
                catch
                {

                }

            }).GetAwaiter().GetResult();

        }

        [TestMethod]
        public void SendRequestToken_ShouldGetTokenFromJsonCorrectly()
        {

            Task.Run(async () =>
            {

                string json = readMockDataFromFile($"/../../../MockData/tokenMock.json");

                var client = new Mock<IWebClient>();
                var response = new Mock<IApiResponse>();
                response.Setup(i => i.IsSuccessful()).Returns(true);
                response.Setup(i => i.ReadContentAsync()).ReturnsAsync(json);

                client.Setup(i => i.RequestAccessTokenAsync(defaultConfig)).ReturnsAsync(response.Object);

                var reader = new ApiReader(defaultConfig, client.Object);
                try
                {
                    string token = await reader.SendTokenRequest();
                    token.Should().Be("TOKENGOESHERE");
                }
                catch
                {
                    Assert.Fail();
                }

            }).GetAwaiter().GetResult();
        }


        [TestMethod]
        public void SendTokenRequest_ShouldThrowWhenNotSuccessful()
        {
            Task.Run(async () =>
            {
                var client = new Mock<IWebClient>();
                var response = new Mock<IApiResponse>();
                response.Setup(i => i.IsSuccessful()).Returns(false);

                client.Setup(i => i.RequestAccessTokenAsync(defaultConfig)).ReturnsAsync(response.Object);
                var reader = new ApiReader(defaultConfig, client.Object);
                try
                {

                    await reader.SendTokenRequest();
                    Assert.Fail();
                }
                catch (HttpRequestException ex)
                {

                }
                catch
                {
                    Assert.Fail();
                }

            }).GetAwaiter().GetResult();
        }

        private string readMockDataFromFile(string path)
        {
            return File.ReadAllText($"{Directory.GetCurrentDirectory()}{path}");
        }


    }
}
