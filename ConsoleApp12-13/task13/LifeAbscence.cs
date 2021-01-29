using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12_13.task13
{
    class LifeAbscence
    {
        List<LivePlacer> livePlacers = new List<LivePlacer>();

        List<Fox> foxes = new List<Fox>();
        List<Rabbit> rabits = new List<Rabbit>();
        List<Grass> grass = new List<Grass>();
        public void WorldCreation()
        {
            for (int i = 0; i < 5; i++)   //world creation
            {
                foxes.Add(new Fox(5 + i));
                rabits.Add(new Rabbit(2 + i));
                grass.Add(new Grass());
            }
        }

        public void Living1Year()
        {
            if (!(foxes.Count > 5)) //foxes not birth
            {
                foxes.Add(new Fox(new Random().Next(4))); Console.WriteLine("fox birth.");
            }
            rabits.Add(new Rabbit(0));Console.WriteLine("rabbit birth.");
            if (grass.Count > 2) { rabits.Add(new Rabbit(0)); Console.WriteLine("rabbit birth."); }
            grass.Add(new Grass()); Console.WriteLine("grass generated");        //all birth
            foreach (Rabbit rabbit in rabits)
                {
                    rabbit.Age++;
                }
                foreach (Fox fox in foxes)
                {
                    fox.Age++;
                }
                Console.WriteLine("rabits and foxes become older on 1 year");
                if (rabits.Count > foxes.Count)    //death
                {
                    for (int i = 0; i < foxes.Count; i++)
                    {
                        foxes[i].Eat(rabits[i]); Console.WriteLine("rabit" + i + " were eaten by fox");
                    }
                }
                if (rabits.Count > grass.Count)   //death
                {
                    grass.Clear(); Console.WriteLine("gross is out.");
                    rabits.RemoveAt(new Random().Next(rabits.Count-1));
                }
                for(int i = 0; i < foxes.Count; i++)  //death
                {
                    if (foxes[i].Age > 10)
                    {
                    foxes.RemoveAt(i); Console.WriteLine("fox are dead.");
                    }
                }
                rabits.RemoveAt(new Random().Next(rabits.Count - 1)); Console.WriteLine("rabbit are dead.");
            }
        }
    }

