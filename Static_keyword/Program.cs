using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> catArmy = new List<Cat>();
            List<Turtle> turtleArmy = new List<Turtle>();

            Random rand = new Random();

            //making the armies
            for (int i = 0; i < 100; i++)
            {
                if (rand.NextDouble() >= 0.5)
                {
                    catArmy.Add(new Cat());
                }
                else
                {
                    turtleArmy.Add(new Turtle());
                }
            }

            //Code to tell each cat how many cats there are
            //We'll need to run all this code any time we add a cat

            int totalCats = catArmy.Count;

            foreach (Cat cat in catArmy)
            {
                cat.CatCount = totalCats;
            }

            catArmy[0].WarCry();

            //Code to tell each turtle how many
            //turtles there are.

            Turtle.WarCry();
        }
    }
}
