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

        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}