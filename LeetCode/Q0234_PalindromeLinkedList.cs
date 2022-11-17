using LeetCode.DataModels;

public static class Q0234
{
    public static bool IsPalindrome(ListNode head)
    {
        ListNode? fast = head;
        ListNode? slow = head;
        ListNode? prev = null;

        while (fast?.next is not null)
        {
            ListNode temp = new ListNode(slow.val);
            temp.next = prev;
            prev = temp;
            slow = slow?.next;
            fast = fast?.next?.next;
        }

        bool isOdd = fast is not null;
        if(isOdd)
            slow = slow.next;

        while(slow is not null)
        {
            if (slow?.val != prev?.val) 
                return false;
            
            slow = slow.next;
            prev = prev.next;
        }
        return true;
    }
}