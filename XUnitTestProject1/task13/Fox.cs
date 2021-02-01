using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_13.task13
{
    class Fox : LivePlacer
    {
        public Fox(int age)
        {
            this.Age = age;
        }

        public int Age { get; set; }
        public void Eat(Rabbit rabbit)
        {
            
        }
    }
}
