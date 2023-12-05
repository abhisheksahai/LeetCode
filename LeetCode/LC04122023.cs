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

        /// <summary>
        /// https://leetcode.com/problems/pascals-triangle/
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static IList<IList<int>> GeneratePascalTraingle(int numRows)
        {
            IList<IList<int>> result = [];
            for (int i = 0; i < numRows; i++)
            {
                int[] row = new int[i + 1];
                row[0] = 1;
                row[i] = 1;
                for (int j = 1; j < i; j++)
                {
                    row[j] = result[i - 1][j] + result[i - 1][j - 1];
                }
                result.Add(row);
            }
            return result;
        }

        /// <summary>
        ///  https://leetcode.com/problems/richest-customer-wealth
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static int MaximumWealth(int[][] accounts)
        {
            int result = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }
                if (sum > result)
                {
                    result = sum;
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/running-sum-of-1d-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] RunningSum(int[] nums)
        {
            int len = nums.Length;
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    result[i] = nums[i];
                }
                else
                {
                    result[i] = result[i - 1] + nums[i];
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/jewels-and-stones/
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        public static int NumJewelsInStones(string jewels, string stones)
        {
            int res = 0;
            HashSet<char> chars = new HashSet<char>();
            for (int i = 0; i < jewels.Length; i++)
            {
                chars.Add(jewels[i]);
            }
            for (int i = 0; i < stones.Length; i++)
            {
                if (chars.Contains(stones[i]))
                {
                    res++;
                }
            }
            return res;
        }
    }
}