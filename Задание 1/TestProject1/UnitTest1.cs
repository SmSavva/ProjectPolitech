using NUnit.Framework;
using System;
using ConsoleApp1;

namespace TestProject1
{
    public class TestMatrix
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void SumEl_Asc()
        {
            int[][] mas = {
            new int[] {2,3,41},
            new int[] {3,2,5},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {3,2,5},
                new int[] {1,2,9},
                new int[] {2,3,41}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(SumElements.Sort, true, mas), mas_sort);
        }
        [Test]
        public void SumEl_Desc()
        {
            int[][] mas = {
            new int[] {2,3,41},
            new int[] {3,2,5},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {2,3,41},
                new int[] {1,2,9},
                new int[] {3,2,5}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(SumElements.Sort, false, mas), mas_sort);
        }

        [Test]
        public void MaxEl_Asc()
        {
            int[][] mas = {
            new int[] {2,3,41},
            new int[] {3,2,5},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {3,2,5},
                new int[] {1,2,9},
                new int[] {2,3,41}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(MaxElement.Sort, true, mas), mas_sort);
        }
        [Test]
        public void MaxEl_Desc()
        {
            int[][] mas = {
            new int[] {2,3,41},
            new int[] {3,2,10},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {2,3,41},
                new int[] {3,2,10},
                new int[] {1,2,9}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(MaxElement.Sort, false, mas), mas_sort);
        }

        [Test]
        public void MinEl_Asc()
        {
            int[][] mas = {
            new int[] {7,3,41},
            new int[] {3,0,5},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {3,0,5},
                new int[] {1,2,9},
                new int[] {7,3,41}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(MinElement.Sort, true, mas), mas_sort);
        }
        [Test]
        public void MinEl_Desc()
        {
            int[][] mas = {
            new int[] {7,3,41},
            new int[] {3,0,5},
            new int[] {1,2,9} };
            int[][] mas_sort =
            {
                new int[] {7,3,41},
                new int[] {1,2,9},
                new int[] {3,0,5}
            };
            Matrix res = new Matrix();
            Assert.AreEqual(res.Sort(MinElement.Sort, false, mas), mas_sort);
        }
    }
}