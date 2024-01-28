namespace LeetCode.Y2024
{
    public class LC28012024
    {
        /// <summary>
        /// https://leetcode.com/problems/delete-node-in-a-linked-list/
        /// </summary>
        /// <param name="node"></param>
        public static void DeleteNode(ListNode node)
        {
            if (node == null) return;
            ListNode right = node.next;
            node.val = right.val;
            node.next = node.next.next;
            right.next = null;
        }
    }
}
