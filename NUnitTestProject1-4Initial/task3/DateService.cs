using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NUnitTestProject1_4Initial.task3
{
    class DateService
    {
        public int GetDays(string date)
        {
           
            //accepts date in MM/dd/yyyy format
            DateTime Dob = DateTime.Parse(date); 
            DateTime currTimeAndDate = DateTime.Now;
            Console.WriteLine("Today's time and date is {0}\n", currTimeAndDate);
            return (int)Math.Round((currTimeAndDate - Dob).TotalDays);
        }
        public string GetDateFromUser()
        {
            Console.WriteLine("Enter date of Birth in format DD/MM/YYYY: ");
            string a = Console.ReadLine();
            Console.WriteLine("inputed " + a);
            return a;
        }
        public bool Validate(string date)
        {
            string pattern = "[0-9]{2}(//)[0-9]{2}(//)[0-9]{4}";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(date);
        }
    }
}
