using System;
using System.Threading;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature carl = new Creature("Carl");
            carl.Live();
        }
    }

    internal class Creature
    {
        private string Name;
        private const int LifeTime = 2;
        private int Power = 3;
        Plea plea;
        private Plea previousPlea;
        State state = State.Healthy;
        
        public Creature(string name)
        {
            this.Name = name;
        }

        internal void Live()
        {
            while(!(this.state == State.Dead)){
                Thread.Sleep(2_000);
                
                if (Power <= 0)
                {
                    state = State.Dead;
                    Console.WriteLine("Your pet is dead!!!");
                    break;
                }
               /* if (plea == default  && previousPlea == plea)
                {
                    continue;
                }*/
                PleaHost();
                
            }
        }

        private void PleaHost()
        {
            Random random = new Random();
            plea = (Plea)random.Next(4);
            plea++;
            previousPlea = plea;
            Console.WriteLine("I want to " + plea + " master. Press Y or N");
            if (state == State.Sick)
            {
                Console.WriteLine("I will be dead in " + Power + " turns.");
            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y) {
                Console.WriteLine("Good");
            } else if (key.Key == ConsoleKey.N) {
                Power--;
                state = State.Sick;
                Console.WriteLine("Bad");
            }
            else
            {
                Console.WriteLine("Other key pressed!");
            }
            
        }
    }
    enum State
    {
        Healthy, Sick, Dead
    }
    enum Plea
    {
        Eat = 1, Walk = 2, Sleap = 3, Play = 4, Heal
    }
}
