public static class Q0091
{
    public static int HammingWeight(uint n)
    {
        uint mask = 1;
        int result = 0;
        while (n != 0)
        {
            result += (int)(n & mask);
            n >>= 1;
        }
        return result;
    }
}
