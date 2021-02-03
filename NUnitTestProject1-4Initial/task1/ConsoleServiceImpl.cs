using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_4Initial.task1
{
    class ConsoleServiceImpl : ConsoleService
    {
        char[] CharArr;
        public char[] GetCharArray()
        {
            return CharArr;
        }

        virtual public int GetNumber()
        {
            string numStr = Console.ReadLine();
            CharArr = numStr.ToCharArray();
            int number = Int32.Parse(numStr);
            return number;
        }
    }
}
