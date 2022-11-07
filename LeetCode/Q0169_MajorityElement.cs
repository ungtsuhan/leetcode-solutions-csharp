public static class Q0169 
{
    public static int MajorityElement(int[] nums)
    {
        var majorityCount = nums.Length / 2;
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if(dict.ContainsKey(num))
                dict[num]++;
            else 
                dict.Add(num, 1);
        
            if (dict[num] > majorityCount)
                return num;
        }
        throw new Exception("No solution");
    }
}

public class Q0169_Tests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MajorityElement_ReturnMajorityElement(int[] input, int expected)
    {
        var result = Q0169.MajorityElement(input);
        Assert.Equal(expected, result);
    }
}
