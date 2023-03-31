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
    public void GivenLargeNumber()
    {
        BigInteger num = 1534236469;

        var result = reverseInteger.Reverse(num);

        BigInteger expected = 9646324351;
        result.Should().Be(expected);
    }
}
