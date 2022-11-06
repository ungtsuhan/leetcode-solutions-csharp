public static class Q0344
{
    public static char[] ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (right > left)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
        return s;
    }
}

public class Q0344_Tests
{
    [Theory]
    [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
    public void ReverseString_ReverseString(char[] input, char[] expected)
    {
        var result = Q0344.ReverseString(input);
        Assert.Equal(expected, result);
    }
}
