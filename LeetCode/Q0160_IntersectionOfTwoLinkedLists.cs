using LeetCode.DataModels;
using LeetCode.Helpers;

public static class Q0160 
{
    public static ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
    {
        ListNode? tailA = headA;
        ListNode? tailB = headB;
        while (tailA != tailB)
        {
            tailA = tailA is not null ? tailA.next : headB;
            tailB = tailB is not null ? tailB.next : headA;
        }
        return tailA;
    }
}

public class Q0160_Tests
{
    [Theory]
    [InlineData(new int[] { 4, 1, 8, 4, 5 }, new int[] { 5, 6, 1, 8, 4, 5 }, new int[] { 1 })]
    public void GetIntersectionNode_ReturnIntersectionNode(int[] l1, int[] l2, int[] expected)
    {
        var result = Q0160.GetIntersectionNode(l1.ToListNode(), l2.ToListNode());
        Assert.Equal(expected.ToArray(), result.ToArray());
    }
}
