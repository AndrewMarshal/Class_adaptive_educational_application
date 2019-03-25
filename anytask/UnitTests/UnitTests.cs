using System;
using System.Collections.Generic;
using ClassSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        public readonly Random rnd = new Random();
        [TestMethod]
        public void Test1()
        {
            bool first = false, second = false;
            var massive = new int[3];
            for(int i = 0; i < 3; i++)
            {
                massive[i] = rnd.Next(0, 5);
            }
            Sort.QuickSort(massive);
            if (massive[1] >= massive[0])
                first = true;
            if (massive[1] <= massive[2])
                second = true;
            Assert.AreEqual(true, first);
            Assert.AreEqual(true, second);
        }
        [TestMethod]
        public void Test2()
        {
            var e = rnd.Next(0, 5);
            var sortedMassive = new int[100];
            for (int i = 0; i < 100; i++)
            {
                sortedMassive[i] = e;
            }
            var massive = sortedMassive;
            Sort.QuickSort(sortedMassive);
            Assert.AreEqual(massive, sortedMassive);
        }
        [TestMethod]
        public void Test3()
        {
            var e = rnd.Next(0, 5);
            var massive = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                massive[i] = e;
            }
            Sort.QuickSort(massive);
            var counter = 0;
            for (int i = 0; i < 10; i++)
            {
                var check = rnd.Next(1, 999);
                if (massive[check - 1] <= massive[check])
                    counter++;
            }
            Assert.AreEqual(10, counter);
        }
        [TestMethod]
        public void Test4()
        {
            List<int> massive = new List<int>();
            var currentMassive = massive.ToArray();
            Sort.QuickSort(currentMassive);
            Assert.AreEqual(0, currentMassive.Length);
        }

        [TestMethod]
        public void Test5()
        {
            var e = rnd.Next(0, 5);
            var sortedMassive = new int[1500000000];
            for (int i = 0; i < 1500000000; i++)
            {
                sortedMassive[i] = e;
            }
            var massive = sortedMassive;
            Sort.QuickSort(sortedMassive);
            Assert.AreEqual(massive, sortedMassive);
        }
    }
}
