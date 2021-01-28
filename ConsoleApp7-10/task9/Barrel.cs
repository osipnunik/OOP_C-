using System;

namespace ConsoleApp7_10.task9
{
    class Barrel 
    {
        private int Result;
        public int Turn()
        {
            Random ran = new Random();
            return Result = ran.Next(0, 20);
        }
        public int getResult()
        {
            return Result;
        }
    }
}
