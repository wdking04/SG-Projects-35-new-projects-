using System;

namespace WaitAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeNow = 5;
            int bedTime = 10;

            while (timeNow < bedTime)
            {
                Console.WriteLine("It's only " + timeNow + " o'clock!");
                Console.WriteLine("I think I'll stay up just a little longer....");
                timeNow++; // Time passes
            }

            Console.WriteLine("Oh. It's " + timeNow + " o'clock.");
            Console.WriteLine("Guess I should go to bed ...");
            Console.ReadLine();
        }
    }
}
