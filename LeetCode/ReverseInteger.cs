using System.Numerics;

namespace LeetCode;

public class ReverseInteger
{
    // A simpler but less memory efficient solution
    public int ReverseSimple(int num)
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

    // A more complex but memory efficient solution
    public int Reverse(int num)
    {
        long reversed = 0;
        while (num != 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;

            // Check for overflow
            if (reversed > int.MaxValue || reversed < int.MinValue)
            {
                return 0;
            }
        }
        return (int)reversed;
    }
}
