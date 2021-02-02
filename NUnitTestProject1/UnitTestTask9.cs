using NUnit.Framework;
using NUnitTestProject1.task9;
using System;
using System.IO;

namespace NUnitTestProject1
{
    class UnitTestTask9
    {
        [Test]
        public void Test1()
        {
            OneHandedBanditService ohbs = new OneHandedBanditService();
            //ohbs.EnterEnterKey();
            using (StringWriter stringWriter = new StringWriter())
            {
                //ohbs.StartGame();
                Console.SetOut(stringWriter);
                ohbs.StartGame();
                
                //All console outputs goes here
                //Console.WriteLine("You are travelling north at a speed of 10m/s");

                string consoleOutput = stringWriter.ToString();
                Assert.AreEqual("myLine:", consoleOutput);
            }
        }
    }
}
