namespace LeetCode;

public class ReverseInteger
{
    public int Reverse(int num)
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

        var reverseNum = Convert.ToInt32(signedStr);

        return reverseNum;
    }
}
