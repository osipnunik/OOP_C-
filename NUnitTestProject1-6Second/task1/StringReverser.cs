using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task1
{
    class StringReverser
    {
        public bool isPolindrom(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string new1 = new string(charArray);
            return input.Equals(new1);
        }
    }
}
