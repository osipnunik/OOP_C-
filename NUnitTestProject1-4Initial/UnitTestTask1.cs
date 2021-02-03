using NUnit.Framework;
using NUnitTestProject1_4Initial.task1;

namespace NUnitTestProject1_4Initial
{
    public class UnitTestTask1
    {
        OddOrNotNumberCounterService service;
        [SetUp]
        public void Setup()
        {
            service = new OddOrNotNumberCounterService(new TestConsoleServiceImpl(100));
        }

        [Test]
        public void TestRange()
        {
            for (int i = 0; i < 10; i++)
            {
                service.InputNumberBetween100To100000000();
                int result = service.GetGeneratedNumber();
                Assert.IsTrue(result >= 100, "result should be > or = 100");
                Assert.IsTrue(result <= 100_000_000, "result should be < or = 100 000 000");
            }
        }
        [Test]
        public void TestValidation()
        {
            Assert.IsTrue(service.Validate(100), "it is should be valid number");
            Assert.IsTrue(service.Validate(100_000_000), "it is should be valid number");
        }
        [Test]
        public void TestResult()
        {
            service = new OddOrNotNumberCounterService(new TestConsoleServiceImpl(1000));
            int numberGetted = service.InputNumberBetween100To100000000();
            service.CalculatePercentage();
            Assert.AreEqual(100, (service.GetEvenPercentage() + service.GetOddPercentage()));
        }
    }
}