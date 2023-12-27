namespace LeetCode.Y2023
{
    public class LC24122023
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/description/
        /// TC = O(n), SC=O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int len = nums.Length;
            Dictionary<int, int> map = new();
            for (int i = 0; i < len; i++)
            {
                int diff = target - nums[i];
                if (map.TryGetValue(diff, out int value))
                {
                    return [value, i];
                }
                map.TryAdd(nums[i], i);
            }
            return null;
        }

        //Two pointer with sorted array. TC= O(n * log n) and SC = O(1)
        public static bool TwoSumTwoPointer(int[] nums, int target)
        {
            int len = nums.Length;
            Array.Sort(nums);
            int left = 0, right = len - 1;
            while (left < right)
            {
                int leftVal = nums[left];
                int rightVal = nums[right];
                if (leftVal + rightVal == target)
                {
                    return true;
                }
                if (leftVal + rightVal > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return false;
        }

        /// TC = O(n^2), SC=O(1)
        public static int[] TwoSumWithTwoLoops(int[] nums, int target)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                int diff = target - nums[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (diff == nums[j])
                    {
                        return [i, j];
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        /// TC = O(n) and SC = O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumArraySorted(int[] numbers, int target)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            while (startIndex < endIndex)
            {
                int sum = numbers[startIndex] + numbers[endIndex];
                if (sum == target)
                {
                    return new int[] { startIndex + 1, endIndex + 1 };
                }
                else if (sum > target)
                {
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            throw new Exception("No integer pair exists");
        }

        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0, j = 0, k = 0;
            int[] nums3 = new int[m + n];
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3[k++] = nums1[i++];
                }
                else
                {
                    nums3[k++] = nums2[j++];
                }
            }
            while (i < m)
            {
                nums3[k++] = nums1[i++];
            }
            while (j < n)
            {
                nums3[k++] = nums2[j++];
            }
            Array.Copy(nums3, nums1, m + n);
            return nums1;
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
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/.
        /// Very Important. Was aksed in VM Ware and Nagarro
        /// TC = O(N) and SC = O(1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }

        /// <summary>
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
        /// TC = O(N) and SC=O(1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit2(int[] prices)
        {
            int totalProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    totalProfit += prices[i] - prices[i - 1];
            }
            return totalProfit;
        }

        /// <summary>
        /// https://leetcode.com/problems/majority-element/description/
        /// TC=O(n) and SC=O(n) because of Dictionary
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            Dictionary<int, int> keyValuePairs = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs[nums[i]]++;
                    if (keyValuePairs[nums[i]] > nums.Length / 2)
                    {
                        return nums[i];
                    }
                }
                else
                {
                    keyValuePairs.Add(nums[i], 1);
                }
            }
            return int.MinValue;
        }

        //Moore Voting Algorithm. This algorithm is applicable to this problem only.
        //Majority = first element and count =1, loop from second element to end. if current element = majority element increment the count else decrement the count.When count reaches 0, change the majority to current elemnet and set count to 1
        //TC=O(n) and SC=O(1)
        public static int MajorityElementOptimised(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int majority = nums[0];
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == majority)
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        majority = nums[i];
                        count = 1;
                    }
                }
            }
            return majority;
        }

        public static IList<int> MajorityElement2(int[] nums)
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

        /// <summary>
        /// https://leetcode.com/problems/3sum/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            Array.Sort(nums);
            if (len < 3 || nums[0] > 0)
            {
                return res;
            }
            if (len == 3)
            {
                if (nums[0] + nums[1] + nums[2] == 0)
                {
                    res.Add(new int[] { nums[0], nums[1], nums[2] });
                }
                return res;
            }
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int low = i + 1;
                int high = len - 1;
                int sum = 0;
                while (low < high)
                {
                    sum = nums[i] + nums[low] + nums[high];
                    if (sum > 0)
                    {
                        high--;
                    }
                    else if (sum < 0)
                    {
                        low++;
                    }
                    else
                    {
                        res.Add(new int[] { nums[i], nums[low], nums[high] });
                        int lastLowOccurance = nums[low], lastHighOccurance = nums[high];
                        while (low < high && lastLowOccurance == nums[low])
                        {
                            low++;
                        }
                        while (low < high && lastHighOccurance == nums[high])
                        {
                            high--;
                        }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// https://leetcode.com/problems/3sum-closest/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int len = nums.Length;
            if (len == 3)
            {
                return nums[0] + nums[1] + nums[2];
            }
            int diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                int low = i + 1;
                int high = len - 1;
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    int diffNew = Math.Abs(sum - target);
                    if (diffNew < Math.Abs(diff))
                    {
                        diff = sum - target;
                    }
                    if (sum < target)
                    {
                        low++;
                    }
                    else if (sum > target)
                    {
                        high--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return target + diff;
        }

        /// <summary>
        /// https://leetcode.com/problems/4sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result;
            }
            int len = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < len - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < len - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1, right = len - 1;
                    long sum = nums[i] + nums[j];
                    while (left < right)
                    {
                        long totalSum = sum + nums[left] + nums[right];
                        if (totalSum < target)
                        {
                            left++;
                        }
                        else if (totalSum > target)
                        {
                            right--;
                        }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/rotate-image/
        /// To rotate a matrix by 90, transpose the matrix and reverse each row.
        /// TC=O(N^2) And SC=O(1)
        /// </summary>
        /// <param name="matrix"></param>
        public static void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix.Length != matrix[0].Length)
            {
                return;
            }
            int len = matrix.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
            for (int i = 0; i < len; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }
    }
}