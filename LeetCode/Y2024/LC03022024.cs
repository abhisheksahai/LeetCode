namespace LeetCode.Y2024
{
    public class LC03022024
    {
        public class ListNodeReverseList
        {
            public int val;
            public ListNodeReverseList next;
            public ListNodeReverseList(int val = 0, ListNodeReverseList next = null)
            {
                this.val = val;
                this.next = next;
            }

        }

        /// <summary>
        /// https://leetcode.com/problems/reverse-linked-list/
        /// SC=O(N) and TC=O(1). This is very important, always keep handy
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNodeReverseList ReverseList(ListNodeReverseList head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNodeReverseList curr, next, prev;
            curr = head;
            prev = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }


}