using NUnit.Framework;
using NUnitTestProject1.task7;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        Handbook handbook;
        [SetUp]
        public void Setup()
        {
            handbook = new HandbookImpl();
        }

        [Test]
        public void TestAddAndSearch()
        {
            Auto expected = new Auto("Bmw", 50_000);
            handbook.AddAuto(expected);
            Auto resultAuto = handbook.SearchAuto("Bmw");
            Assert.AreEqual(expected, resultAuto);
        }
        [Test]
        public void TestDeleteAndSavingToFile()
        {
            Auto added = new Auto("Bmw", 50_000);
            handbook.AddAuto(added);
            handbook.DeleteAuto(added);
            handbook.SaveToFile();
            List<Auto> emptyList = handbook.ExtractFromFile();
            Assert.IsTrue(emptyList.Count == 0);
        }
        [Test]
        public void TestUpdate()
        {
            Auto audi = new Auto("Audi", 56_000);
            Auto initialNiva = new Auto("NIVA", 3_000);

            handbook.AddAuto(audi);
            handbook.AddAuto(initialNiva);

            Auto modifiedNiva = new Auto("NIVA", 300_000);
            handbook.UpdateAuto(modifiedNiva, "NIVA");
            Auto resultNiva = handbook.SearchAuto("NIVA");
            Assert.AreEqual(modifiedNiva, resultNiva);
        }
        
        }
}