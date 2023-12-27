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