using LeetCode.Y2023.December;

namespace LeetCode.Test.Y2023.December
{
    public class UT09122023
    {
        [Test]
        public void FizzBuzzTest()
        {
            var result = LC09122023.FizzBuzz(15);
        }

        [Test]
        public void MaxOfThreeTest()
        {
            var result = LC09122023.MaxOfThree(3, -9, 88);
        }

        [Test]
        public void MinOfThreeTest()
        {
            var result = LC09122023.MinOfThree(3, -9, 88);
        }

        [Test]
        public void MidOfThreeTest()
        {
            var result = LC09122023.MidOfThree(3, -9, 88);
        }

        [Test]
        public void PrintNumberSeriesTest()
        {
            LC09122023.PrintNumberSeries(5);
        }

        [Test]
        public void PrintReverseNumberSeries()
        {
            LC09122023.PrintReverseNumberSeries(5);
        }

        [Test]
        public void ReturnOddElementsTest()
        {
            var result = LC09122023.ReturnOddElements([1, 5, 6, 4, 3, 2, 8]);
        }

        [Test]
        public void SumOfElementTest()
        {
            int result = LC09122023.SumOfElement([1, 2, 6, 3, 5]);
        }

        [Test]
        public void FirstEvenNumberTest()
        {
            int result = LC09122023.FirstEvenNumber([1, 2, 6, 3, 5]);
        }

        [Test]
        public void ReverseTest()
        {
            var result = LC09122023.Reverse(-2147483648);
        }

        [Test]
        public void IsValidTest()
        {
            var result = LC09122023.IsValid("()[]{}");
        }
    }
}