namespace LeetCode.Y2024.February
{
    /// <summary>
    /// Binary tree. Each node will have 0, 1 or 2 elements only
    /// </summary>
    public class LC25022024
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node(int val = 0, Node left = null, Node right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        /// <summary>
        /// BST : PreOrder traversal
        /// </summary>
        /// <param name="node"></param>
        public static void PreOrder(Node node)
        {

        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/sum-of-binary-tree/1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumBinaryTree(Node root)
        {
            return 0;
        }



        /// <summary>
        /// https://www.geeksforgeeks.org/problems/count-leaves-in-binary-tree/1
        /// TC = O(N) and SC=O(height of tree)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int CountLeaves(Node root)
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


        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-right-side-view/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(Node root)
        {
            List<int> result = new List<int>();
            RightSideDFS(root, 1, result);
            return result;
        }

        private static void RightSideDFS(Node node, int depth, List<int> result)
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