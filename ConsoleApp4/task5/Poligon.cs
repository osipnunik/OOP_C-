using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.task5
{
    abstract class Poligon
    {
        private int Side = 20;

        private const char Sign = '*';
        public abstract void Draw();
        public char getSign()
        {
            return Sign;
        }
        public int getSide()
        {
            return Side;
        }
             }
        }
