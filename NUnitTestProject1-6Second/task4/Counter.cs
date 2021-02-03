using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task4
{
    class Counter
    {
        private int value = 0;
        private const int maxVal = 100;
        private const int minVal = 0;
        public void setValue(int value)
        {
            if (value <= maxVal && value >= minVal)
            {
                this.value = value;
            }
            else
            {
                Console.WriteLine("value beyond the range");
            }
        }
        public void incrementOn1()
        {
            if (value == maxVal)
            {
                value = minVal;
                return;
            }
            value++;
        }
        public void setMax()
        {
            value = maxVal;
        }
        public void setMin()
        {
            value = minVal;
        }

        internal int getValue()
        {
            return value;
        }
    }
}
