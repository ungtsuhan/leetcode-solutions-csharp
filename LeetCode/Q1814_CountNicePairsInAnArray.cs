namespace LeetCode;

public class Q1814
{
    // Time Complexity: O(n * log10(num))
    // Space Complexity: O(n)

    private const int MODULUS = 1_000_000_007;

    public static int CountNicePairs(int[] nums)
    {
        var numOfPairs = 0;
        Dictionary<int, int> dict = [];
        foreach (var num in nums) // O(n)
        {
            int numMinusReverseNum = num - Reverse(num); // O(log10(num))
            if (dict.TryGetValue(numMinusReverseNum, out int currentCount)) // O(1)
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

    private static int Reverse(int num) // O(numOfDigits) or O(log10(num))
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
