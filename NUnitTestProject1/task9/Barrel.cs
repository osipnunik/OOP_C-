using System;

namespace NUnitTestProject1.task9
{
    class Barrel 
    {
        private int Result;
        
        public int Turn()
        {
            Random ran = new Random();
            return Result = ran.Next(0, 20);
        }
        public int GetResult()
        {
            return Result;
        }
        public void SetResult(int a)
        {
            Result = a;
        }
    }
}
