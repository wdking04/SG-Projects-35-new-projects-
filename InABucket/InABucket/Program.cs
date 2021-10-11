using System;

namespace InABucket
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can declare all KINDS of variables.

            string walrus;
            double piesEaten;
            float weightOfTeacupPig;
            int grainsOfSand;

            // But declaring them just sets up the space for data.
            // If you want to use the variable, you have to put data IN it first!
            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;

            Console.WriteLine("Meet my pet walrus, " + walrus);
            Console.Write("He was a bit hungry today and ate this many pies: ");
            Console.WriteLine(piesEaten);
        }
    }
}



