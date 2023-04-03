using System.Numerics;

namespace LeetCode.Tests;

public class ReverseIntegerTests
{
    ReverseInteger reverseInteger;

    public ReverseIntegerTests()
    {
        reverseInteger = new ReverseInteger();
    }

    [Fact]
    public void GivenSimpleNumber()
    {
        var num = 123;

        var result = reverseInteger.Reverse(num);

        var expected = 321;
        result.Should().Be(expected);
    }

    [Fact]
    public void GivenNegativeNumber()
    {
        var num = -123;

        var result = reverseInteger.Reverse(num);

        var expected = -321;
        result.Should().Be(expected);
    }

    [Fact]
    public void GivenNumberThatOverFlows_ThenReturnsZero()
    {
        var num = 1534236469;

        var result = reverseInteger.Reverse(num);

        var expected = 0;
        result.Should().Be(expected);
    }
}
