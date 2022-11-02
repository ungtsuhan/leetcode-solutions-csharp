public static class Q0020
{
    public static bool IsValid(string s)
    {
        Dictionary<char, char> bracketDict = new Dictionary<char, char> {  ['('] = ')', ['['] = ']', ['{'] = '}' };
        Stack<char> expectedClosedBracket = new Stack<char>();
        foreach (var c in s)
        {
            if (bracketDict.ContainsKey(c))
                expectedClosedBracket.Push(bracketDict[c]);

            else if (!expectedClosedBracket.Any() || expectedClosedBracket.Pop() != c)
                return false;
        }
        return expectedClosedBracket.Count == 0;
    }
}

public class Q0020_Tests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("]", false)]
    public void IsValid_ReturnCorrectValidation(string input, bool expected)
    {
        var result = Q0020.IsValid(input);
        Assert.Equal(expected, result);
    }
}
