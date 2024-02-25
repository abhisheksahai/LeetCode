namespace LeetCode.Y2024.February
{
    //https://www.geeksforgeeks.org/c-sharp-stack-with-examples/
    public class LC10022024
    {
        public class CustomStack
        {
            int top;
            int _maxCapacity;
            int[] arr;

            public CustomStack(int? maxCapacity)
            {
                top = -1;
                _maxCapacity = maxCapacity.HasValue ? maxCapacity.Value : 1000;
                arr = new int[_maxCapacity];
            }

            public void Push(int value)
            {
                if (top > _maxCapacity)
                {
                    Console.WriteLine("Stack overflow exception");
                    return;
                }
                arr[++top] = value;
            }

            public int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack underflow exception");
                    return -1;
                }
                return arr[top--];
            }

            public bool IsEmpty()
            {
                return top < 0;
            }
        }

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
            if (nums.Length == 1)
            {
                return [-1];
            }
            int[] result = new int[nums.Length];
            Stack<int> stack = new();
            result[0] = -1;
            stack.Push(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek() > nums[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = stack.Peek();
                }
                stack.Push(nums[i]);
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

        /// <summary>
        /// https://leetcode.com/problems/evaluate-reverse-polish-notation/
        /// Tc=O(N) and SC=O(N)
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public static int EvalRPN(string[] tokens)
        {
            int result = 0;
            if (tokens == null || tokens.Length == 0) return result;
            if (tokens.Length == 1)
            {
                return Convert.ToInt32(tokens[0]);
            }
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                int num = 0;
                if (int.TryParse(token, out num))
                {
                    stack.Push(num);
                }
                else
                {
                    //The order is very important
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            break;
                    }
                    stack.Push(result);
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/largest-rectangle-in-histogram/
        /// Amazon, Bp, SF
        /// Calculte previous and next smaller
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int LargestRectangleArea(int[] heights)
        {
            int result = 0;
            return result;

        }

        /// <summary>
        /// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string s)
        {
            return "";
        }

        /// <summary>
        /// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string s, int k)
        {
            return "";
        }
    }
}