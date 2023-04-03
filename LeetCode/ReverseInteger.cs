using System.Numerics;

namespace LeetCode;

public class ReverseInteger
{
    public int Reverse(BigInteger num)
    {
        var str = num.ToString();

        var isNegative = str.StartsWith("-");
        var unsignedStr = str.Replace("-", "");

        var arr = unsignedStr
            .ToArray()
            .Select(c => (int)Char.GetNumericValue(c));

        var reverseArr = arr.Reverse();
        var reverseStr = string.Join("", reverseArr);

        var signedStr = isNegative
            ? $"-{reverseStr}"
            : reverseStr;

        var reverseBigNum = BigInteger.Parse(signedStr);

        if (reverseBigNum > int.MaxValue || reverseBigNum < int.MinValue)
            return 0;

        return (int)reverseBigNum;
    }
}
