using ConsoleApp4.task5;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.task5
{
    class Rhombus : Poligon
    {
        public override void Draw()
        {
            int rhombus = base.getSide();
            int center = rhombus / 2;
            for (int i = 0; i < rhombus; i++)
            {
                for (int j = 0; j < rhombus; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                        {
                            Console.Write(getSign());
                        }
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i - rhombus + 1 && j <= center - i + rhombus - 1)
                        {
                            Console.Write(getSign());
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
 }

