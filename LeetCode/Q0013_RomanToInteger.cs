public static class Q0013
{
    public static int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int> { ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50, ['C'] = 100, ['D'] = 500, ['M'] = 1000 };
        var result = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (roman[s[i]] < roman[s[i + 1]])
                result -= roman[s[i]];
            else
                result += roman[s[i]];
        }
        result += roman[s[s.Length - 1]];
        return result;
    }
}

public class Q0013_Tests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ReturnCorrectInteger(string input, int expected)
    {
        var result = Q0013.RomanToInt(input);
        Assert.Equal(expected, result);
    }
}
