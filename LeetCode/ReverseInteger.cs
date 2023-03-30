namespace LeetCode;

public class ReverseInteger
{
    public int Reverse(int num)
    {
        var arr = num
            .ToString()
            .ToArray()
            .Select(c => (int)Char.GetNumericValue(c));

        var reverseArr = arr.Reverse();

        var reverseStr = string.Join("", reverseArr);
        var reverseNum = Convert.ToInt32(reverseStr);

        return reverseNum;
    }
}
