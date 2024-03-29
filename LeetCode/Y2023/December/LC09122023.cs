﻿using System.Linq;

namespace LeetCode.Y2023.December
{
    public class LC09122023
    {
        public static IList<string> FizzBuzz(int n)
        {
            string[] result = new string[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = $"{i}";
                }
            }
            return result;
        }

        public static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static int MinOfThree(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public static int MidOfThree(int a, int b, int c)
        {
            if (a > b && a < c || a > c && a < b)
                return a;
            if (b > c && b < a || b > a && b < c)
                return b;
            return c;
        }

        public static void PrintNumberSeries(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                int counter = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter++);
                }
                Console.WriteLine();
            }
        }

        public static void PrintReverseNumberSeries(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                int counter = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter++);
                }
                Console.WriteLine();
            }
        }

        public static int[] ReturnOddElements(int[] nums)
        {
            IList<int> result = new List<int>();
            foreach (var num in nums)
            {
                if (num % 2 == 1)
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }

        public static int SumOfElement(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
                result += num;
            }
            return result;
        }

        public static int FirstEvenNumber(int[] nums)
        {
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    return item;
                }
            }
            return -1;
        }

        public static int Reverse(int x)
        {
            if (x <= int.MinValue)
            {
                return 0;
            }
            bool isNegative = x < 0;
            double result = 0;
            x = Math.Abs(x);
            while (x > 9)
            {
                result = result * 10 + x % 10;
                x = x / 10;
            }
            result = result * 10 + x;
            if (result > int.MaxValue)
            {
                return 0;
            }
            if (isNegative)
            {
                result *= -1;
            }
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// https://leetcode.com/problems/valid-parentheses/
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
    }
}