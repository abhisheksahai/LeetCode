using System.Collections;

namespace LeetCode.Y2024
{
    //https://www.geeksforgeeks.org/c-sharp-stack-with-examples/
    public class LC10022024
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-string/
        /// </summary>
        /// <param name="s"></param>
        public static void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0)
            {
                return;
            }
            Stack<char> stack = new();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
            int j = 0;
            while (stack.Count > 0)
            {
                s[j++] = stack.Pop();
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/valid-parentheses/
        /// TC=O(n) and SC=O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            Dictionary<char, char> dict = new()
            {
                { '{','}' },
                { '(',')' },
                { '[',']' }
            };
            Stack<char> stack = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count > 0 && dict[stack.Peek()] == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }


        /// <summary>
        /// Input = [2, 5, 3, 7, 8, 1, 9]  and Output = [-1, 2, 2, 3, 7, -1, 1] 
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] PreviousSmallerNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }
            int[] result = new int[nums.Length];
            Stack<int> stack = new();
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0)
                {

                }
            }
            return result;
        }


        /// <summary>
        /// https://leetcode.com/problems/min-stack/
        //Salesforce and British Petroleum
        /// </summary>
        public class MinStack
        {
            Stack<(int value, int minValue)> minStack;
            int minValue = int.MaxValue;

            public MinStack()
            {
                minStack = new Stack<(int value, int minValue)>();
            }

            public void Push(int val)
            {
                if (minValue > val)
                {
                    minValue = val;
                }
                minStack.Push((val, minValue));
            }

            public void Pop()
            {
                minStack.Pop();
                if (minStack.Count > 0)
                {
                    minValue = minStack.Peek().minValue;
                }
                else
                {
                    minValue = int.MaxValue;
                }
            }

            public int Top()
            {
                return minStack.Peek().value;
            }

            public int GetMin()
            {
                return minStack.Peek().minValue;
            }
        }

        /// <summary>
        /// It use a one dimention array of size 2
        /// Tc=O(1) for each function and SC=O(N)
        /// </summary>
        public class MinStackWithArray
        {
            Stack<int[]> minStack;
            int minValue = int.MaxValue;

            public MinStackWithArray()
            {
                minStack = new Stack<int[]>();
            }

            public void Push(int val)
            {
                if (minValue > val)
                {
                    minValue = val;
                }
                minStack.Push([val, minValue]);
            }

            public void Pop()
            {
                minStack.Pop();
                if (minStack.Count > 0)
                {
                    minValue = minStack.Peek()[1];
                }
                else
                {
                    minValue = int.MaxValue;
                }
            }

            public int Top()
            {
                return minStack.Peek()[0];
            }

            public int GetMin()
            {
                return minStack.Peek()[1];
            }
        }
    }
}