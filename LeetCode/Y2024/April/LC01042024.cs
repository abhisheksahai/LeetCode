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
        /// This is handle internally by framework if we use priority queue.Its better to know the logic
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
    }
}