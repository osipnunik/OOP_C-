using NUnit.Framework;
using NUnitTestProject1_6Second.task4;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second
{
    class UnitTestTask4
    {
        
        [Test]
        public void TestAll()
        {
            Counter counter = new Counter();
            counter.setMax();
            counter.incrementOn1();
            Assert.AreEqual(0, counter.getValue()); //0
            counter.setValue(3);
            counter.incrementOn1();
            Assert.AreEqual(4, counter.getValue()); // 4
        }
     }
}
