using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectTask11.task11
{
    class DeathResolver
    {
        private MessageService msg = new MessageService();
        public bool IsDead(Creature creature)
        {
            if(creature.LifeResource <= 0)
            {
                creature.State = State.Dead;
                msg.DeathMessage();
                return true;
            }
            return false;
        }
    }
}
