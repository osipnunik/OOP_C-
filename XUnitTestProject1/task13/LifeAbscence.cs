using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_13.task13
{
    class LifeAbscence
    {
        public List<LivePlacer> LivePlacers = new List<LivePlacer>();
        public List<Fox> Foxes = new List<Fox>();
        public List<Rabbit> Rabits = new List<Rabbit>();
        public List<Grass> Grass = new List<Grass>();
        public void WorldCreation()
        {
            for (int i = 0; i < 5; i++)   //world creation
            {
                Foxes.Add(new Fox(5 + i));
                Rabits.Add(new Rabbit(2 + i));
                Grass.Add(new Grass());
            }
        }

        public void Living1Year()
        {
            if (!(Foxes.Count > 5)) //foxes not birth
            {
                Foxes.Add(new Fox(new Random().Next(4))); Console.WriteLine("fox birth.");
            }
            Rabits.Add(new Rabbit(0));Console.WriteLine("rabbit birth.");
            if (Grass.Count > 2) { Rabits.Add(new Rabbit(0)); Console.WriteLine("rabbit birth."); }
            Grass.Add(new Grass()); Console.WriteLine("grass generated");        //all birth
            foreach (Rabbit rabbit in Rabits)
                {
                    rabbit.Age++;
                }
                foreach (Fox fox in Foxes)
                {
                    fox.Age++;
                }
                Console.WriteLine("rabits and foxes become older on 1 year");
                if (Rabits.Count > Foxes.Count)    //death
                {
                    for (int i = 0; i < Foxes.Count; i++)
                    {
                        Foxes[i].Eat(Rabits[i]); Console.WriteLine("rabit" + i + " were eaten by fox");
                    }
                }
                if (Rabits.Count > Grass.Count)   //death
                {
                    Grass.Clear(); Console.WriteLine("gross is out.");
                    Rabits.RemoveAt(new Random().Next(Rabits.Count-1));
                }
                for(int i = 0; i < Foxes.Count; i++)  //death
                {
                    if (Foxes[i].Age > 10)
                    {
                    Foxes.RemoveAt(i); Console.WriteLine("fox are dead.");
                    }
                }
                Rabits.RemoveAt(new Random().Next(Rabits.Count - 1)); Console.WriteLine("rabbit are dead.");
            }
        }
    }

