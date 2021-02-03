using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task2
{
    class StringReplacer
    {
        public string Replace(string text, string searched, string to)
        {
            if (text.Contains(searched))
            {
                string newString = text.Replace(searched, to);
                Console.WriteLine(newString);
                return newString;
            }
            return text;
        }
    }
}
