using TownleyPlayground;

namespace FastTests;

public class RomanNumeralTests
{
    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void SingleNumerals(string romanRepresentation, int expectedDecimalRepresentation) => Assert.Equal(expectedDecimalRepresentation, RomanNumeral.Parse(romanRepresentation).DecimalRepresentation);

    [Theory]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("VI", 6)]
    [InlineData("VII", 7)]
    [InlineData("XVI", 16)]
    [InlineData("DLXVII", 567)]
    [InlineData("MDXXXII", 1532)]
    public void NoSubtractions(string romanRepresentation, int expectedDecimalRepresentation) => Assert.Equal(expectedDecimalRepresentation, RomanNumeral.Parse(romanRepresentation).DecimalRepresentation);

    [Theory]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CDXL", 440)]
    [InlineData("CMXLIX", 949)]
    public void WithSubtractions(string romanRepresentation, int expectedDecimalRepresentation) => Assert.Equal(expectedDecimalRepresentation, RomanNumeral.Parse(romanRepresentation).DecimalRepresentation);

    [Theory]
    [InlineData("IIII")]
    [InlineData("VIIII")]
    [InlineData("XXXX")]
    [InlineData("VV")]
    [InlineData("DD")]
    public void InvalidAdditions(string romanRepresentation) => Assert.Throws<FormatException>(() => RomanNumeral.Parse(romanRepresentation).DecimalRepresentation);

    [Theory]
    [InlineData("IIV")]
    [InlineData("IIX")]
    [InlineData("VX")]
    [InlineData("XM")]
    public void InvalidSubtractions(string romanRepresentation) => Assert.Throws<FormatException>(() => RomanNumeral.Parse(romanRepresentation).DecimalRepresentation);

    [Fact]
    public void InvalidChar() => Assert.Throws<FormatException>(() => RomanNumeral.Parse("T"));
}
