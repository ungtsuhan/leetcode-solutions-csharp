namespace LeetCode;

public class Q1557
{
    // Time Complexity: O(e + v)
    // Space Complexity: O(e + v)

    public static IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        // Intuition: Find nodes without incoming edges

        var incoming = new HashSet<int>();
        foreach (var edge in edges)
            incoming.Add(edge[1]);

        var result = new List<int>();
        for (var i = 0; i < n; i++)
            if (!incoming.Contains(i))
                result.Add(i);

        return result;
    }
}
