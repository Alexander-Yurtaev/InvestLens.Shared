using System.Globalization;
using Xunit;
using FluentAssertions;
using InvestLens.Shared.Helpers; // Убедитесь, что пространство имен указано верно

namespace InvestLens.Tests;

public class NumberHelpersTests
{
    private readonly CultureInfo _invariantCulture = CultureInfo.InvariantCulture;

    [Fact]
    public void ConvertValueToString_IntegerValue_FormatsAsN0()
    {
        // Arrange
        decimal value = 123m;

        // Act
        string result = NumberHelpers.ConvertValueToString(value);

        // Assert
        result.Should().Be("123");
    }

    [Fact]
    public void ConvertValueToString_DecimalValue_FormatsAsF1()
    {
        // Arrange
        decimal value = 456.789m;

        // Act
        string result = NumberHelpers.ConvertValueToString(value);

        // Assert
        result.Should().Be("456.8"); // Округление до одного знака по правилам InvariantCulture
    }

    [Fact]
    public void ConvertValueToString_NegativeDecimalValue_FormatsCorrectly()
    {
        // Arrange & Act
        string result = NumberHelpers.ConvertValueToString(-10.5m);

        // Assert
        result.Should().Be("-10.5");
    }

    [Fact]
    public void ConvertPersentValueToString_ConvertsToPercentageWithTwoDecimals()
    {
        // Arrange
        decimal value = 0.1234m;

        // Act
        string result = NumberHelpers.ConvertPersentValueToString(value);

        // Assert
        result.Should().Be("12.34 %");
    }

    [Theory]
    [InlineData("123", typeof(int))]
    [InlineData("123.0", typeof(int))]
    [InlineData("123.45", typeof(decimal))]
    public void ConvertToNumber_StringInput_ReturnsCorrectType(string input, Type expectedType)
    {
        // Act
        object result = NumberHelpers.ConvertToNumber(input);

        // Assert
        result.GetType().Should().Be(expectedType);
    }

    [Fact]
    public void IsInt_WholeNumber_ReturnsTrue()
    {
        // Arrange
        decimal value = 100m;

        // Act
        bool isInt = NumberHelpers.IsInt(value);

        // Assert
        isInt.Should().BeTrue();
    }

    [Fact]
    public void IsInt_FractionalNumber_ReturnsFalse()
    {
        // Arrange
        decimal value = 100.01m;

        // Act
        bool isInt = NumberHelpers.IsInt(value);

        // Assert
        isInt.Should().BeFalse();
    }
}