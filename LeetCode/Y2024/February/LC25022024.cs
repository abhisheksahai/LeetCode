using System.Collections.Generic;

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

        public class NodeNext
        {
            public int val;
            public NodeNext left;
            public NodeNext right;
            public NodeNext next;

            public NodeNext() { }

            public NodeNext(int _val)
            {
                val = _val;
            }

            public NodeNext(int _val, NodeNext _left, NodeNext _right, NodeNext _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
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
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
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

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/k-distance-from-root/1
        /// Using BFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<int> Kdistance(Node root, int k)
        {
            List<int> result = [];
            if (root == null) return result;
            if (k == 0)
            {
                result.Add(root.val);
                return result;
            }
            int currentDistance = 0;
            Queue<Node> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                currentDistance++;
                while (size > 0)
                {
                    Node node = queue.Dequeue();
                    if (node.left != null)
                    {
                        if (currentDistance == k)
                        {
                            Node lNdoe = node.left;
                            result.Add(lNdoe.val);
                        }
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        if (currentDistance == k)
                        {
                            Node rNdoe = node.right;
                            result.Add(rNdoe.val);
                        }
                        queue.Enqueue(node.right);
                    }
                    size--;
                }
                if (currentDistance == k)
                {
                    return result;
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/deepest-leaves-sum/
        /// Tc=O(N) and SC=O(N) N is the number of noeds
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int DeepestLeavesSum(TreeNode root)
        {
            if (root == null) return 0;
            int sum = 0;
            Queue<TreeNode> queue = [];
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                sum = 0;
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;
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
            }
            return sum;
        }

        /// <summary>
        /// https://leetcode.com/problems/count-complete-tree-nodes/
        /// For perfect binary tree total number of node = (2^n)-1
        /// If left nodes count != right nodes count, its complate binary tree
        /// Split the tree in left and right sub tree
        /// Apply formula for perfect binary tree (PBT)
        /// Sum = 1 + Sum(left subtree) + Sum (right subtree)
        /// In case of complete binary tree all nodes will be as left as possible
        /// TC=O(log n) and SC=O(log n), How ? Try to analyse
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            int leftCount = 0;
            int rightCount = 0;
            if (root.left != null)
            {
                leftCount = 1;
                TreeNode leftNode = root;
                while (leftNode.left != null)
                {
                    leftNode = leftNode.left;
                    leftCount++;
                }
            }
            if (root.right != null)
            {
                rightCount = 1;
                TreeNode rightNode = root;
                while (rightNode.right != null)
                {
                    rightNode = rightNode.right;
                    rightCount++;
                }
            }
            if (leftCount != 0 && leftCount == rightCount)
            {
                //Formula to get number of nodes in perfect binary tree
                return (int)Math.Pow(2, leftCount) - 1;
            }
            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }

        /// <summary>
        /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
        /// Tc=O(N) and SC=O(N)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
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
                        maxDepth = Math.Max(maxDepth, curDepth + 1);
                    }
                    size--;
                }
                curDepth++;
            }
            return maxDepth;
        }

        /// <summary>
        /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
        /// TC=O() and SC=O()
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepthWithDFS(TreeNode root)
        {
            if (root == null) return 0;
            int leftCount = MaxDepthWithDFS(root.left);
            int rightCount = MaxDepthWithDFS(root.right);
            return Math.Max(leftCount, rightCount) + 1;
        }

        /// <summary>
        /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
        /// Asked a lot in Amazon
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root == p || root == q) return root;
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left == null && right == null) return null;
            if (left != null && right != null) return root;
            if (right == null) return left;
            return right;
        }

        /// <summary>
        /// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            List<int> result = [];
            if (root == null) return result;

            return result;
        }

        private void CreateParentDictionary(TreeNode root, Dictionary<TreeNode, TreeNode> dict)
        {
            if (root == null) return;
            if (root.left != null)
            {
                dict.Add(root.left, root);
            }
            if (root.right != null)
            {
                dict.Add(root.right, root);
            }
            CreateParentDictionary(root.left, dict);
            CreateParentDictionary(root.right, dict);
        }

        /// <summary>
        /// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
        /// TC=O(N), SC=O(1) Constant space if recursion is not considered
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static NodeNext Connect(NodeNext root)
        {
            if (root == null) return root;
            if (root.left != null)
            {
                root.left.next = root.right;
                root.right.next = root.next?.left;
                Connect(root.left);
                Connect(root.right);
            }
            return root;
        }


        public class MyPair(LC25022024.Node node, int hd)
        {
            public Node node = node;
            public int hd = hd;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/print-a-binary-tree-in-vertical-order/0
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<int> VerticalOrder(Node root)
        {
            List<int> result = [];
            SortedDictionary<int, List<int>> keyValuePairs = [];
            Queue<MyPair> queue = [];
            queue.Enqueue(new MyPair(root, 0));
            while (queue.Count > 0)
            {
                MyPair pair = queue.Dequeue();
                Node node = pair.node;
                int hd = pair.hd;

                if (keyValuePairs.ContainsKey(hd))
                {
                    List<int> kv = keyValuePairs[hd];
                    kv.Add(node.val);
                    keyValuePairs[hd] = kv;
                }
                else
                {
                    keyValuePairs.Add(hd, new List<int>() { node.val });
                }

                if (node.left != null)
                {
                    queue.Enqueue(new MyPair(node.left, hd - 1));
                }
                if (node.right != null)
                {
                    queue.Enqueue(new MyPair(node.right, hd + 1));
                }
            }
            foreach (var item in keyValuePairs)
            {
                result.AddRange(item.Value);
            }
            return result;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/diameter-of-binary-tree/1
        /// </summary>
        public static class DiameterSolution
        {
            static int maxDiameter = 0;
            public static int Diameter(Node? root)
            {
                maxDiameter = 0;
                FindDiameter(root);
                return maxDiameter;
            }

            public static int FindDiameter(Node? root)
            {
                if (root == null) return 0;
                int leftHeight = FindDiameter(root.left);
                int rightHeight = FindDiameter(root.right);
                maxDiameter = Math.Max(maxDiameter, leftHeight + rightHeight + 1);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        //Binary search tree. lst<=root<=rst
        //lst : left subtree and rst = right sub tree

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/check-for-bst/1
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsBST(Node root)
        {
            return BstHelper(root, Int32.MinValue, Int32.MaxValue);
        }

        public static bool BstHelper(Node root, int minMalue, int maxValue)
        {
            if (root == null) return true;
            if (root.val <= minMalue || root.val >= maxValue) return false;
            bool left = BstHelper(root.left, minMalue, root.val);
            bool right = BstHelper(root.right, root.val, maxValue);
            return left && right;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/insert-a-node-in-a-bst/1
        /// Tc=O(logn) and SC=O(1)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Node? Insert(Node? node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            };
            if (key < node.val)
            {
                node.left = Insert(node.left, key);
            }
            if (key > node.val)
            {
                node.right = Insert(node.right, key);
            }
            return node;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/delete-a-node-from-bst/1
        /// </summary>
        /// <param name="root"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static Node DeleteNode(Node root, int x)
        {
            if (root == null)
            {
                return null;
            }
            else if (x < root.val)
            {
                root = DeleteNode(root.left, x);
            }
            else if (x > root.val)
            {
                root = DeleteNode(root.right, x);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else if (root.left == null)
                {
                    root = root.right;
                }
                else if (root.right == null)
                {
                    root = root.left;
                }
                else
                {
                    int minRight = MinRightSubTree(root.right);
                    root.val = minRight;
                    root.right = DeleteNode(root.right, minRight);
                }
            }
            return root;
        }

        private static int MinRightSubTree(Node node)
        {
            int min = node.val;
            while (node.left != null)
            {
                node = node.left;
            }
            min = node.val;
            return min;
        }


        /// <summary>
        /// Tc=O(N) and SC=O(1)
        /// </summary>
        /// <param name="root"></param>
        public void MorrisTraverse(Node root)
        {
            Node curr = root;
            while (curr != null)
            {
                if (curr.left == null)
                {
                    Console.WriteLine(curr.val);
                    curr = curr.right;
                }
                else
                {
                    Node left = curr.left;
                    while (left.right != null)
                    {
                        left = left.right;
                    }
                    left.right = curr;
                    Node temp = curr;
                    curr = curr.left;
                    temp.left = null;
                }
            }
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/construct-tree-1/1
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="preorder"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Node buildTree(int[] inorder, int[] preorder, int n)
        {
            if (n == 0) return null;
            Node node = new Node(preorder[0]);
            return node;
        }

    }
}