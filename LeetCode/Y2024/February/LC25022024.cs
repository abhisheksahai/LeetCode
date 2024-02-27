namespace LeetCode.Y2024.February
{
    /// <summary>
    /// Binary tree. Each node will have 0, 1 or 2 elements only
    /// </summary>
    public class LC25022024
    {
        public class Node(int val = 0, LC25022024.Node? left = null, LC25022024.Node? right = null)
        {
            public int val = val;
            public Node? left = left;
            public Node? right = right;
        }

        /// <summary>
        /// BST : PreOrder traversal (Data, Left, Right)
        /// TC=O(N) as it will travel n nodes
        /// The time complexity of preorder traversal is O(n), where 'n' is the size of binary tree. Whereas, the space complexity of preorder traversal is O(1), if we do not consider the stack size for function calls. Otherwise, the space complexity of preorder traversal is O(h), where 'h' is the height of the tree.
        /// </summary>
        /// <param name="node"></param>
        public static void PreOrder(Node? root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        /// <summary>
        /// BST : InOrder traversal (Left,Data, Right)
        /// </summary>
        /// <param name="root"></param>
        public static void InOrder(Node? root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.WriteLine(root.val);
            InOrder(root.right);
        }

        /// <summary>
        /// BST : PostOrder traversal (Left,Right,Data)
        /// </summary>
        /// <param name="root"></param>
        public static void PostOrder(Node? root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.val);
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/sum-of-binary-tree/1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumBinaryTree(Node root)
        {
            if (root == null) return 0;
            return SumBinaryTree(root.left) + SumBinaryTree(root.right) + root.val;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/count-leaves-in-binary-tree/1
        /// TC = O(N) and SC=O(height of tree)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountLeaves(Node root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int sum = 0;
            if (root.left != null)
            {
                sum += CountLeaves(root.left);
            }
            if (root.right != null)
            {
                sum += CountLeaves(root.right);
            }
            return sum;
        }


        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = [];
            if (root == null) return result;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                List<int> ints = [];
                int size = queue.Count;
                while (size != 0)
                {
                    Node cur = queue.Dequeue();
                    ints.Add(cur.val);
                    if(cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if(cur.right!=null)
                    {
                        queue.Enqueue(cur.right);
                    }
                    size--;
                }
                result.Add(ints);
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-right-side-view/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(Node root)
        {
            List<int> result = [];
            RightSideDFS(root, 1, result);
            return result;
        }

        private static void RightSideDFS(Node? node, int depth, List<int> result)
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