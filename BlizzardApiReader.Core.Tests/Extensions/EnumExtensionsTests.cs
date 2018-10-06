using BlizzardApiReader.Core.Attributes;
using BlizzardApiReader.Core.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Core.Tests.Extensions
{
    [TestClass]
    public class EnumExtensionsTests
    {
        public const string AttributeName = "Donald Duck";

        #region GetEnumValue
        [TestMethod]
        public void GetEnumValue_WithoutAttribute_ValueString()
        {
            var valueString = EnumValueAttributeTestModel.WithoutAttribute.ToString();

            var enumValue = EnumValueAttributeTestModel
                .WithoutAttribute
                .GetEnumValue();

            enumValue.Should().BeEquivalentTo(valueString);
            enumValue.Should().NotBe(AttributeName);
        }

        [TestMethod]
        public void GetEnumValue_WithAttribute_AttributeName()
        {
            var valueString = EnumValueAttributeTestModel.WithAttribute.ToString();

            var enumValue = EnumValueAttributeTestModel
                .WithAttribute
                .GetEnumValue();

            enumValue.Should().NotBe(valueString);
            enumValue.Should().BeEquivalentTo(AttributeName);
        }
        #endregion
    }

    public enum EnumValueAttributeTestModel
    {
        WithoutAttribute,
        [EnumValue(EnumExtensionsTests.AttributeName)]
        WithAttribute,
    }
}
