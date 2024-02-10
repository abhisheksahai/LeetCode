﻿using System.Collections;

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