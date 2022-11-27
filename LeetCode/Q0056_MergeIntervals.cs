public static class Q0056
{
    public static int[][] Merge(int[][] intervals)
    {
        List<int[]> result = new List<int[]>(); 
        var intervalList  = intervals.OrderBy(x => x[0]).ToList();
        int[] temp = intervalList[0];
        for (var i = 1; i < intervalList.Count; i++)
        {
            var curr = intervalList[i];
            if ((curr[0] >= temp[0] && curr[0] <= temp[1]) || curr[1] >= temp[0] && curr[1] <= temp[1])
            {
                temp[0] = Math.Min(temp[0], curr[0]);
                temp[1] = Math.Max(temp[1], curr[1]); 
            }
            else
            {
                result.Add(temp);
                temp = curr;
            }
        }
        result.Add(temp);
        return result.ToArray();
    }
}
