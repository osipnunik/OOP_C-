using NUnit.Framework;
using NUnitTestProject1_6Second.task3;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second
{
    class UnitTestTask3
    {
        private RandomArrayService service;
        [SetUp]
        public void Setup()
        {
            service = new RandomArrayService();
        }

        [Test]
        public void TestArraySize()
        {
            int size = 6;
            service.CreateRandomArray(size);
            Assert.AreEqual(service.Array.Length, size);
        }
        [Test]
        public void TestSortingAndFilling()
        {
            service.CreateRandomArray(3);
            service.FillArray();
            service.SortArray();
            Assert.IsTrue(service.Array[0] <= service.Array[1]);
            Assert.IsTrue(service.Array[1] <= service.Array[2]);
        }
    }
}
