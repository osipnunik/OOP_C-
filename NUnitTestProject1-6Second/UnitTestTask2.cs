using NUnit.Framework;
using NUnitTestProject1_6Second.task2;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second
{
    class UnitTestTask2
    {
        private StringReplacer replacer;
        [SetUp]
        public void Setup()
        {
            replacer = new StringReplacer();
        }

        [Test]
        public void TestIsPolindrom()
        {
            string result = replacer.Replace("abrabr", "bra", "o-o-o");
            Assert.AreEqual("ao-o-obr", result);
        }
    }
}
