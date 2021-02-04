using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTask11.task11
{
    class ConsoleInputServiceImpl : ConsoleInputService
    {
        private MessageService msg = new MessageService();
        public bool RequestPlee(Creature creature)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                msg.PleaAccepted(); 
            }
            else if (key.Key == ConsoleKey.N)
            {
                msg.PleaDenyed();
                creature.LifeResource--;
                creature.State = State.Sick;
                return false;
            }
            else
            {
                msg.WrongKey();
            }
            return false;
        }
    }
}
