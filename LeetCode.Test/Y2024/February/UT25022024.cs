﻿using LeetCode.Y2024.February;
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
    }
}