using LeetCode.Y2024.April;

namespace LeetCode.Test.Y2024.April
{
    public class UT01042024
    {
        [Test]
        public void FindKthLargestTest()
        {
            var result = LC01042024.FindKthLargest([3, 2, 1, 5, 6, 4], 2);
        }

        [Test]
        public void FibonacciSeriesTest()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(LC01042024.FibonacciSeries(i));
            }
        }

        [Test]
        public void FibonacciSeriesWithTopDownDPTest()
        {
            for (int i = 0; i < 5; i++)
            {
                int[] dp = new int[i + 1];
                dp[0] = 0;
                if (i > 0) dp[1] = 1;
                if (i > 1)
                {
                    for (int j = 2; j < dp.Length; j++)
                    {
                        dp[j] = -1;
                    }
                }
                Console.WriteLine(LC01042024.FibonacciSeriesWithTopDownDP(i, dp));
            }
        }

        [Test]
        public void FibonacciSeriesWithBottomUpDPTest()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(LC01042024.FibonacciSeriesWithBottomUpDP(i));
            }
        }

        [Test]
        public void ClimbStairsTest()
        {
            var result = LC01042024.ClimbStairs(2);
        }
    }
}