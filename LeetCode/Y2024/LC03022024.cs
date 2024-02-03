namespace LeetCode.Y2024
{
    public class LC03022024
    {
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
        /// https://leetcode.com/problems/reverse-linked-list/
        /// SC=O(N) and TC=O(1). This is very important, always keep handy
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode curr, next, prev;
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

        public static ListNode ReverseListWithStack(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode curr = head;
            Stack<int> stack = new();
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }
            ListNode ans = new();
            while (stack.Count > 0)
            {
                ListNode temp = ans;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                ListNode newNode = new(stack.Pop());
                temp.next = newNode;
            }
            return ans.next;
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

        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers-ii/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbersII(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = new();
            Stack<int> s2 = new();
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int sum = 0;
            ListNode ans = new();
            while (s1.Count() > 0 || s2.Count() > 0 || sum > 0)
            {
                if (s1.Count() > 0)
                {
                    sum += s1.Pop();
                }
                if (s2.Count() > 0)
                {
                    sum += s2.Pop();
                }
                ListNode temp = ans;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                ListNode newNode = new(sum % 10);
                sum = sum / 10;
                temp.next = newNode;
            }
            ans = ReverseList(ans.next);
            return ans;
        }
    }

}