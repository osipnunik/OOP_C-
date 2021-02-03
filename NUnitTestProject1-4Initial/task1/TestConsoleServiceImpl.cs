using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_4Initial.task1
{
    class TestConsoleServiceImpl : ConsoleService
    {
        private int Data;
        
         public char[] GetCharArray()
        {
            Console.WriteLine(Data.ToString().ToCharArray());
            return Data.ToString().ToCharArray();
        }
        public TestConsoleServiceImpl(int data)
        {
            this.Data = data;
        }
        public int GetNumber()
        {
            return Data;
        }
         
    }
}
