using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTestProjectTask11.task11
{
    class Creature
    {
        private string Name;
        private const int LifeTime = 2;
        public int LifeResource = 3;
        public Plea Plea;
        public Plea PreviousPlea;
        public State State = State.Healthy;

        public Creature(string name)
        {
            this.Name = name;
        }

        internal void Live()
        {
            while (!(this.State == State.Dead))
            {
                Thread.Sleep(2_000);
                if (new DeathResolver().IsDead(this))
                {
                    break; 
                }
                OneIteration();
            }
       }
       

        public void OneIteration()
        {

            Plea = new PleaOperator().GeneratePleaRandomly(PreviousPlea);
            new PleaOperator().setPreviousPlea(this);
            new ConsoleInputServiceImpl().RequestPlee(this);
            /*Console.WriteLine("I want to " + Plea + " master. Press Y or N");
            if (State == State.Sick)
            {
                Console.WriteLine("I will be dead in " + LifeResource + " turns.");
            }
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Good");
            }
            else if (key.Key == ConsoleKey.N)
            {
                LifeResource--;
                State = State.Sick;
                Console.WriteLine("Bad");
            }
            else
            {
                Console.WriteLine("Other key pressed!");
            }*/
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
