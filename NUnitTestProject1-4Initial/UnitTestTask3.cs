using NUnit.Framework;
using NUnitTestProject1_4Initial.task3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject1_4Initial
{
    class UnitTestTask3
    {
        DateService service;
        [SetUp]
        public void Setup()
        {
            service = new DateService();
        }

        [Test]
        public void TestDays()
        {
            string d = "01/01/2021";
            int daysRes = service.GetDays(d);
            Console.WriteLine(daysRes);
        }
        [Test]
        public void TestValidation()
        {
            Assert.IsFalse(service.Validate("abbaabba"));
        }
        [Test]
        public void TestGetFromUserViaSetIn()//подмена переменной In
        {
            string s = "03/01/2021";
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            MemoryStream stream = new MemoryStream(byteArray);
            using (StreamReader sr = new StreamReader(stream))
            {
                Console.SetIn(sr);
                string res = service.GetDateFromUser();
                Assert.AreEqual(s, res);           
            }
        }
    }
}
