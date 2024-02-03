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

        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers/
        /// MS,SF,Amazon
        /// Tc=O(N) and SC=O(1)
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = new();
            ListNode head = ans;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                ans.next = new ListNode(sum % 10);
                sum = sum / 10;
                ans = ans.next;
            }
            return head.next;
        }
    }

}