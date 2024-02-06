using LeetCode.Y2024;
using static LeetCode.Y2024.LC03022024;

namespace LeetCode.Test.Y2024
{
    public class UT03022024
    {
        [Test]
        public void ReverseListWithStackTest()
        {
            ListNode head = new(1);
            for (int i = 2; i <= 5; i++)
            {
                ListNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                ListNode newNode = new(i);
                temp.next = newNode;
            }
            var reverList = LC03022024.ReverseListWithStack(head);
        }

        [Test]
        public void AddTwoNumbersIITest()
        {
            ListNode node1 = new(7);
            ListNode node2 = new(2);
            ListNode node3 = new(4);
            ListNode node4 = new(3);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            ListNode node5 = new(5);
            ListNode node6 = new(6);
            ListNode node7 = new(4);
            node5.next = node6;
            node6.next = node7;
            var reverList = LC03022024.AddTwoNumbersII(node1, node5);
        }

        [Test]
        public void ReverseListWithRecursionTest()
        {
            ListNode node1 = new(7);
            ListNode node2 = new(2);
            ListNode node3 = new(4);
            ListNode node4 = new(3);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            var reverList = LC03022024.ReverseListWithRecursion(node1);
        }



    }
}