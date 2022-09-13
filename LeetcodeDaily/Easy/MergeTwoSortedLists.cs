namespace LeetcodeDaily.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public static class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 is null)  return l2;
            if (l2 is null) return l1;
            
            var result = new ListNode();
            var cur = result;
            do
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }

                cur = cur.next;

            } while (l1 != null && l2 != null);

            if (l1 != null)
            {
                cur.next = l1;
            }

            if (l2 != null)
            {
                cur.next = l2;
            }    

            return result.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
