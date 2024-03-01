namespace LeetCode.Y2024.February
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

        /// <summary>
        /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
        /// TC=O(N) wors case we may have to travel all the nodes
        /// SC=O(N) we are using an addional queue
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MinDepth(TreeNode root)
        {
            if (root == null) { return 0; }
            int count = 0;
            Queue<TreeNode> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (node.left == null && node.right == null)
                    {
                        return count + 1;
                    }
                    size--;
                }
               
            }
            return count;
        }

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = [];
            if (root == null) return result;
            Queue<TreeNode> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> list = [];
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    size--;
                }
                result.Add(list);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int maxDepth = 0;
            int curDepth = 0;
            Queue<TreeNode> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if(node.left!=null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(node.right!=null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if(node.left==null && node.right==null)
                    {
                        maxDepth=Math.Max(maxDepth, curDepth+1);
                    }
                    size--;
                }
                curDepth++;
            }
            return maxDepth;
        }

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = [];
            if(root==null) return result;
            return result;
        }
    }
}