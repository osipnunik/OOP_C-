using System;
using ConsoleApp12_13.task12;
using System.Xml.Linq;
using System.Collections.Generic;
using ConsoleApp12_13.task13;
using System.Threading;

namespace ConsoleApp12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Task12Linq();
            //Task12WithoutLinq();
            //Task13();
        }

        private static void Task13()
        {
            LifeAbscence la = new LifeAbscence();
            la.WorldCreation();
            while (true)
            {
                Thread.Sleep(1_000);
                la.Living1Year();
            }
        }

        private static void Task12Linq()
        {
            HandBookLinqService service = new HandBookLinqService();
            service.CreateXmlFile();    //добавление всех записей
            service.ShowAll();  //показ всех записей
            Console.WriteLine(service.SearchByName("CocaCola"));  //по названию
            Console.WriteLine(service.SearchByOwner("Obama"));      //по владельцу
            Console.WriteLine(service.SearchByPhone("095784361"));  //по номеру телефона
            Console.WriteLine(service.SearchByActivity("drinks"));  //по деятельности

            Handbook company = new Handbook();
            company.Name = "Bmw";
            company.Owner = "Gans Christian Andersen";
            company.Phone = "98472948724";
            company.Address = "Berlin";
            company.Activity = "Autoes";
            service.AddCompany(company);   //pposibility of writing another
        }
        private static void Task12WithoutLinq()
        {
            HandbookService service = new HandbookService();
            Console.WriteLine(service.SearchByName("CocaCola"));
            Console.WriteLine(service.SearchByOwner("Obama"));
            Console.WriteLine(service.SearchByPhone("09578426"));
            Console.WriteLine(service.SearchByActivity("dresses"));
            service.ShowAllCompanies();
        }
    }
 }

