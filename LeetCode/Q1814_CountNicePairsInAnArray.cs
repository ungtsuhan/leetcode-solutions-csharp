namespace LeetCode;

public class Q1814
{
    private const int MODULUS = 1_000_000_007;

    public static int CountNicePairs(int[] nums)
    {
        var numOfPairs = 0;
        Dictionary<int, int> dict = [];
        foreach (var num in nums)
        {
            int numMinusReverseNum = num - Reverse(num);
            if (dict.TryGetValue(numMinusReverseNum, out int currentCount))
            {
                numOfPairs = (numOfPairs + currentCount) % MODULUS;
                dict[numMinusReverseNum]++;
            }
            else
            {
                dict[numMinusReverseNum] = 1;
            }
        }
        return numOfPairs;
    }

    private static int Reverse(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
}
