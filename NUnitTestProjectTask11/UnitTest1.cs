using Moq;
using NUnit.Framework;
using NUnitTestProjectTask11.task11;
using System;
using System.IO;
using System.Text;

namespace NUnitTestProjectTask11
{
    public class Tests
    {
        Creature carl;
        [SetUp]
        public void Setup()
        {
            carl = new Creature("Carl");
        }

        [Test]
        public void TestPleaCouldntBeTheSame()
        {
            carl.PreviousPlea = Plea.Eat;
            carl.Plea = new PleaOperator().GeneratePleaRandomly(Plea.Eat);
            Assert.AreNotEqual(Plea.Eat, carl.Plea);
            new PleaOperator().setPreviousPlea(carl);
            Assert.AreEqual(carl.PreviousPlea, carl.Plea);
        }
        [Test]
        public void TestDeath()
        {
            carl.LifeResource = 0;
            DeathResolver resolver = new DeathResolver();
            Assert.IsTrue(resolver.IsDead(carl));
        }
    }
}