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
