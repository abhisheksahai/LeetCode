namespace LeetCode.Y2023.December
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

        /// <summary>
        /// https://leetcode.com/problems/minimum-absolute-difference/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int mindiff = int.MaxValue;
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    int diff = Math.Abs(arr[j] - arr[i]);
                    if (diff < mindiff)
                    {
                        result.Clear();
                        mindiff = diff;
                        if (arr[i] > arr[j])
                        {
                            result.Add(new int[] { arr[j], arr[i] });
                        }
                        else
                        {
                            result.Add(new int[] { arr[i], arr[j] });
                        }
                    }
                    else if (diff == mindiff)
                    {
                        if (arr[i] > arr[j])
                        {
                            result.Add(new int[] { arr[j], arr[i] });
                        }
                        else
                        {
                            result.Add(new int[] { arr[i], arr[j] });
                        }
                    }
                }
            }
            return result;
        }

        public static IList<IList<int>> MinimumAbsDifferenceWithSort(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (arr.Length == 0 || arr.Length == 1)
            {
                return result;
            }
            Array.Sort(arr);
            int minDiff = Math.Abs(arr[0] - arr[1]);
            result.Add(new int[] { arr[0], arr[1] });
            for (int i = 1; i < arr.Length - 1; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i + 1]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    result.Clear();
                    result.Add(new int[] { arr[i], arr[i + 1] });
                }
                else if (diff == minDiff)
                {
                    result.Add(new int[] { arr[i], arr[i + 1] });
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/three-consecutive-odds
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/move-zeroes/
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k++] = nums[i];
                }
            }
            while (k < nums.Length)
            {
                nums[k] = 0;
            }
        }
    }
}