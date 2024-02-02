namespace LeetCode.Y2024
{
    public class LC20012024
    {
        /// <summary>
        /// https://leetcode.com/problems/spiral-matrix-ii/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            int num = 1;
            int left = 0, right = n - 1, top = 0, bottom = n - 1;
            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++)
                {
                    result[top][i] = num++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    result[i][right] = num++;
                }
                right--;

                for (int i = right; i >= left; i--)
                {
                    result[bottom][i] = num++;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    result[i][left] = num++;
                }
                left++;
            }

            return result;
        }

        public static void RecursivePrint(int num)
        {
            if (num <= 0) return;
            Console.WriteLine(num);
            RecursivePrint(num - 1);
        }

        public static void RecursivePrintReverse(int num)
        {
            if (num <= 0) return;
            RecursivePrintReverse(num - 1);
            Console.WriteLine(num);
        }

        /// <summary>
        /// TC=O(2^n)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Fib(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return Fib(num - 1) + Fib(num - 2);
            }
        }

        /// <summary>
        /// Tc=O(n) and SC=O(n)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Power(int m, int n)
        {
            if (n == 0) return 1;
            return m * Power(m, n - 1);
        }

        /// <summary>
        /// TC=O(log n)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int PowerOptimised(int m, int n)
        {
            if (n == 0) return 1;
            if (n % 2 == 0)
            {
                return PowerOptimised(m * m, n / 2);
            }
            else
            {
                return m * PowerOptimised(m * m, (n - 1) / 2);
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/power-of-two/
        /// TC=O(logN) and SC=
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            if (n % 2 == 0)
            {
                return IsPowerOfTwo(n / 2);
            }
            return false;
        }

        /// <summary>
        /// https://leetcode.com/problems/powx-n/
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double MyPow(double x, int n)
        {
            long num = n;
            if (n == 0) return 1;
            if (n < 0)
            {
                x = 1 / x;
                num = -num;
            }
            if (num % 2 == 0)
            {
                num = num / 2;
                return MyPow(x * x, Convert.ToInt32(num));
            }
            else
            {
                num = (num-1) / 2;
                return x * MyPow(x * x, Convert.ToInt32(num));
            }
        }

        /// <summary>
        /// https://leetcode.com/problems/count-good-numbers/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountGoodNumbers(long n)
        {
            int result = 0;
            return result;
        }
    }
}