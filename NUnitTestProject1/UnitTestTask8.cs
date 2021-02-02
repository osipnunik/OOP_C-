using NUnit.Framework;
using NUnitTestProject1.task8;
using System;

namespace NUnitTestProject1
{
    class UnitTestTask8
    {
     
        [Test]
        public void TestAddAndSearch()
        {
            string init = "abc";
            string result = StringExtension.CrossString(init, "cbghj");
            Assert.AreEqual("bc", result);
        }
    }
}
