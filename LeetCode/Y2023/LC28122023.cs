namespace LeetCode.Y2023
{
    /// <summary>
    /// Array assignment part 2
    /// </summary>
    public class LC28122023
    {
        /// <summary>
        /// https://leetcode.com/problems/move-zeroes
        /// TC=O(N), SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            if (nums is null || nums.Length == 0) return;
            int k = 0, len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k++] = nums[i];
                }
            }
            while (k < len)
            {
                nums[k++] = 0;
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate/
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/contains-duplicate-ii/
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int len = nums.Length;
            Dictionary<int, int> kv = new();
            for (int i = 0; i < len; i++)
            {
                if (kv.ContainsKey(nums[i]))
                {
                    if (i - kv[nums[i]] <= k)
                    {
                        return true;
                    }
                    kv[nums[i]] = i;
                }
                else
                {
                    kv.Add(nums[i], i);
                }
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/summary-ranges/
        /// TC=O(N) and SC=O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<string> SummaryRanges(int[] nums)
        {
            List<string> result = new();
            if (nums == null || nums.Length == 0)
            {
                return result;
            }
            int i = 0, j = 0, len = nums.Length;
            while (i < len - 1)
            {
                if (nums[i + 1] - nums[i] == 1)
                {
                    i++;
                }
                else
                {
                    if (i == j)
                    {
                        result.Add($"{nums[i]}");
                    }
                    else
                    {
                        result.Add($"{nums[j]}->{nums[i]}");
                    }
                    j = ++i;
                }
            }
            if (i == j)
            {
                result.Add($"{nums[i]}");
            }
            else
            {
                result.Add($"{nums[j]}->{nums[i]}");
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/range-sum-query-immutable/
        /// Tc=O(N) and SC=O(1)
        /// </summary>
        public class NumArray
        {
            private int[] numsArr;
            public NumArray(int[] nums)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] += nums[i - 1];
                }
                numsArr = nums;
            }
            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return numsArr[right];
                }
                return numsArr[right] - numsArr[left - 1];
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/range-sum-query-2d-immutable/
        /// https://www.youtube.com/watch?v=KE8MQuwE2yA
        /// </summary>
        public class NumMatrix
        {
            int[][] numMat;
            public NumMatrix(int[][] matrix)
            {
                int rows = matrix.Length;
                int cols = matrix[0].Length;
                numMat = new int[rows + 1][];
                for (int i = 0; i <= rows; i++)
                {
                    numMat[i] = new int[cols + 1];
                }
                for (int r = 0; r < rows; r++)
                {
                    int prefix = 0;
                    for (int c = 0; c < cols; c++)
                    {
                        prefix += matrix[r][c];
                        int above = numMat[r][c + 1];
                        numMat[r + 1][c + 1] = prefix + above;
                    }
                }
            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                long sum = 0;
                row1++;
                col1++;
                row2++;
                col2++;
                int bottomRight = numMat[row2][col2];
                int above = numMat[row1 - 1][col2];
                int left = numMat[row2][col1 - 1];
                int topLeft = numMat[row1 - 1][col1 - 1];
                sum = bottomRight - above - left + topLeft;
                return (int)sum;
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/remove-element/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0) return 0;
            int length = nums.Length;
            int k = 0;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }

        /// <summary>
        /// https://leetcode.com/problems/intersection-of-two-arrays/
        /// TC=O(n) and Sc=O(n)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> result = new();
            HashSet<int> elements = new();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!elements.Contains(nums1[i]))
                {
                    elements.Add(nums1[i]);
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (elements.Contains(nums2[i]) && !result.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// https://leetcode.com/problems/intersection-of-two-arrays-ii/
        /// TC=O(N^2) and SC=O(N)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new();
            Dictionary<int, int> kv1 = new();
            Dictionary<int, int> kv2 = new();
            foreach (int i in nums1)
            {
                if (kv1.ContainsKey(i))
                {
                    kv1[i]++;
                }
                else
                {
                    kv1.Add(i, 1);
                }
            }
            foreach (int j in nums2)
            {
                if (kv2.ContainsKey(j))
                {
                    kv2[j]++;
                }
                else
                {
                    kv2.Add(j, 1);
                }
            }
            foreach (var item in kv1)
            {
                int count = 0;
                kv2.TryGetValue(item.Key, out count);
                if (count > 0)
                {
                    count = Math.Min(count, item.Value);
                    for (int i = 0; i < count; i++)
                    {
                        result.Add(item.Key);
                    }
                }
            }
            return result.ToArray();
        }

        public static int NextGreaterElement(int n)
        {
            int result = 0;

            return result;
        }
    }
}