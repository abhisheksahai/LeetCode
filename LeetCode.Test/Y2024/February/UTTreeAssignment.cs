using LeetCode.Y2024.February;

namespace LeetCode.Test.Y2024.February
{
    public class UTTreeAssignment
    {
        [Test]
        public void PostorderTraversalTest()
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            node1.right = node2;
            node2.left = node3;
            var result = TreeAssignment.PostorderTraversal(node1);
        }

        [Test]
        public void MinDepthTest()
        {
            var result = TreeAssignment.MinDepth(CreateTree());
        }

        [Test]
        public void LevelOrderTest()
        {
            var result = TreeAssignment.LevelOrder(CreateTree());
        }

        private TreeNode CreateTree()
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
    }
}