using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword
{
    class Turtle
    {
        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }

        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!!");
        }

    }
}
