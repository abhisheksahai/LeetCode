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

    }
}
