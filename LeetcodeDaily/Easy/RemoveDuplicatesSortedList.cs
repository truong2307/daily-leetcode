namespace LeetcodeDaily.Easy
{
    public class RemoveDuplicatesSortedList
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null) return head;
            var curNode = head;
            do
            {
                if (curNode?.val == curNode?.next?.val)
                {
                    curNode.next = curNode.next.next;
                    continue;
                }
                curNode = curNode?.next;

            } while (curNode != null);

            return head;
        }
    }
}

