namespace LeetCode.Y2023
{
    public class LC06012024
    {
        /// <summary>
        /// https://leetcode.com/problems/merge-sorted-array/
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="nums1"></param> 
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            for (int p = n + m - 1; p >= 0; p--)
            {
                if (p2 < 0)
                {
                    break;
                }
                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// TC=O(N^2) and SC=O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaBruteForce(int[] height)
        {
            int maxArea = 0;
            for (int p = 0; p < height.Length; p++)
            {
                for (int p1 = p + 1; p1 < height.Length; p1++)
                {
                    int currentArea = Math.Min(height[p], height[p1]) * (p1 - p);
                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
            return maxArea;
        }

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// Here two pointer is used even if array is not sorted.
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static int MaxAreaTwoPointer(int[] height)
        {
            int maxArea = 0;
            int left = 0, right = height.Length - 1;
            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int currentArea = currentHeight * width;
                maxArea = Math.Max(maxArea, currentArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }

        /// <summary>
        /// https://leetcode.com/problems/merge-intervals/
        /// Salesforce,MS,Amazon
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new();
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            result.Add(intervals[0]);
            return result.ToArray();
        }
    }
}