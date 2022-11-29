public static class Q0065
{
    public static void SortColors(int[] nums)
    {
        int red = 0; 
        int white = 0; 
        int blue = 0;
        foreach (var num in nums)
        {
            switch (num)
            {
                case 0: red++; break;
                case 1: white++; break;
                case 2: blue++; break;
            }
        }
        int i = 0;
        while(red > 0) { nums[i++] = 0; red--; }
        while(white > 0) { nums[i++] = 1; white--; }
        while(blue > 0) { nums[i++] = 2; blue--; }
    }
}