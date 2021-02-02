using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NUnitTestProject1.task10
{
    class PhoneBook
    {
        private List<Abonent> abonents = new List<Abonent>();
        private const string fileName = "abonents.dat";
        public void AddAbonent(Abonent abonent)
        {
            abonents.Add(abonent);
        }
        public void DeleteAbonent(Abonent abonent)
        {
            abonents.Remove(abonent);
        }
        public void UpdateAbonent(Abonent abonent, string number)
        {
            for(int i = 0; i < abonents.Count; i++)
            {
                if (abonents[i].Number.Equals(number))
                {
                    abonents[i] = abonent;
                }
            }
        }
        public Abonent SearchByNumber(string number)
        {
            for (int i = 0; i < abonents.Count; i++)
            {
                if (abonents[i].Number.Equals(number))
                {
                    return abonents[i];
                }
            }
            return null;
        }
        public Abonent SearchBySurname(string surname)
        {
            for (int i = 0; i < abonents.Count; i++)
            {
                if (abonents[i].Surname.Equals(surname))
                {
                    return abonents[i];
                }
            }
            return null;
        }
        public List<Abonent> PrintOrderByAlphabetInRangeOfNumbers(string firstNum, string secNum)
        {
            List<Abonent> unsorted = new List<Abonent>();
            for(int i = 0; i < abonents.Count; i++)
            {
                if (int.Parse(abonents[i].Number) > int.Parse(firstNum) &&
                    int.Parse(abonents[i].Number) < int.Parse(secNum))
                {
                    unsorted.Add(abonents[i]);
                }
            }
            unsorted.Sort();
            printAbonents(unsorted);
            return unsorted;
        }
        public List<Abonent> PrintOrderByAlphabetInRangeOfSurnames(string firstSurname, string secSurname)
        {
            List<Abonent> unsorted = new List<Abonent>();
            for (int i = 0; i < abonents.Count; i++)
            {
                if (abonents[i].Surname.CompareTo(firstSurname) >=0 &&
                    abonents[i].Surname.CompareTo(secSurname) <=0)
                {
                    unsorted.Add(abonents[i]);
                }
            }
            unsorted.Sort();
            printAbonents(unsorted);
            return unsorted;
        }
        public void printAbonents(List<Abonent> abonents)
        {
            foreach (Abonent ab in abonents)
            {
                Console.WriteLine(ab);
            }
            Console.WriteLine();
        }
        public void SaveToFileSearchedNums(string firstNum, string secNum)
        {
            List<Abonent> foundAbonents = this.PrintOrderByAlphabetInRangeOfNumbers(firstNum, secNum);
            using (Stream str = File.Open(fileName, FileMode.Append))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, foundAbonents);
                str.Close();
            }      
        }
        public void SaveToFileSearchedSurnames(string firstSurname, string secSurname)
        {
            List<Abonent> foundAbonents = this.PrintOrderByAlphabetInRangeOfSurnames(firstSurname, secSurname);
            using (Stream str = File.Open(fileName, FileMode.Append))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, foundAbonents);
                str.Close();
            }
        }
        public void SaveAllInFile()
        {
            using (Stream str = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, abonents);
                str.Close();
            }
        }
        public List<Abonent> GetAllFromFile()
        {
            Stream str = File.Open(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Abonent> autos = (List<Abonent>)bf.Deserialize(str);
            str.Close();
            return abonents;
        }
    }
}