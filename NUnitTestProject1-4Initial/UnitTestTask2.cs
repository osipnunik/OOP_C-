using NUnit.Framework;
using NUnitTestProject1_4Initial.task2;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_4Initial
{
    class UnitTestTask2
    {
        private LuckyTicketChecker checker;
        [SetUp]
        public void Setup()
        {
            checker = new LuckyTicketChecker(); 
        }

        [Test]
        public void TestValidation()
        {
            string notNumeric = "abc123";
            Assert.IsFalse(checker.Validate(notNumeric));
        }
        [Test]
        public void TestIsLucky()
        {
            Assert.IsTrue(checker.IsLucky("123321"));
        }
    }
}
