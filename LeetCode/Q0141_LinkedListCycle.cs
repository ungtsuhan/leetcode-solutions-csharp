using LeetCode.DataModels;

public static class Q0164
{
    public static bool HasCycle(ListNode head)
    {
        var slowTail = head;
        var fastTail = head;
        while (fastTail is not null && fastTail.next is not null)
        {
            slowTail = slowTail?.next;
            fastTail = fastTail.next.next;

            if (slowTail == fastTail) 
                return true;
        };
        return false;
    }
}
