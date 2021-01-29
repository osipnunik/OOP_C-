using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_13.task12
{
    class Handbook
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Activity { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + " Owner: " + Owner + " Phone: " + Phone + " Address: " + Address +
                " Activity: " + Activity;
        }
    }
}
