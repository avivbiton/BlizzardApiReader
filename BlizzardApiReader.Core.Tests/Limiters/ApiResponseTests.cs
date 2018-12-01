using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class ApiResponseTests
    {
        [TestMethod]
        public void ApiResponse_ShouldBeSuccesful()
        {
            var response = new ApiResponse(new HttpResponseMessage(System.Net.HttpStatusCode.OK));
            response.IsSuccessful().Should().BeTrue();
        }

        [TestMethod]
        public void ApiResponse_ShouldBeUnsuccesful()
        {
            var response = new ApiResponse(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest));
            response.IsSuccessful().Should().BeFalse();
        }
        
        [TestMethod]
        public void ReadContent_ShouldMatch()
        {
            string hello = "Hello";
            var msg = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            msg.Content = new StringContent(hello);
            var response = new ApiResponse(msg);
            Task.Run(async () =>
            {
                return await response.ReadContentAsync();
            }).GetAwaiter().GetResult().Should().Be(hello);
        }
    }
}
