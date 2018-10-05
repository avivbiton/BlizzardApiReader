using BlizzardApiReader.Core.Attributes;
using BlizzardApiReader.Core.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Core.Tests.Extensions
{
    [TestClass]
    public class EnumNameAttributeTests
    {
        public const string AttributeName = "Donald Duck";

        #region GetEnumName
        [TestMethod]
        public void GetEnumName_WithoutAttribute_ValueString()
        {
            var valueString = EnumNameAttributeTestModel.WithoutAttribute.ToString();

            var enumName = EnumNameAttributeTestModel
                .WithoutAttribute
                .GetEnumName();

            enumName.Should().BeEquivalentTo(valueString);
            enumName.Should().NotBe(AttributeName);
        }

        [TestMethod]
        public void GetEnumName_WithAttribute_AttributeName()
        {
            var valueString = EnumNameAttributeTestModel.WithAttribute.ToString();

            var enumName = EnumNameAttributeTestModel
                .WithAttribute
                .GetEnumName();

            enumName.Should().NotBe(valueString);
            enumName.Should().BeEquivalentTo(AttributeName);
        }
        #endregion
    }

    public enum EnumNameAttributeTestModel
    {
        WithoutAttribute,
        [EnumName(EnumNameAttributeTests.AttributeName)]
        WithAttribute,
    }
}
