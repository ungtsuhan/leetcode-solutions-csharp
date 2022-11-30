public static Q0041
{
    public static int FirstMissingPositive(int[] nums)
    {
        var expectedPositive = 1;
        
        var numList = nums.Where(x => x >= 1).Distinct().OrderBy(x => x).ToList();
        
        if (numList.Count >= 1 && numList[numList.Count - 1] == numList.Count)
            return numList[numList.Count - 1] + 1;

        foreach (var num in numList)
        {
            if (num != expectedPositive) 
                return expectedPositive;
            else 
                expectedPositive++;
        }
        return expectedPositive;
    }
}