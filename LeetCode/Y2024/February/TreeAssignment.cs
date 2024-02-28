﻿namespace LeetCode.Y2024.February
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class TreeAssignment
    {
        /// <summary>
        /// https://leetcode.com/problems/binary-tree-postorder-traversal/
        /// TC=O(N) and SC=O(1), if we dont consider the stack trace for recursion
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> result = [];
            if (root == null) return result;
            result.AddRange(PostorderTraversal(root.left));
            result.AddRange(PostorderTraversal(root.right));
            result.Add(root.val);
            return result;
        }


        /// <summary>
        /// https://leetcode.com/problems/binary-tree-inorder-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = [];
            if (root == null) return result;
            result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            result.AddRange(InorderTraversal(root.right));
            return result;
        }


    }
}