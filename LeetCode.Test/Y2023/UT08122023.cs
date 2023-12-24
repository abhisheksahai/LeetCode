using LeetCode.Y2023;

namespace LeetCode.Test.Y2023
{
    public class UT08122023
    {
        [Test]
        public void MinOfThreeNumbersTest()
        {
            int result = LC08122023.MinOfThreeNumbers(2, 8, -11);
        }

        [Test]
        public void CoupleEligibleForMarriageTest()
        {
            LC08122023.CoupleEligibleForMarriage(17, 25);
        }

        [Test]
        public void TaxAmountTest()
        {
            LC08122023.TaxAmount(60000);
        }

        [Test]
        public void IsLeapTest()
        {
            var result = LC08122023.IsLeap(2024);
        }

        [Test]
        public void OddOrEvenTest()
        {
            LC08122023.OddOrEven(123);
        }

    }
}