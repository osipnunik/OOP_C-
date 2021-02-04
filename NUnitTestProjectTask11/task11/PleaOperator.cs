using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTask11.task11
{
    class PleaOperator
    {
        public Plea GeneratePleaRandomly(Plea previous)
        {
            Random random = new Random();
            Plea plea;
            while (true)
            {
                plea = (Plea)random.Next(4);
                plea++;
                if (!(previous.Equals(plea)))
                {
                    return plea;
                }
                else
                {
                    continue;
                }
            }
        }

        internal void setPreviousPlea(Creature creature)
        {
            creature.PreviousPlea = creature.Plea;
        }
    }
}
