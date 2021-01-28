using ConsoleApp7_10.task10;
using ConsoleApp7_10.task7;
using ConsoleApp7_10.task9;
using System;
using System.Collections.Generic;
using ConsoleApp7_10.task8;

namespace ConsoleApp7_10
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Task7();
            //Task8();
            //Task9();
            Task10();
        }

        private static void Task10()
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddAbonent(new Abonent("234567890", "Ivanov"));
            phoneBook.AddAbonent(new Abonent("212345678", "Ivanov2"));
            phoneBook.AddAbonent(new Abonent("223456789", "Ivanov3"));
            Abonent shouldBeDeleted = new Abonent("253456789", "Ivanov99");
            phoneBook.AddAbonent(shouldBeDeleted);
            phoneBook.DeleteAbonent(shouldBeDeleted);

            List<Abonent> abonents = phoneBook.GetAllFromFile();
            Console.WriteLine("before final all printing");
            for (int i = 0; i < abonents.Count; i++)
            {
                Console.WriteLine(abonents[i]);
            }
            phoneBook.UpdateAbonent(new Abonent("223456000", "Inokentiy"), "223456789");
            List<Abonent> abonents2 = phoneBook.GetAllFromFile();
            Console.WriteLine("before final all printing");
            for (int i = 0; i < abonents2.Count; i++)
            {
                Console.WriteLine(abonents2[i]);
            }
            phoneBook.PrintOrderByAlphabetInRangeOfNumbers("212345677", "284567891");
            phoneBook.PrintOrderByAlphabetInRangeOfSurnames("Ivanov", "Ivanov2");
            phoneBook.SaveToFileSearchedNums("212345677", "234567891");
            phoneBook.SaveToFileSearchedSurnames("Ivanov", "Ivanov2");
            phoneBook.SaveAllInFile();
            List<Abonent> abonents3 = phoneBook.GetAllFromFile();
            Console.WriteLine("before final all printing");
            for(int i = 0; i < abonents3.Count; i++)
            {
                Console.WriteLine(abonents3[i]);
            }
        }

        private static void Task9()
        {
            Barrel b1 = new Barrel();
            Barrel b2 = new Barrel();
            Barrel b3 = new Barrel();
            if(b1.Turn() == b2.Turn() && b3.Turn() == b1.getResult())
            {
                Console.WriteLine(b1.getResult() + " " + b2.getResult() + " " + b3.getResult());
                Console.WriteLine("You winn!!!");
            }
        }
        private static void Task8()
        {
            String res = "sdqcg".CrossString("rgfas34");
            Console.WriteLine(res);
        }
        private static void Task7()
        {
            Auto bmw = new Auto("Bmw", 37_000);
            Auto audi = new Auto("Audi", 56_000);
            Auto niva = new Auto("NIVA", 3_000);
            Handbook handleBook = new HandbookImpl();
            handleBook.AddAuto(bmw);
            handleBook.AddAuto(audi);
            handleBook.AddAuto(niva);     //added auto
            handleBook.DeleteAuto(bmw);   //removed auto
            Auto modifiedNiva = new Auto("NIVA", 300_000);
            handleBook.UpdateAuto(modifiedNiva, "NIVA");   //modify niva 
            Console.WriteLine(handleBook.SearchAuto("NIVA").Equals(niva));  //searched auto
            handleBook.SaveToFile();                      //saved to file
            List<Auto> autos = handleBook.ExtractFromFile();   //download from file
            for(int i = 0; i < autos.Count; i++)
            {
                Console.WriteLine(autos[i]);
            }
            
        }
    }
    
}
