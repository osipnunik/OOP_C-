using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTask11.task11
{
    class MessageService
    {
        internal void PleaAccepted()
        {
            Console.WriteLine("Good");
        }

        internal void PleaDenyed()
        {
            Console.WriteLine("Bad");
        }

        internal void WrongKey()
        {
            Console.WriteLine("Other key pressed! (not Y or N)");
        }

        internal void DeathMessage()
        {
            Console.WriteLine("Your pet is dead!!!");
        }
    }
}
