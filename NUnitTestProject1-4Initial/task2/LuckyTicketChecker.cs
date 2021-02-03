using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NUnitTestProject1_4Initial.task2
{
    class LuckyTicketChecker
    {
        public void AskToInputTramNumberTicket()
        {
            Console.WriteLine("input please tram number(6 signs)");
        }
        public string GetUserNumber()
        {
            string tramNumber = Console.ReadLine();
            return tramNumber;
        }
        public bool Validate(string number)
        {
            string pattern = "[0-9]{6}";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(number);
        }
        public bool IsLucky(string tramNumber)
        {
            int[] arr = new int[3];
            int sum1 = 0;
            for (int i = 0; i < tramNumber.Substring(0, 3).Length; i++)
            {
                arr[i] = tramNumber[i] - '0';
                sum1 += arr[i];
                Console.WriteLine(arr[i]);
            }
            int sum2 = 0;
            for (int i = 0; i < tramNumber.Substring(3).Length; i++)
            {
                arr[i] = tramNumber[i] - '0';
                sum2 += arr[i];
                Console.WriteLine(arr[i]);
            }
            if (sum1 == sum2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
