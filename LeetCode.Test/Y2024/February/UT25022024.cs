using LeetCode.Y2024.February;
using static LeetCode.Y2024.February.LC25022024;

namespace LeetCode.Test.Y2024.February
{
    public class UT25022024
    {
        [Test]
        public void PreOrderTest()
        {
            LC25022024.PreOrder(CreateTree());
        }

        [Test]
        public void InOrderTest()
        {
            LC25022024.InOrder(CreateTree());
        }

        [Test]
        public void PostOrderTest()
        {
            LC25022024.InOrder(CreateTree());
        }

        [Test]
        public void SumBinaryTreeTest()
        {
            var result = LC25022024.SumBinaryTree(CreateTree());
        }

        [Test]
        public void CountLeavesTest()
        {
            var result = LC25022024.CountLeaves(CreateTree());
        }

        [Test]
        public void LevelOrderTest()
        {
            var result = LC25022024.LevelOrder(CreateTree());
        }

        [Test]
        public void RightSideViewTest()
        {
            var result = LC25022024.RightSideView(CreateTree());
        }

        [Test]
        public void KdistanceTest()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            node1.left = node2;
            node1.right = node3;

            var result = LC25022024.Kdistance(node1, 0);
        }

        [Test]
        public void DeepestLeavesSumTest()
        {
            var result = LC25022024.DeepestLeavesSum(CreateTreeWithNodes());
        }

        [Test]
        public void MaxDepthWithDFSTest()
        {
            var result = LC25022024.MaxDepthWithDFS(CreateTreeWithNodes());
        }

        [Test]
        public void ConnectTest()
        {
            var result = LC25022024.Connect(CreateNodeNextTree());
        }

        [Test]
        public void CountNodesTest()
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            var result = LC25022024.CountNodes(node1);
        }

        [Test]
        public void LowestCommonAncestorTest()
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            TreeNode node7 = new TreeNode(7);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            var result = LC25022024.LowestCommonAncestor(node1, node4, node7);
        }

        [Test]
        public void DiameterTest()
        {
            var result = LC25022024.DiameterSolution.Diameter(CreateTree());
        }

        #region "Create Tree"
        private NodeNext CreateNodeNextTree()
        {
            NodeNext node1 = new NodeNext(1);
            NodeNext node2 = new NodeNext(2);
            NodeNext node3 = new NodeNext(3);
            NodeNext node4 = new NodeNext(4);
            NodeNext node5 = new NodeNext(5);
            NodeNext node6 = new NodeNext(6);
            NodeNext node7 = new NodeNext(7);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            return node1;
        }

        private Node CreateTree()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            return node1;
        }

        private TreeNode CreateTreeWithNodes()
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            TreeNode node7 = new TreeNode(7);
            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            return node1;
        }
        #endregion
    }
}