using static LeetCode.Y2024.LC03022024;

namespace LeetCode.Y2024
{

    /// <summary>
    /// Binary search : In BS we always need to set low, mid and high
    /// </summary>
    public class LC17022024
    {
        /// <summary>
        /// https://leetcode.com/problems/binary-search/
        /// Tc=O(logn) and SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search(int[] nums, int target)
        {
            int low = 0, mid, high = nums.Length - 1;
            while (low <= high)
            {
                //Below formula will overcome issue of integer out of range
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/first-and-last-occurrences-of-x2041/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] FirstAndLast(int[] arr, int n, int x)
        {
            int[] result = new int[2];
            result = [FindFirst(arr, n, x), FindLast(arr, x, x)];
            return result;
        }

        public static int FindFirst(int[] arr, int n, int x)
        {
            int low = 0, mid = 0, high = n - 1, result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        public static int FindLast(int[] arr, int n, int x)
        {
            int low = 0, mid = 0, high = n - 1, result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }


        /// <summary>
        /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = [-1, -1];
            result = [FindFirst(nums, target), FindLast(nums, target)];
            return result;
        }

        public static int FindFirst(int[] nums, int target)
        {
            int result = -1;
            int low = 0, mid, high = nums.Length - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        public static int FindLast(int[] nums, int target)
        {
            int result = -1;
            int low = 0, mid, high = nums.Length - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        //Find frquency of numbers in sorted array
        //https://www.geeksforgeeks.org/problems/number-of-occurrence2259/1?utm_source=geeksforgeeks&utm_medium=article_practice_tab&utm_campaign=article_practice_tab
        public static int Count(int[] arr, int n, int x)
        {
            if (x < arr[0] || x > arr[n - 1]) return 0;
            int firstOccurance = CountFirstOccurance(arr, n, x);
            int lastOccurance = CountLastOccurance(arr, n, x);
            int result = 0;
            if (firstOccurance >= 0 && lastOccurance >= 0)
            {
                result = lastOccurance - firstOccurance + 1;
            }
            return result;
        }


        public static int CountFirstOccurance(int[] arr, int n, int x)
        {
            int low = 0, mid, high = n - 1, result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        public static int CountLastOccurance(int[] arr, int n, int x)
        {
            int low = 0, mid, high = n - 1, result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == x)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        /// <summary>
        /// https://leetcode.com/problems/find-peak-element/
        /// Befor peak the array is in increasing order after peak the array is in decreasing order
        /// TC=O(logn) and SC=O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindPeakElement(int[] nums)
        {
            int low = 0, mid, high = nums.Length - 1;
            while (low != high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return high;
        }

        /// <summary>
        /// https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// After k rotations, if we array is divided into two parts. low to mid and mid+1 to high. one of the sub array will be in sorted order always
        /// TC= O(logn)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchInRotatedSortedArray(int[] nums, int target)
        {
            int low = 0, mid, high = nums.Length - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                //checking if left half is sorted
                if (nums[low] <= nums[mid])
                {
                    //Checking if target lies in the left half
                    if (nums[low] <= target && target < nums[mid])
                    {
                        high = mid - 1;
                    }
                    //Target lies on the right side of the mid
                    else
                    {
                        low = mid + 1;
                    }
                }
                //Right half is sorted
                else
                {
                    //Checking if target lies in the right half
                    if (nums[mid] < target && target <= nums[high])
                    {
                        low = mid + 1;
                    }
                    //Target lies on the left side of the mid
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// https://leetcode.com/problems/search-a-2d-matrix/
        /// Logic : Treat 2D matrix as 1D matrix and use binary search
        /// Tc=O(log m*n)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rowCount = matrix.Length;
            int columnCount = matrix[0].Length;
            int low = 0, mid, high = rowCount * columnCount - 1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                int r = mid / columnCount;
                int c = mid % columnCount;
                int midValue = matrix[r][c];
                if (midValue == target)
                {
                    return true;
                }
                else if (midValue < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}