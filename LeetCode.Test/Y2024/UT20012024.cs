using LeetCode.Y2024;

namespace LeetCode.Test.Y2024
{
    public class UT20012024
    {

        [Test]
        public void GenerateMatrixTest()
        {
            var result = LC20012024.GenerateMatrix(3);
        }

        [Test]
        public void RecursivePrintTest()
        {
            LC20012024.RecursivePrint(5);
        }

        [Test]
        public void RecursivePrintReverseTest()
        {
            LC20012024.RecursivePrintReverse(5);
        }

        [Test]
        public void FibTest()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(LC20012024.Fib(i));
            }
        }

        [Test]
        public void IsPowerOfTwoTest()
        {
            var result = LC20012024.IsPowerOfTwo(32);
        }
    }
}