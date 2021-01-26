using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Rhombus : Poligon
    {
        public override void draw()
        {
            int rhombus = side;
            int center = rhombus / 2;
            for (int i = 0; i < rhombus; i++)
            {
                for (int j = 0; j < rhombus; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                        {
                            Console.Write(sign);
                        }
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        if (j >= center + i - rhombus + 1 && j <= center - i + rhombus - 1)
                        {
                            Console.Write(sign);
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

