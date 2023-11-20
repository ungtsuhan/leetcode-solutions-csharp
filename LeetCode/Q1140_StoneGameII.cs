namespace LeetCode;

public class Q1140
{
    public static int StoneGameII(int[] piles)
    {
        var dict = new Dictionary<(bool, int, int), int>(); // for memoization

        return DFS(true, 0, 1, piles, dict);
    }

    // Depth-first search to calculate the maximum number of stones Alice can get
    private static int DFS(bool aliceTurn, int currentIndex, int M, int[] piles, Dictionary<(bool, int, int), int> dict)
    {
        // Base case: no more stones left
        if (currentIndex == piles.Length)
            return 0;

        if (dict.TryGetValue((aliceTurn, currentIndex, M), out int value))
            return value;

        var result = aliceTurn ? 0 : int.MaxValue;
        var total = 0;

        for (var x = 1; x < 2 * M + 1; x++)
        {
            // Check if taking x stones from the current position is valid
            if (currentIndex + x > piles.Length)
                break;

            total += piles[currentIndex + x - 1];

            if (aliceTurn)
                // Alice's turn: maximize the number of stones Alice can get
                result = Math.Max(result, total + DFS(!aliceTurn, currentIndex + x, Math.Max(M, x), piles, dict));
            else
                // Bob's turn: minimize the number of stones Alice can get (maximize Bob's gain)
                result = Math.Min(result, DFS(!aliceTurn, currentIndex + x, Math.Max(M, x), piles, dict));
        }

        dict.Add((aliceTurn, currentIndex, M), result);

        return result;
    }
}
