namespace LeetCode.Y2024
{
    /// <summary>
    /// Binary Tree
    /// </summary>
    public class LC25022024
    {
        /// <summary>
        /// Tree -> Binary tree. Each node will have 0, 1 or 2 elements only
        /// </summary>
        public class Node1
        {
            int key;
            Node1 left, right;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/sum-of-binary-tree/1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumBinaryTree(Node1 root)
        {
            return 0;
        }

        public class Node2
        {
            public int data;
            public Node2 left;
            public Node2 right;
            public Node2(int item)
            {
                data = item;
                left = null;
                right = null;
            }
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/count-leaves-in-binary-tree/1
        /// TC = O(N) and SC=O(height of tree)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int CountLeaves(Node2 root)
        {
            if (root.left == null && root.right != null || root.left != null && root.right == null)
            {
                return 1;
            }
            int count = 0;
            if (root.left != null)
            {
                count += CountLeaves(root.left);
            }
            if (root.right != null)
            {
                count += CountLeaves(root.right);
            }
            return count;
        }

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

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-right-side-view/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            RightSideDFS(root, 1, result);
            return result;
        }

        private static void RightSideDFS(TreeNode node, int depth, List<int> result)
        {
            if (node == null) return;
            if (result.Count < depth)
            {
                result.Add(node.val);
            }
            RightSideDFS(node.right, depth + 1, result);
            RightSideDFS(node.left, depth + 1, result);
        }

        //https://www.geeksforgeeks.org/problems/k-distance-from-root/1
    }
}