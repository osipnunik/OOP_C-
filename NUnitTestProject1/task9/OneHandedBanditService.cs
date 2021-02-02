using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.task9
{
    class OneHandedBanditService
    {
        Barrel b1 = new Barrel(); 
        Barrel b2 = new Barrel();
        Barrel b3 = new Barrel();
        public bool GettingPriseOrNot()
        {
            // Create a string variable and get user input from the keyboard and store it in the variable
            if (b1.GetResult() == b2.GetResult() && b3.GetResult() == b1.GetResult())
            {
                Console.WriteLine(b1.GetResult() + " " + b2.GetResult() + " " + b3.GetResult());
                GetPrise();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MakeTurnsForAllBarrel()
        {
            b1.Turn();
            b2.Turn();
            b3.Turn();
        }
        public void EnterEnterKey()
        {
            Console.WriteLine("press enter");
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("that symbol wasn't Enter");
                this.EnterEnterKey();
            }
        }
        public Barrel GetBarrel1()
        {
            return b1;
        }
        public Barrel GetBarrel2()
        {
            return b2;
        }
        public Barrel GetBarrel3()
        {
            return b3;
        }
        public void GetPrise()
        {
            Console.WriteLine("You winn!!!");
        }

    }
}
