namespace LeetCode
{
    public class LC04122023
    {
        public static bool IsPalindrome(string str)
        {
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}