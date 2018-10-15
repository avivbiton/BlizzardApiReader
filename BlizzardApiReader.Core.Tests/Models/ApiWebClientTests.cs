using BlizzardApiReader.Core.Enums;
using BlizzardApiReader.Core.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiWebClientTests
    {


        [TestMethod]
        public void Test()
        {
            Task.Run(async () =>
            {
                ApiWebClient client = new ApiWebClient();
                var config = ApiConfiguration.Default().SetRegion(Region.Europe).SetClientId("invalid")
                .SetClientSecret("invalid");
                

                var request = await client.RequestAccessTokenAsync(config);

                string token = await request.Content.ReadAsStringAsync();

                throw new Exception(token);
            }).GetAwaiter().GetResult();

        }
    }
}
