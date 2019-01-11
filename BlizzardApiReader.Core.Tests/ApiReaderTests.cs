using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Reflection;
using Microsoft.Extensions.Options;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiReaderTests
    {

        private IOptions<ApiConfiguration> defaultConfig =  Options.Create<ApiConfiguration>(new ApiConfiguration());

        [TestMethod]
        public void GetAsync_ShouldThrowIfInvalidTest()
        {
            Task.Run(async () =>
            {
                try
                {
                    var reader = new ApiReader();
                    // reader has no configuration nor token

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

                client.Setup(i => i.RequestAccessTokenAsync()).ReturnsAsync(response.Object);

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

                client.Setup(i => i.RequestAccessTokenAsync()).ReturnsAsync(response.Object);
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

        [TestMethod]
        public void SendRequest_ShouldRequestANewTokenIfExpired()
        {

            Task.Run(async () =>
            {

                string expired = readMockDataFromFile($"/../../../MockData/expiredTokenMock.json");
                string valid = readMockDataFromFile($"/../../../MockData/tokenMock.json");
                var expectedDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(valid);

                var client = new Mock<IWebClient>();
                var response = new Mock<IApiResponse>();
                response.Setup(i => i.IsSuccessful()).Returns(true);
                response.Setup(i => i.ReadContentAsync()).ReturnsAsync(expired);

                client.Setup(i => i.RequestAccessTokenAsync()).ReturnsAsync(response.Object);
                client.Setup(i => i.MakeApiRequestAsync(It.IsAny<string>())).ReturnsAsync(response.Object);

                var reader = new ApiReader(defaultConfig, client.Object);
                try
                {
                    await reader.GetAsync<Dictionary<string, string>>("anything");
                    response.Setup(i => i.ReadContentAsync()).ReturnsAsync(valid);
                    var answer = await reader.GetAsync<Dictionary<string, string>>("anything");
                    answer.Should().BeEquivalentTo(expectedDict);
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
