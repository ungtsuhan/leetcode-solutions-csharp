public static class Q0412
{
    public static IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) result.Add("FizzBuzz");
            else if (i % 3 == 0) result.Add("Fizz");
            else if (i % 5 == 0) result.Add("Buzz");
            else result.Add(i.ToString());
        }
        return result;
    }
}

public class Q0412_Tests
{
    [Theory]
    [InlineData(3, new string[] {"1","2","Fizz"})]
    [InlineData(5, new string[] {"1","2","Fizz","4","Buzz"})]
    [InlineData(15, new string[] {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"})]
    public void FizzBuzz_ReturnFizzBuzz(int input, string[] expected)
    {
        var result = Q0412.FizzBuzz(input);
        Assert.Equal(expected, result);
    }
}