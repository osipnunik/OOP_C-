using NUnit.Framework;
using NUnitTestProject1.task10;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject1
{
    class UnitTestTask10
    {
        PhoneBook phoneBook;
        [SetUp]
        public void Setup()
        {
            phoneBook = new PhoneBook();
        }
        [Test]
        public void TestAddDeleteSaveToFileFromFile()
        {
            phoneBook.AddAbonent(new Abonent("234567890", "Ivanov"));
            phoneBook.AddAbonent(new Abonent("212345678", "Ivanov2"));
            phoneBook.AddAbonent(new Abonent("223456789", "Ivanov3"));
            Abonent shouldBeDeleted = new Abonent("253456789", "Ivanov99");
            phoneBook.AddAbonent(shouldBeDeleted);
            phoneBook.DeleteAbonent(shouldBeDeleted);
            phoneBook.SaveAllInFile();
            List<Abonent> resultAbonentsFromFile = phoneBook.GetAllFromFile();
            List<Abonent> expected = new List<Abonent>(){
                new Abonent("234567890", "Ivanov"),
                new Abonent("212345678", "Ivanov2"),
                new Abonent("223456789", "Ivanov3")
                };

            Assert.AreEqual(resultAbonentsFromFile, expected);
        }
        [Test]
        public void TestUpdateSearchVyNumberAndBySurname()
        {
            phoneBook.AddAbonent(new Abonent("234567890", "Ivanov"));
            phoneBook.AddAbonent(new Abonent("212345678", "Ivanov2"));
            Abonent newUpdated = new Abonent("333333333", "newIvanov");
            phoneBook.UpdateAbonent(newUpdated, "212345678");
            Abonent abFromNumber = phoneBook.SearchByNumber("333333333");
            Assert.IsNull(phoneBook.SearchByNumber("212345678"));
            Abonent abFromSurname = phoneBook.SearchBySurname("newIvanov");
            Assert.AreEqual(newUpdated, abFromNumber);
            Assert.AreEqual(newUpdated, abFromSurname);
        }
        [Test]
        public void TestPrinting()
        {
            string consoleOutput;
            List <Abonent> abonents = new List<Abonent>();
            abonents.Add(new Abonent("234567890", "Ivanov"));
            abonents.Add(new Abonent("212345678", "Ivanov2"));
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                //there
                phoneBook.printAbonents(abonents);
                //All console outputs goes here

                consoleOutput = stringWriter.ToString();
                Assert.AreEqual(consoleOutput, "Number: 234567890 Surname: Ivanov\r\nNumber: 212345678 Surname: Ivanov2\r\n\r\n");
            }
        }
        [Test]
        public void TestPrintAbonentsByAlphabetInRangeOfNumbers()
        {
            Abonent ababasov = new Abonent("334567890", "Ababasov");
            Abonent ziniviev = new Abonent("112345678", "Zinoviev");
            Abonent stalin = new Abonent("999999999", "Stalin");

            phoneBook.AddAbonent(ababasov);
            phoneBook.AddAbonent(ziniviev);
            phoneBook.AddAbonent(stalin);
            List<Abonent> abonents = phoneBook.PrintOrderByAlphabetInRangeOfNumbers("112345677", "334567891");
            Assert.AreEqual(ziniviev, abonents[1]);
            Assert.AreEqual(ababasov, abonents[0]);
            Assert.AreEqual(abonents.Count, 2);
        }
        [Test]
        public void TestPrintAbonentsByAlphabetInRangeOfSurnames()
        {
            Abonent ababasov = new Abonent("334567890", "Ababasov");
            Abonent ziniviev = new Abonent("112345678", "Zinoviev");
            Abonent stalin = new Abonent("999999999", "Stalin");

            phoneBook.AddAbonent(ababasov);
            phoneBook.AddAbonent(ziniviev);
            phoneBook.AddAbonent(stalin);
            List<Abonent> abonents = phoneBook.PrintOrderByAlphabetInRangeOfSurnames("Ababasov", "Zinoviev");
            Assert.AreEqual(ababasov, abonents[0]);
            Assert.AreEqual(stalin, abonents[1]);
            Assert.AreEqual(ziniviev, abonents[2]);
            Assert.AreEqual(abonents.Count, 3);
        }
    }
}
