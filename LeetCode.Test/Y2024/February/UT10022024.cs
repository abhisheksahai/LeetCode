﻿using static LeetCode.Y2024.February.LC10022024;

namespace LeetCode.Test.Y2024.February
{
    public class UT10022024
    {
        [Test]
        public void CustomStackTest()
        {
            CustomStack customStack = new(5);
            customStack.Push(10);
            customStack.Push(11);
            customStack.Push(12);
            int pop = customStack.Pop();
            pop = customStack.Pop();
            pop = customStack.Pop();
            var result = customStack.IsEmpty();
        }

        [Test]
        public void ReverseStringTest()
        {
            ReverseString(['h', 'e', 'l', 'l', 'o']);
        }

        [Test]
        public void IsValidTest()
        {
            var result1 = IsValid("({[]})");
            var result2 = IsValid("()");
        }

        [Test]
        public void PreviousSmallerNumberTest()
        {
            var result = PreviousSmallerNumber([2, 5, 3, 7, 8, 1, 9]);
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

        [Test]
        public void EvalRPNTest()
        {
            var result = EvalRPN(["4", "13", "5", "/", "+"]);
        }
    }
}