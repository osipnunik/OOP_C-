using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_4Initial.task4
{
    class Painter
    {
        public void PaintRomb()
        {
            Console.WriteLine("input side of flag");
            int a = Convert.ToInt32(Console.ReadLine());
            int t = 4;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ((i > a / 2 - t && i < a / 2 + t) || (j > a / 2 - t && j < a / 2 + t))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
