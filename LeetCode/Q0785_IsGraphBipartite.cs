namespace LeetCode;

public class Q0785
{
    // Time Complexity: O(v + e)
    // Space Complexity: O(v)

    public static bool IsBipartite(int[][] graph)
    {
        var array = new int[graph.Length];
        var queue = new Queue<int>();

        for (int i = 0; i < graph.Length; i++)
        {
            if (array[i] != 0)
                continue;

            queue.Enqueue(i);
            array[i] = 1; // odd = 1, even = -1

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();

                foreach (int neighbour in graph[num])
                {
                    if (array[neighbour] == 0)
                    {
                        queue.Enqueue(neighbour);
                        array[neighbour] = -array[num];
                    }
                    else if (array[neighbour] == array[num])
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
