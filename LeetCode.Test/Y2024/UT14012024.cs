using LeetCode.Y2024;

namespace LeetCode.Test.Y2024
{
    public class UT14012024
    {
        [Test]
        public void ConvertDecimalToBinaryTest()
        {
            var result = LC14012024.ConvertDecimalToBinary(10);
        }

        [Test]
        public void MissingNumberTest()
        {
            var result = LC14012024.MissingNumber([1, 2, 0]);
        }

        [Test]
        public void LeftShiftTest()
        {
            var result = LC14012024.LeftShift(2, 5);
        }

        [Test]
        public void IsKBitSetForNumberTest()
        {
            var result1 = LC14012024.IsKBitSetForNumber(10, 3);
            var result2 = LC14012024.IsKBitSetForNumber(10, 2);
        }

        [Test]
        public void SetKBitForNumberTest()
        {
            var result = LC14012024.SetKBitForNumber(10, 3);
        }

        [Test]
        public void ClearKBitTest()
        {
            var result = LC14012024.ClearKBit(10, 2);
        }

        [Test]
        public void IsPowerOfTwoTest()
        {
            var result = LC14012024.IsPowerOfTwo(32);
        }
    }
}