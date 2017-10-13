using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword
{
    class Turtle
    {
        //static for the field and the method.
        //static variable is shared among all instance of class.
        //this also means we can use the variable without creating 
        //instances first.
        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }

        //This static method belongs to the class
        //It's shared by all instances.
        //It means we can use the method without creating
        //any instances first.
        //That's why we've been making static methods in Program
        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!!");
        }

    }
}
