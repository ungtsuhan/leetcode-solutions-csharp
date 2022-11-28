using LeetCode.DataModels;

public static class Q0237
{
    public static  void DeleteNode(ListNode node)
    {
        ListNode? nextNode = node.next;
        if (nextNode is not null)
        {
            node.val = nextNode.val;
            node.next = nextNode.next;
        }
    }
}