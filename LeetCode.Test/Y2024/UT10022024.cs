using LeetCode.Y2024;
using static LeetCode.Y2024.LC10022024;

namespace LeetCode.Test.Y2024
{
    public class UT10022024
    {
        [Test]
        public void ReverseStringTest()
        {
            LC10022024.ReverseString(['h', 'e', 'l', 'l', 'o']);
        }

        [Test]
        public void IsValidTest()
        {
            var result1 = LC10022024.IsValid("({[]})");
            var result2 = LC10022024.IsValid("()");
        }


        [Test]
        public void MinStackTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var min1 = minStack.GetMin(); // return -3
            minStack.Pop();
            var top1 = minStack.Top();    // return 0
            var min2 = minStack.GetMin(); // return -2
        }
    }
}