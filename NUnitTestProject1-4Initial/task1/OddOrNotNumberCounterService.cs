using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_4Initial.task1
{
    class OddOrNotNumberCounterService
    {
        private int Number;
        ConsoleService consoleService;
        public int OddPercentage;
        public int EvenPercentage;
        public OddOrNotNumberCounterService(ConsoleService consoleService)
        {
            this.consoleService = consoleService;
        }
        internal int InputNumberBetween100To100000000()
        {
            Number = consoleService.GetNumber(); ;
            return Number;
        }

        internal int GetGeneratedNumber()
        {
            return Number;
        }

        internal bool? Validate(int v)
        {
            if(v < 100) { return false; }
            if(v > 100_000_000)
            {
                return false;
            }
            return true;
        }

        internal void CalculatePercentage()
        {
            byte evenCount = 0;
            byte oddCount = 0;
            char[] charArr = consoleService.GetCharArray();
            Console.WriteLine(charArr.Length);
            for (int i = 0; i < charArr.Length; i++)
            {
                int num = int.Parse(charArr[i].ToString());
                if (num % 2 == 0) { evenCount++; } else { ++oddCount; }
            }
            OddPercentage = (100 * oddCount) / (evenCount + oddCount);
            EvenPercentage = (100 * evenCount) / (evenCount + oddCount);
        }
        public int GetOddPercentage()
        {
            return OddPercentage;
        }
        public int GetEvenPercentage()
        {
            return EvenPercentage;
        }
    }
}
