using System;

namespace HiddenNuts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hidingSpots = new string[100];
            Random squirrel = new Random();
            hidingSpots[squirrel.Next(0, hidingSpots.Length)] = "Nut";
            Console.WriteLine("The nut has been hidden ...");

            // Nut finding code should go here!
            for (int i = 0; i< hidingSpots.Length; i++)
            {
                if ("Nut".Equals(hidingSpots[i]))
                {
                    Console.WriteLine("Found it! It's in spot # " + i);
                }
            }
        }
    }
}


//Project: HiddenNuts

//Squirrels like to hide their nuts, but they're not always very good about finding them again.

//Using the code snippet below as a base, iterate through the hiding spaces and find out where the squirrel put his nut and print it to the screen.

//What You Should See (Example)

//The nut has been hidden ...
//Found it! It's in spot# 42

