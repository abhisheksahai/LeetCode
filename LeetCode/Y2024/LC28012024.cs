namespace LeetCode.Y2024
{
    public class LC28012024
    {
        /// <summary>
        /// https://leetcode.com/problems/delete-node-in-a-linked-list/
        /// Tc=O(1) and SC=O(1)
        /// </summary>
        /// <param name="node"></param>
        public static void DeleteNode(ListNodeDelete node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        public ListNodeRemove RemoveNthFromEnd(ListNodeRemove head, int n)
        {
            if (head == null || head.next == null) return null;
            ListNodeRemove start = new ListNodeRemove();
            start.next = head;

            ListNodeRemove fast = head;

            return head;
        }
    }
}
