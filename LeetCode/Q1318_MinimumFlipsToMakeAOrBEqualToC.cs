namespace LeetCode;

public class Q1318
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int MinFlips(int a, int b, int c)
    {
        int total = 0;
        while (a > 0 || b > 0 || c > 0)
        {
            int x = a & 1;
            int y = b & 1;
            int z = c & 1;

            if (z == 1 && x == 0 && y == 0)
                total++;

            else if (z == 0)
                total += x + y;

            a >>= 1;
            b >>= 1;
            c >>= 1;
        }
        return total;
    }
}
