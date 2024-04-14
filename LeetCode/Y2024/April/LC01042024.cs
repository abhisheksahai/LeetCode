namespace LeetCode.Y2024.April
{
    public class LC01042024
    {
        public class LRUCache
        {
            public class Node
            {
                public int Key { get; init; }
            }

            public LRUCache(int capacity)
            {

            }

            public int Get(int key)
            {
                return -1;
            }

            public void Put(int key, int value)
            {

            }
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/minimum-cost-of-ropes-1587115620/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long MinCost(long[] arr, int n)
        {
            long cost = 0;
            PriorityQueue<long, int> pq = new PriorityQueue<long, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                pq.Enqueue(arr[i], 0);
            }
            return cost;
        }


        /// <summary>
        /// https://leetcode.com/problems/kth-largest-element-in-an-array/
        /// SC=O(k) and TC=O(nlogk)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                pq.Enqueue(nums[i], nums[i]);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
            return pq.Peek();
        }

        /// <summary>
        /// This is handled internally by framework if we use priority queue.Its better to know the logic
        /// https://www.geeksforgeeks.org/time-complexity-of-building-a-heap/
        /// Tc=O(), SC=O()
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="N"></param>
        /// <param name="i"></param>
        static void Heapify(int[] arr, int N, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            if (l < N && arr[l] > arr[largest])
                largest = l;

            if (r < N && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, N, largest);
            }
        }


        /// <summary>
        /// https://www.geeksforgeeks.org/problems/merge-k-sorted-arrays/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static List<int> MergeKArrays(List<List<int>> arr, int K)
        {
            List<int> result = new List<int>();
            return result;
        }

        //Dynamic Programming : Its about rememebring your past. It reduces TC by trading off time and space it uses extra space. It has two appproaches : Top down approach and Bottom Up approach

        /// <summary>
        /// Fibonacci Series
        /// Tc=O(2^n) and SC=O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciSeries(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }

        /// <summary>
        /// Dynamic programming top down approach.
        /// Tc=O(N) and SC=O(N)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciSeriesWithTopDownDP(int n, int[] dp)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            if (dp[n] != -1)
            {
                return dp[n];
            }
            if (dp[n - 1] == -1)
            {
                dp[n - 1] = FibonacciSeriesWithTopDownDP(n - 1, dp);
            }
            if (dp[n - 2] == -1)
            {
                dp[n - 2] = FibonacciSeriesWithTopDownDP(n - 2, dp);
            }
            dp[n] = dp[n - 1] + dp[n - 2];
            return dp[n];
        }

        /// <summary>
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="n"></param>
        public static int FibonacciSeriesWithBottomUpDP(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        /// <summary>
        /// https://leetcode.com/problems/climbing-stairs/
        /// TC=O(N) and SC=O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/problems/distinct-coloring--170645/1
        /// </summary>
        /// <param name="N"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long DistinctColoring(int N, int[] r, int[] g, int[] b)
        {
            return 0;
        }


        /// <summary>
        /// https://www.geeksforgeeks.org/problems/0-1-knapsack-problem0945/1
        /// </summary>
        /// <param name="W"></param>
        /// <param name="wt"></param>
        /// <param name="val"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int KnapSack(int W, int[] wt, int[] val, int n)
        {
            return 0;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-common-subsequence/
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            return 0;
        }

        /// <summary>
        /// https://leetcode.com/problems/longest-increasing-subsequence/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LengthOfLIS(int[] nums)
        {
            return 0;
        }

    }
}