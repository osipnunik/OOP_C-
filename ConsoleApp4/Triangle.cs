using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Triangle : Poligon
    {
        public override void draw()
        {
            for(int i = 0; i < side; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}
