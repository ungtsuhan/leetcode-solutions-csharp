namespace LeetCode
{
    public class Q1491
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static double Average(int[] salaries)
        {
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
        
            foreach (int salary in salaries)
            {
                sum += salary;
                min = Math.Min(salary, min);
                max = Math.Max(salary, max);
            }
        
            return (sum - min - max) / (double)(salaries.Length - 2);
        }
    }
}