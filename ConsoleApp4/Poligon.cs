using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    abstract class Poligon
    {
        public int side = 20;
        public char sign = '*';
        public abstract void draw(); 
    }
}
