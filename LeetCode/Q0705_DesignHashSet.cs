using LeetCode.Models.ListNode;

namespace LeetCode
{
    public class MyHashSet
    {
        private readonly ListNode[] arr = new ListNode[10000];
        
        public MyHashSet()
        {
            // Initialize the array with a dummy ListNode
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new ListNode(0);
        }
    
        public void Add(int key)
        {
            var curr = arr[key % arr.Length];
            while (curr.next != null)
            {
                if (curr.next.val == key)
                    return;

                curr = curr.next;
            }
            curr.next = new ListNode(key);
        }
    
        public void Remove(int key)
        {
            var curr = arr[key % arr.Length];
            while (curr.next != null)
            {
                if (curr.next.val == key)
                {
                    curr.next = curr.next.next;
                    return;
                }

                curr = curr.next;
            } 
        }
    
        public bool Contains(int key)
        {
            var curr = arr[key % arr.Length];
            while (curr.next != null)
            {
                if (curr.next.val == key)
                    return true;

                curr = curr.next;
            }
            return false;
        }
    }
}
