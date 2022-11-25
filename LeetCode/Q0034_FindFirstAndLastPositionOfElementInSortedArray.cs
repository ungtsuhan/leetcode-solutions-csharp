public static class Q0034
{
    public static int[] SearchRange(int[] nums, int target)
    {
        int x = -1;
        int y = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > target) 
                return new int[] { x, y };
            
            if (nums[i] == target)
            {
                if (x == -1) x = i;
                y = i;
            }
        }
        return new int[] { x, y };
    }
}

public class Q0034_Tests
{
    [Theory]
    [InlineData(new int[] { 5,7,7,8,8,10 }, 8, new int[] { 3,4 })]
    [InlineData(new int[] { 5,7,7,8,8,10 }, 6, new int[] { -1,-1 })]
    [InlineData(new int[] { }, 0, new int[] { -1,-1 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 0, 0 })]
    [InlineData(new int[] { 1 }, 0, new int[] { -1, -1 })]
    [InlineData(new int[] { 2,2 }, 2, new int[] { 0, 1 })]
    [InlineData(new int[] { 1,4 }, 4, new int[] { 1, 1 })]
    [InlineData(new int[] { 1,1,2 }, 1, new int[] { 0, 1 })]
    [InlineData(new int[] { 3,3,3 }, 3, new int[] { 0, 2 })]
    public void SearchRange(int[] nums, int target, int[] expected)
    {
        var result = Q0034.SearchRange(nums, target);
        Assert.Equal(expected, result);
    }
}
