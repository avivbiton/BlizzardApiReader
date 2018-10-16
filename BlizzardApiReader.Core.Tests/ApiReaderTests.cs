using BlizzardApiReader.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiReaderTests
    {
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
        public void GetAsync_ShouldThrowWithoutTokenTest()
        {
            var reader = new ApiReader(ApiConfiguration.CreateDefault());
            Task.Run(async () =>
            {
                try
                {
                    await reader.GetAsync<object>("anyquery");
                    Assert.Fail();
                }
                catch (NullReferenceException ex)
                {
                
                }
                catch
                {
                    Assert.Fail();
                }

            }).GetAwaiter().GetResult();

        }


        //TODO: continue adding tests with mock lib

    }
}
