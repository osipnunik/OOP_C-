using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.task5
{
    class Rectangle : Poligon
    {
        public override void Draw()
        {
            for (int i = 0; i < base.getSide(); i++)
            {
                for (int j = 0; j < base.getSide(); j++)
                {
                    Console.Write(base.getSign());
                }
                Console.WriteLine();
            }
        }
    }
}
