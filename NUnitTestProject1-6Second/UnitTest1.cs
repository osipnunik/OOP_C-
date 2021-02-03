using NUnit.Framework;
using NUnitTestProject1_6Second.task1;

namespace NUnitTestProject1_6Second
{
    public class Tests
    {
        private StringReverser reverser;
        [SetUp]
        public void Setup()
        {
            reverser = new StringReverser();
        }

        [Test]
        public void TestIsPolindrom()
        {
            Assert.IsTrue(reverser.isPolindrom("123a321"));
        }
    }
}