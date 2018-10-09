using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace BlizzardApiReader.Core.Tests.Miscellaneous
{
    [TestClass]
    public class JsonDeserializationTests
    {
        #region DeserializeObject
        [TestMethod]
        public void DeserializeObject_SnakeCaseProperty_PascalCase()
        {
            var json = @"{
                'id': '123',
                'last_updated': '2018-01-01T00:00:00'
            }";

            var obj = JsonConvert.DeserializeObject<PascalCaseJsonDeserializationTestModel>(json);

            var expectedResult = new PascalCaseJsonDeserializationTestModel()
            {
                Id = "123",
                LastUpdated = new DateTime(2018, 1, 1),
            };

            obj.Should().BeEquivalentTo(expectedResult);
        }
        #endregion
    }

    public class PascalCaseJsonDeserializationTestModel
    {
        public string Id { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public DateTime LastUpdated { get; set; }
    }
}
