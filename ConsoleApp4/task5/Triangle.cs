using ConsoleApp4.task5;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.task5
{
    class Triangle : Poligon
    {
        public override void Draw()
        {
            for(int i = 0; i < base.getSide(); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(getSign());
                }
                Console.WriteLine();
            }
        }
    }
}
