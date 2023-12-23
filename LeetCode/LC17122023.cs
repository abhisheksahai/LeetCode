namespace LeetCode
{
    public class LC17122023
    {
        /// <summary>
        /// https://leetcode.com/problems/pascals-triangle-ii/description/
        /// TC=O(N) and SC=O(rowIndex)
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static IList<int> GetRow(int rowIndex)
        {
            IList<int> rows = new List<int> { 1 };
            long prev = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                long currentElement = prev * (rowIndex - i + 1) / i;
                prev = currentElement;
                rows.Add((int)currentElement);
            }
            return rows;
        }

        /// <summary>
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
        /// TC = O(N) and SC=O(1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int totalProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    totalProfit += prices[i] - prices[i - 1];
            }
            return totalProfit;
        }

        public static IList<int> MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            else if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                {
                    return new int[] { nums[0] };
                };
                return nums;
            }
            HashSet<int> result = new();
            Dictionary<int, int> map = new();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                    if (map[num] > nums.Length / 3 && !result.Contains(num))
                    {
                        result.Add(num);
                    }
                }
                else
                {
                    map.Add(num, 1);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// https://leetcode.com/problems/majority-element-ii/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> MajorityElementMooreVoting(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            else if (nums.Length == 2)
            {
                if (nums[0] == nums[1])
                {
                    return new int[] { nums[0] };
                };
                return nums;
            }

            int? firstMajorityElement = null, secondMajorityElement = null, firstMajorityCount = 0, secondMajorityCount = 0;
            foreach (int num in nums)
            {
                if (firstMajorityElement.HasValue && num == firstMajorityElement)
                {
                    firstMajorityCount++;
                }
                else if (secondMajorityElement.HasValue && num == secondMajorityElement)
                {
                    secondMajorityCount++;
                }
                else if (firstMajorityCount == 0)
                {
                    firstMajorityElement = num;
                    firstMajorityCount = 1;
                }
                else if (secondMajorityCount == 0)
                {
                    secondMajorityElement = num;
                    secondMajorityCount = 1;
                }
                else
                {
                    firstMajorityCount--;
                    secondMajorityCount--;
                }
            }
            IList<int> result = new List<int>();
            if (nums.Count(n => n == firstMajorityElement) > nums.Length / 3)
            {
                result.Add(firstMajorityElement.Value);
            }
            if (nums.Count(n => n == secondMajorityElement) > nums.Length / 3)
            {
                result.Add(secondMajorityElement.Value);
            }
            return result;
        }

    }
}