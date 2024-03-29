﻿using LeetCode.Y2023.December;

namespace LeetCode.Test.Y2023.December
{
    public class UT24122023
    {
        [Test]
        public void TwoSumTest()
        {
            var resul2 = LC24122023.TwoSum([3, 3], 6);
            var result1 = LC24122023.TwoSumWithTwoLoops([2, 7, 11, 15], 9);
            var result = LC24122023.TwoSum([2, 7, 11, 15], 9);
            Assert.That(result, Is.Not.Null);
            result = LC24122023.TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void TwoSumRetBoolTest()
        {
            var resul2 = LC24122023.TwoSumTwoPointer([2, 7, 11, 15], 9);
        }

        [Test]
        public void TwoSumArraySortedTest()
        {
            var result = LC24122023.TwoSumArraySorted([2, 7, 11, 15], 9);
        }

        [Test]
        public void MergeTwoSortedArrayTest()
        {
            var result1 = LC24122023.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
            var result2 = LC24122023.Merge([1], 1, [], 0);
        }

        [Test]
        public void GeneratePascalTraingleTest()
        {
            var result = LC24122023.GeneratePascalTraingle(5);
        }

        [Test]
        public void GetRowTest()
        {
            var result = LC24122023.GetRow(3);
        }

        [Test]
        public void MaxProfitTest()
        {
            var result1 = LC24122023.MaxProfit([7, 1, 5, 3, 6, 4]);
            var result2 = LC24122023.MaxProfit([7, 6, 4, 3, 1]);
        }

        [Test]
        public void MaxProfit2Test()
        {
            var result1 = LC24122023.MaxProfit2([7, 1, 5, 3, 2, 10]);
            var result2 = LC24122023.MaxProfit2([7, 1, 5, 3, 6, 4]);
        }

        [Test]
        public void MajorityElementTest()
        {
            var result1 = LC24122023.MajorityElementOptimised([2, 2, 1, 1, 1, 2, 2]);
            var result2 = LC24122023.MajorityElement([2, 2, 1, 1, 1, 2, 2]);
        }

        [Test]
        public void MajorityElement2Test()
        {
            var result1 = LC24122023.MajorityElementMooreVoting([2, 2, 1, 3]);
            var result2 = LC24122023.MajorityElement2([3, 2, 3]);
        }

        [Test]
        public void ThreeSumTest()
        {
            var res1 = LC24122023.ThreeSum([-1, 0, 1, 2, -1, -4]);
            var res2 = LC24122023.ThreeSum([0, 0, 0, 0]);
        }

        [Test]
        public void ThreeSumClosestTest()
        {
            var result1 = LC24122023.ThreeSumClosest([-1, 2, 1, -4], 1);
            var result2 = LC24122023.ThreeSumClosest([1, 1, 1, 1], 4);
        }

        [Test]
        public void FourSumTest()
        {
            var result1 = LC24122023.FourSum([1000000000, 1000000000, 1000000000, 1000000000], -294967296);
            var result2 = LC24122023.FourSum([2, 2, 2, 2, 2], 8);
            var result3 = LC24122023.FourSum([1, 0, -1, 0, -2, 2], 0);
        }

        [Test]
        public void RotateTest()
        {
            LC24122023.Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
        }
    }
}