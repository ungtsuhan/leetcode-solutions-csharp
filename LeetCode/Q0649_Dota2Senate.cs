namespace LeetCode;

public class Q0649
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)

    public static string PredictPartyVictory(string senate)
    {
        // best strategy: ban the next closest opponent senator

        var dQueue = new Queue<int>();
        var rQueue = new Queue<int>();

        for (var i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'D')
                dQueue.Enqueue(i);
            else if (senate[i] == 'R')
                rQueue.Enqueue(i);
        }

        while (dQueue.Count > 0 && rQueue.Count > 0)
        {
            int dIndex = dQueue.Dequeue();
            int rIndex = rQueue.Dequeue();

            if (dIndex < rIndex)
                dQueue.Enqueue(dIndex + senate.Length);
            else
                rQueue.Enqueue(rIndex + senate.Length);
        }

        return dQueue.Count > 0 ? "Dire" : "Radiant";
    }
}
