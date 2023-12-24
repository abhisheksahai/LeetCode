using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LC23122023
    {

        /// <summary>
        /// https://leetcode.com/problems/first-unique-character-in-a-string/description/
        /// TC= O(N) and SC=O(1) because we are storing small alphabets and in worst case it will have 26 elements which is less than 100
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> chars = new();
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], 1);
                }
                else
                {
                    chars[s[i]]++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (chars[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// https://leetcode.com/problems/valid-anagram/description/
        /// Tc=O(N) and SC=O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> chars = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    chars.Add(s[i], 1);
                }
                else
                {
                    chars[s[i]]++;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (chars.ContainsKey(t[i]))
                {
                    if (chars[t[i]] > 1)
                    {
                        chars[t[i]]--;
                    }
                    else
                    {
                        chars.Remove(t[i]);
                    }
                }
                else
                {
                    return false;
                }
            }
            return chars.Count == 0;
        }


        /// <summary>
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
        /// Using sliding window. initally i = j =0. both will move from L->R. i will increment when char is added to hasset and j will be incremented when we remove character from hashset
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int n = s.Length;
            int i = 0, j = 0, max = 0;
            HashSet<char> hSet = new();
            while (i < n)
            {
                if (!hSet.Contains(s[i]))
                {
                    hSet.Add(s[i]);
                    i++;
                }
                else
                {
                    max = Math.Max(max, hSet.Count);
                    hSet.Remove(s[j]);
                    j++;
                }
                max = Math.Max(max, hSet.Count);
            }
            return max;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-palindrome/description/
        /// (n-1)a+(m-1)b+1 => Formula to take odd characters
        /// TC=O(N) and SC=O(1). SC=O(1) because as input contains upper and lower case letters only so maximum it will have 26+26 keys in the dictionary.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return 1;
            int result = 0;
            Dictionary<char, int> frequency = new();
            foreach (char ch in s)
            {
                if (frequency.ContainsKey(ch))
                {
                    frequency[ch]++;
                }
                else
                {
                    frequency[ch] = 1;
                }
            }
            bool oddFrequeny = false;
            foreach (var kv in frequency)
            {
                if (kv.Value % 2 == 0)
                {
                    result += kv.Value;
                }
                else
                {
                    oddFrequeny = true;
                    result += kv.Value - 1;
                }
            }
            if (oddFrequeny)
            {
                result++;
            }
            return result;
        }
    }
}
