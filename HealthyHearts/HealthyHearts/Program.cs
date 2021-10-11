using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("What is your age? ");
            age = Convert.ToInt32(Console.ReadLine());

            int maxRate = 220 - age;

            float targetMin = .50f * maxRate;
            float targetMax = .85f * maxRate;

            int intTargetMin = (int)targetMin;
            int intTargetMax = (int)targetMax;


            Console.WriteLine("Your maximum heart rate should be " + maxRate + " beats per minute.");
            Console.WriteLine("Your target HR Zone is " + intTargetMin + " - " + intTargetMax + " beats per minute.");
        }
    }
}

//Healthy Hearts

//Write a program named HealthyHearts that asks the user for their age.
//It should then calculate the healthy heart rate range for that age,
//and display it.

//    Their maximum heart rate should be 220 - their age.
//    The target heart rate zone is the 50 - 85% of the maximum.

//Here's an example of what the program should do:

//What is your age? 50
//Your maximum heart rate should be 170 beats per minute
//Your target HR Zone is 85 - 145 beats per minute

