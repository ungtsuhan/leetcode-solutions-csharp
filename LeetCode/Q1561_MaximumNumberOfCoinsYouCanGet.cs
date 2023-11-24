namespace LeetCode;

public class Q1561
{
    // Time Complexity: O(n log n)
    // Space Complexity: O(1)

    public static int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        var chances = piles.Length / 3;
        var maxCoins = 0;
        for (var i = 0; i < chances; i++)
        {
            maxCoins += piles[piles.Length - 2 - (i * 2)];
        }
        return maxCoins;
    }
}
