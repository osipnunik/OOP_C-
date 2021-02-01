using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_13.task13
{
    class Rabbit : LivePlacer
    {
        public int Age { get; set; }

        public Rabbit(int age)
        {
            this.Age = age;
        }
        public void Eat(Grass grass)
        {

        }
    }
}
