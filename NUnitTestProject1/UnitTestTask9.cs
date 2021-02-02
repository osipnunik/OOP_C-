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
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                ohbs.MakeTurnsForAllBarrel();
                bool priseRecieved = ohbs.GettingPriseOrNot();
                if (priseRecieved)
                {
                    Assert.True(ohbs.GetBarrel1().GetResult().Equals(ohbs.GetBarrel2().GetResult()));
                    Assert.True(ohbs.GetBarrel3().GetResult().Equals(ohbs.GetBarrel2().GetResult()));
                }
            }
        }
    }
}
