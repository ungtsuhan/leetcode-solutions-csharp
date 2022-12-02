public static class Q0287
{
    public static int FindDuplicate(int[] nums)
    {
        var numList = nums.OrderBy(x => x).ToList();
        for (var i = 1; i < numList.Count; i++)
        {
            if (numList[i] == numList[i-1])
                return numList[i];
        }
        throw new Exception("no solution");
    }
}